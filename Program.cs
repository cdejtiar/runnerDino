class Program
{
    public static void Main()
    {
        var jugador = new Jugador(0, EstadoJugador.Normal); //definimos un nuevo jugador
        var pista = new Pista(); //definimos la pista
        bool matado = false;
        //var gameOver = new FinDeJuego(jugador, matado); Intentamos hacerlo con evento el gameOver.

            //pista.crearPista();
            while(!matado && jugador.turno < 4){
            //punto 2 y 3
            var posicionActual = pista.posiciones[jugador.turno];

            //punto 4
            //jugador.AccionRandom();
            jugador.processInput();

            matado = posicionActual.LoMato(jugador);
            Console.WriteLine($"El obstaculo actual es {posicionActual.AlturaObstaculo}. Lo mato? {matado}");

            //punto 1
            jugador.avanzarTurno();
        }

        // checkWinLose(matado); sabemos que va adentro de FinDelJuego

        if(matado){
            Console.WriteLine("Sos un loser, chocaste");
        } else {
            Console.WriteLine("Sos un winnner, ganaste");
        }
    }
}
