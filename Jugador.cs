using System;
using System.Collections.Generic;

enum EstadoJugador
{
    Normal, Saltando, Agachado
}

class Jugador
{
    public int turno;
    public EstadoJugador estado;
    static Random rand = new Random();
    static List<EstadoJugador> estados = new List<EstadoJugador>(){
        EstadoJugador.Normal, EstadoJugador.Saltando, EstadoJugador.Agachado
    };

    public Jugador(int turno, EstadoJugador estado) //constructor de jugador
    {
        this.turno = turno;
        this.estado = estado;
    }

    public void avanzarTurno() //método para avanzar
    {
        Console.WriteLine($"El valor de turno es: {turno}");
        turno++;
        Console.WriteLine($"El valor actualizado de turno es: {turno}");

        estado = EstadoJugador.Normal;
    }

    public void processInput()
    {
        ConsoleKeyInfo key = Console.ReadKey();
        TocoTecla(key);

        Console.WriteLine($"El jugador está {estado}");
    }

    public void Saltar()
    {
        estado = EstadoJugador.Saltando;
    }

    public void Agachar()
    {
        estado = EstadoJugador.Agachado;
    }

    public void AccionRandom()
    {
        estado = NextInList<EstadoJugador>(estados);
    }

    public T NextInList<T>(List<T> lista)
    {
        return lista[rand.Next(lista.Count)];
    }

    public event Action<EstadoJugador>? EstadoCambiado;
    public void TocoTecla(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.UpArrow)
            Saltar();
        else if (key.Key == ConsoleKey.DownArrow)
            Agachar();

        if (EstadoCambiado != null)
        {
            EstadoCambiado(estado);
        }
    }
}
