class ObstaculoBajo : Obstaculo
{

    public override string AlturaObstaculo => "bajo";

    public override bool LoMato(Jugador jugador)
    {
        return jugador.estado != EstadoJugador.Saltando;
    }
}