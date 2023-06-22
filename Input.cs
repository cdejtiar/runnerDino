class Input{
    Jugador jugador;

    public Input (Jugador jugador){
        this.jugador = jugador;
        jugador.EstadoCambiado += CambioEstado;
    }
    private void CambioEstado (EstadoJugador NuevoEstado) {
        jugador.estado = NuevoEstado;
    }
    /*
    class TestEvents
    {
        public static void Run()
        {
            var jugador = new Jugador();
            var barra = new BarraSalud(jugador);
            var ventana = new VentanaFinDeJuego(jugador);

            while (!ventana.JuegoTerminado)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                    Console.WriteLine("Saltando");
                else if (key.Key == ConsoleKey.DownArrow)
                    Console.WriteLine("Agachando");

                // jugador.Daniar(30);
            }

            Console.WriteLine("Juego terminado");
        }
    }*/
}