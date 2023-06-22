/// <summary>
/// Escuchar entradas de datos del humano
/// </summary>
class Input
{
    public enum AccionHumano { Arriba, Abajo, Nada }

    public AccionHumano processInput()
    {
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.UpArrow)
            return AccionHumano.Arriba;
        else if (key.Key == ConsoleKey.DownArrow)
            return AccionHumano.Abajo;
        else
            return AccionHumano.Nada;
    }

}
