class ObstaculoBajo : IObstaculo
{
    public string AlturaObstaculo => "bajo";

    public bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Saltando;
    }
}