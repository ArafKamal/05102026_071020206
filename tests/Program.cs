using _05102026_07102026;

TestFactoryCreatesAnimals();
TestFactoryRejectsUnsupportedAnimal();
TestLoggerIsSingletonAndWritesConcurrentEntries();
Console.WriteLine("All tests passed.");

static void TestFactoryCreatesAnimals()
{
    var cane = AnimaleFactory.Crea(TipoAnimale.Cane, "Fido", 4);
    var gatto = AnimaleFactory.Crea(TipoAnimale.Gatto, "Micio", 3);
    var pollo = AnimaleFactory.Crea(TipoAnimale.Pollo, "Pio", 1);

    Assert(cane is Cane && cane.Nome == "Fido" && cane.Age == 4 && cane.Verso() == "Bau", "Dog factory result");
    Assert(gatto is Gatto && gatto.Nome == "Micio" && gatto.Age == 3 && gatto.Verso() == "Miao", "Cat factory result");
    Assert(pollo is Pollo && pollo.Nome == "Pio" && pollo.Age == 1 && pollo.Verso() == "Verso del pollo", "Chicken factory result");
}

static void TestFactoryRejectsUnsupportedAnimal()
{
    try
    {
        AnimaleFactory.Crea((TipoAnimale)999, "Test", 1);
        throw new InvalidOperationException("Factory accepted an unsupported animal type.");
    }
    catch (ArgumentOutOfRangeException)
    {
    }
}

static void TestLoggerIsSingletonAndWritesConcurrentEntries()
{
    var logger = FileLogger.Instance;
    Assert(ReferenceEquals(logger, FileLogger.Instance), "Logger singleton identity");

    var runId = Guid.NewGuid().ToString("N");
    Parallel.For(0, 32, index => logger.Log($"test-{runId}-{index}"));

    var logContents = File.ReadAllText(logger.LogPath);
    for (var index = 0; index < 32; index++)
    {
        Assert(logContents.Contains($"test-{runId}-{index}", StringComparison.Ordinal), $"Logger entry {index}");
    }
}

static void Assert(bool condition, string description)
{
    if (!condition)
    {
        throw new InvalidOperationException($"Test failed: {description}");
    }
}
