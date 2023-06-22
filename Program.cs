using System;

static class Program
{
    public static void Main()
    {
        var jugador = new Jugador(0, EstadoJugador.Normal); //definimos un nuevo jugador
        var pista = new Pista(); //definimos la pista
        var input = new Input();

        foreach (var obstaculoActual in pista.Elegidos)
        {
            Console.WriteLine($"El obstaculo actual es {obstaculoActual}");

            //punto 4
            var key = input.processInput();
            Program.TocoTecla(key, jugador);

            if (obstaculoActual.LoMato(jugador))
            {
                Console.WriteLine("Sos un loser, chocaste");
                return;
            }

            //punto 1
            jugador.avanzarTurno();
        }

        Console.WriteLine("Sos un winnner, ganaste");
    }

    public static void TocoTecla(Input.AccionHumano accion, Jugador jugador)
    {
        if (accion == Input.AccionHumano.Arriba)
            jugador.Saltar();
        else if (accion == Input.AccionHumano.Abajo)
            jugador.Agachar();
    }
}
