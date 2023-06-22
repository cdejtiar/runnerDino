class ObstaculoAlto : IObstaculo
{
    public bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Agachado;
    }
}
