class Pista
{
    public List<IObstaculo> posiciones = new List<IObstaculo>(){
        new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo()
    };
}