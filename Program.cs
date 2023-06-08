class Program
{
    static void Main()
    {
        var jugador = new Jugador(0, 0, EstadoJugador.Saltando); //definimos un nuevo jugador
        var pista = new Pista(); //definimos la pista

        for (int i = 0; i < pista.posiciones.Count; i++)//simulamos el juego
        {
            //punto 1
            Console.WriteLine($"La posición inicial es: {jugador.Posicion}");
            Console.WriteLine($"La posición al entrar al for es: {jugador.Posicion}");
            jugador.Posicion = jugador.avanzarTurno(); //le asignamos la posición actualizada en base a llamar al método avanzar
            Console.WriteLine($"La posición actualizada es: {jugador.Posicion}");

            //punto 2 y 3
            var posicionActual = pista.posiciones[i];
            bool matado = posicionActual.LoMato(jugador);
            Console.WriteLine($"El obstaculo actual es {posicionActual.AlturaObstaculo}. Lo mato? {matado}");
        }

        /*if (obstaculoAlto.Altura == "alto")
        {
            if (jugador.Posicion == obstaculoAlto.PosicionObstaculo)
            {
                Console.WriteLine($"Encontramos un obstáculo alto en {jugador.Posicion}");
            } else {
                Console.WriteLine($"No encontramos ningún obstáculo alto en {jugador.Posicion}");
            }
        } 

        if(obstaculoBajo.Altura == "bajo") {
            if (jugador.Posicion == obstaculoBajo.PosicionObstaculo)
            {
                Console.WriteLine($"Encontramos un obstáculo bajo en {jugador.Posicion}");
            } else {
                Console.WriteLine($"No encontramos ningún obstáculo bajo en {jugador.Posicion}");
            }
        }*/

        // Console.WriteLine($"Salud inicial: {jugador.Salud}");

        // var bomba = new ItemDaniador("Bomba", 30);
        // bomba.Usar(jugador);
        // Console.WriteLine($"Salud post bomba: {jugador.Salud}");

        // var pocion = new ItemCurador("Pocion magica", 20);
        // pocion.Usar(jugador);
        // Console.WriteLine($"Salud post pocion: {jugador.Salud}");

        // var varita = new ItemCurador("Varita magica", 50);
        // varita.Usar(jugador);
        // Console.WriteLine($"Salud post Varita magica: {jugador.Salud}");


        // var item = new Item("Varita magica");
        // item.Usar(jugador);
        // Console.WriteLine($"Salud post varita: {jugador.Salud}");
    }
}
