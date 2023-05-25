class Program
{
    static void Main()
    {
        var jugador = new Jugador(0, 0, "normal"); //definimos un nuevo jugador

        Console.WriteLine($"La posición inicial es: {jugador.Posicion}");

        while (jugador.Posicion <= 10)
        { //simulamos el juego
            Console.WriteLine($"La posición al entrar al while es: {jugador.Posicion}");
            jugador.Posicion = jugador.avanzarTurno(); //le asignamos la posición actualizada en base a llamar al método avanzar
            Console.WriteLine($"La posición actualizada es: {jugador.Posicion}");
        }

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
