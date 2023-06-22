class Pista
{
     public List<IObstaculo> posiciones = new List<IObstaculo>(){
     new PosicionLibre(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre()
     };
     /*public WeightedList<IObstaculo> posiciones = new WeightedList<IObstaculo>(
        new List<IObstaculo>()
        {
            new PosiblePosicion() { AlturaObstaculo = new PosicionLibre(), Weight = 6 },
            new PosiblePosicion() { AlturaObstaculo = new ObstaculoAlto(), Weight = 2 },
            new PosiblePosicion() { AlturaObstaculo = new ObstaculoBajo(), Weight = 2 },
        }
    );

    public void crearPista()
    {
        var elegidos = new List<IObstaculo>();

        for (int i = 0; i < 10; i++)
        {
            var ObstaculoElegido = posiciones.Evaluate();
            elegidos.Add(ObstaculoElegido.AlturaObstaculo);
        }
        Console.WriteLine($"{elegidos}");
    }
*/

}