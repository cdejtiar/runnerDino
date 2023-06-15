class Pista
{
    // public List<IObstaculo> posiciones = new List<IObstaculo>(){
    // new PosicionLibre(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre()
    // };
    public WeightedList<IObstaculo> posiciones = new WeightedList<IObstaculo>()
    {
        new List<IObstaculo>()
                {
                    new Posicion() { AlturaObstaculo = "no hay", Weight = 6 },
                    new Posicion() { AlturaObstaculo = "alto", Weight = 2 },
                    new Posicion() { AlturaObstaculo = "bajo", Weight = 2 },
                }
    };

    public void crearPista()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(posiciones.Evaluate());
        }
    }
}