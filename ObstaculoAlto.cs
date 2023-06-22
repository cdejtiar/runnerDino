class ObstaculoAlto : IObstaculo
{
    public string AlturaObstaculo => "alto";

    public bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Agachado;
    }
}