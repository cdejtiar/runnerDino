class Pista
{
    public List<IObstaculo> posiciones = new List<IObstaculo>(){
    new PosicionLibre(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre()
    };
    // public WeightedList<IWeightableObstaculo> posiciones = new WeightedList<IWeightableObstaculo>()
    // {
    //     new List<IWeightableObstaculo>()
    //             {
    //                 new Posicion() { AlturaObstaculo = "no hay", Weight = 6 },
    //                 new Posicion() { AlturaObstaculo = "alto", Weight = 2 },
    //                 new Posicion() { AlturaObstaculo = "bajo", Weight = 2 },
    //                 crearPista()
    //             }
    // };

    // public void crearPista()
    // {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         Console.WriteLine(posiciones.Evaluate());
    //     }
    // }
    //};
}