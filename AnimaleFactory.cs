namespace _05102026_07102026
{
    internal enum TipoAnimale
    {
        Cane,
        Gatto,
        Pollo
    }

    internal static class AnimaleFactory
    {
        public static Animale Crea(TipoAnimale tipo, string nome, int eta)
        {
            return tipo switch
            {
                TipoAnimale.Cane => new Cane(nome, eta),
                TipoAnimale.Gatto => new Gatto(nome, eta),
                TipoAnimale.Pollo => new Pollo(nome, eta),
                _ => throw new ArgumentOutOfRangeException(nameof(tipo), tipo, "Tipo di animale non supportato.")
            };
        }
    }
}
