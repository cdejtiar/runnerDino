class PosicionLibre : IObstaculo
{
    public string AlturaObstaculo => "no hay";

    public bool LoMato(Jugador jugador)
    {
        return false;
    }
}