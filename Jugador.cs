using System;
using System.Collections.Generic;

enum EstadoJugador
{
    Normal, Saltando, Agachado
}

/// <summary>
/// 1. Avanza el turno
/// 2. Maneja estados del jugador
/// 3. Escuchando el teclado
/// </summary>
class Jugador
{
    public int turno;
    public EstadoJugador estado;
    // static Random rand = new Random();
    // static List<EstadoJugador> estados = new List<EstadoJugador>(){
    //     EstadoJugador.Normal, EstadoJugador.Saltando, EstadoJugador.Agachado
    // };

    public Jugador(int turno, EstadoJugador estado) //constructor de jugador
    {
        this.turno = turno;
        this.estado = estado;

        this.avanzarTurno();
    }

    public void avanzarTurno() //método para avanzar
    {
        Console.WriteLine($"El valor de turno es: {turno}");
        turno++;
        // Console.WriteLine($"El valor actualizado de turno es: {turno}");

        estado = EstadoJugador.Normal;
        Console.WriteLine($"El jugador está {estado}");
    }

    public void Saltar()
    {
        estado = EstadoJugador.Saltando;
        Console.WriteLine($"El jugador está {estado}");
    }

    public void Agachar()
    {
        estado = EstadoJugador.Agachado;
        Console.WriteLine($"El jugador está {estado}");
    }

    // public void AccionRandom()
    // {
    //     estado = NextInList<EstadoJugador>(estados);
    // }

    // public T NextInList<T>(List<T> lista)
    // {
    //     return lista[rand.Next(lista.Count)];
    // }


}
