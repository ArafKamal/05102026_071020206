using System.Text;

namespace _05102026_07102026
{
    internal sealed class FileLogger
    {
        private static readonly Lazy<FileLogger> Logger = new(() => new FileLogger());
        private readonly object _lock = new();

        private FileLogger()
        {
            LogPath = Path.Combine(AppContext.BaseDirectory, "logs", "app.log");
            Directory.CreateDirectory(Path.GetDirectoryName(LogPath)!);
        }

        public static FileLogger Instance => Logger.Value;

        internal string LogPath { get; }

        public void Log(string message)
        {
            ArgumentNullException.ThrowIfNull(message);

            var entry = $"{DateTimeOffset.Now:O} {message}{Environment.NewLine}";
            lock (_lock)
            {
                File.AppendAllText(LogPath, entry, Encoding.UTF8);
            }
        }
    }
}
