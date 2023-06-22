class Input{
    Jugador jugador;

    public Input (Jugador jugador){
        this.jugador = jugador;
        jugador.EstadoCambiado += CambioEstado;
    }
    private void CambioEstado (EstadoJugador NuevoEstado) {
        jugador.estado = NuevoEstado;
    }
}