enum EstadoJugador
{
    Normal, Saltando, Agachado
}

class Jugador
{
    // const int SALUD_MAXIMA = 100;

    // int saludActual;
    int turno;
    int posicion;
    public EstadoJugador estado;

    public Jugador(int turno, int posicion, EstadoJugador estado) //constructor de jugador
    {
        this.turno = turno;
        this.posicion = posicion;
        this.estado = estado;
    }

    public int Posicion //get y set de posicion
    {
        get { return posicion; }
        set
        {
            if (posicion < 0)
            {
                throw new Exception($"Me pasaron una posición inválida {posicion}");
            }
            else
            {
                posicion = value; //actualiza la posicion en base al valor que se le pasa
            }
        }
    }

    public int avanzarTurno() //método para avanzar
    {
        Console.WriteLine($"El valor de turno es: {turno}");
        turno++;
        Console.WriteLine($"El valor actualizado de turno es: {turno}");
        return turno;
    }


    // public int Salud
    // {
    //     get { return saludActual; }
    //     set
    //     {
    //         // if (value < 0 || value > SALUD_MAXIMA)
    //         //     throw new Exception($"Me pasaron la salud invalida {value}");
    //         if (value < 0)
    //             saludActual = 0;
    //         else if (value > SALUD_MAXIMA)
    //             saludActual = SALUD_MAXIMA;
    //         else
    //             saludActual = value;
    //     }
    // }

    // public Jugador()
    // {
    //     this.saludActual = Jugador.SALUD_MAXIMA;
    // }

    // public Jugador(int saludActual)
    // {
    //     this.saludActual = saludActual;
    // }
}