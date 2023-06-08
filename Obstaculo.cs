abstract class Obstaculo : IObstaculo
{
    // int posicion;

    // public Obstaculo(int posicion)
    // { //constructor
    //     this.posicion = posicion;
    // }

    // public int PosicionObstaculo
    // {
    //     get { return posicion; }
    // }
    public abstract string AlturaObstaculo
    {
        get; 
    }

    public abstract bool LoMato(Jugador jugador);
}