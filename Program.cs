class Program
{
    public static void Main()
    {
        var jugador = new Jugador(0, EstadoJugador.Normal); //definimos un nuevo jugador
        var pista = new Pista(); //definimos la pista
        int cont = 0;
        bool matado = false;

            //pista.crearPista();
            while(!matado && cont < 4){
            //punto 2 y 3
            var posicionActual = pista.posiciones[cont];

            //punto 4
            //jugador.AccionRandom();
            ConsoleKeyInfo key = Console.ReadKey();
                jugador.TocoTecla(key);

            Console.WriteLine($"El jugador está {jugador.estado}");
            
            matado = posicionActual.LoMato(jugador);
            Console.WriteLine($"El obstaculo actual es {posicionActual.AlturaObstaculo}. Lo mato? {matado}");

            //punto 1
            jugador.avanzarTurno();

            cont++;
        }

        if(matado){
            Console.WriteLine("Sos un loser, chocaste");
        } else {
            Console.WriteLine("Sos un winnner, ganaste");
        }
    }
}
