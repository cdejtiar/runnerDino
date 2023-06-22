class ObstaculoBajo : IObstaculo
{
    public bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Saltando;
    }
}
