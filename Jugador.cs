enum EstadoJugador
{
    Normal, Saltando, Agachado
}

class Jugador
{
    // const int SALUD_MAXIMA = 100;

    // int saludActual;
    int turno;
    // int posicion;
    public EstadoJugador estado;
    static Random rand = new Random();
    static List<EstadoJugador> estados = new List<EstadoJugador>(){
        EstadoJugador.Normal, EstadoJugador.Saltando, EstadoJugador.Agachado
    };

    public Jugador(int turno, /*int posicion,*/ EstadoJugador estado) //constructor de jugador
    {
        this.turno = turno;
        // this.posicion = posicion;
        this.estado = estado;
    }

    // public int Posicion //get y set de posicion
    // {
    //     get { return posicion; }
    //     set
    //     {
    //         if (posicion < 0)
    //         {
    //             throw new Exception($"Me pasaron una posición inválida {posicion}");
    //         }
    //         else
    //         {
    //             posicion = value; //actualiza la posicion en base al valor que se le pasa
    //         }
    //     }
    // }

    public void avanzarTurno() //método para avanzar
    {
        Console.WriteLine($"El valor de turno es: {turno}");
        turno++;
        Console.WriteLine($"El valor actualizado de turno es: {turno}");

        estado = EstadoJugador.Normal;
    }

    public void Saltar(){
        estado = EstadoJugador.Saltando;
    }

    public void Agachar(){
        estado = EstadoJugador.Agachado;
    }

    public void AccionRandom(){
        estado = NextInList<EstadoJugador>(estados);
    }

    public T NextInList<T>(List<T> lista)
    {
        return lista[rand.Next(lista.Count)];
    }

    public event Action<EstadoJugador>? EstadoCambiado;
    public void TocoTecla(ConsoleKeyInfo key){
        if (key.Key == ConsoleKey.UpArrow)
            Saltar();
        else if (key.Key == ConsoleKey.DownArrow)
            Agachar();
        
        if (EstadoCambiado != null){
            EstadoCambiado(estado);
        }
    }
}