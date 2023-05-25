class Obstaculo
{
    int posicion;
    string altura;

    public Obstaculo(int posicion, string altura)
    { //constructor
        this.posicion = posicion;
        this.altura = altura; //esperar a ver que dice Diego
    }

    public int PosicionObstaculo
    {
        get { return posicion; }
    }
    public string Altura
    {
        get { return altura; }
    }
}