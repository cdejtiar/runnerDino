class ObstaculoAlto : Obstaculo
{
    public override string AlturaObstaculo => "alto";

    public override bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Agachado;
    }
}