using System.Collections.Generic;

class Pista
{
    // public List<IObstaculo> posiciones = new List<IObstaculo>(){
    //  new PosicionLibre(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre(), new ObstaculoAlto(), new ObstaculoBajo(), new PosicionLibre()
    //  };

    public WeightedList<PosiblePosicion> posiciones = new WeightedList<PosiblePosicion>(
       new List<PosiblePosicion>()
       {
           new PosiblePosicion() { obstaculo = new PosicionLibre(), weight = 3 },
           new PosiblePosicion() { obstaculo = new ObstaculoAlto(), weight = 1 },
           new PosiblePosicion() { obstaculo = new ObstaculoBajo(), weight = 1 },
       }
   );

    private List<IObstaculo> elegidos;
    public List<IObstaculo> Elegidos => elegidos;

    public Pista()
    {
        elegidos = new List<IObstaculo>();
        elegidos.Add(new PosicionLibre());

        for (int i = 0; i < 10; i++)
        {
            var posicionElegida = posiciones.Evaluate();
            elegidos.Add(posicionElegida.obstaculo);
        }

        Console.WriteLine(string.Join(", ", elegidos));
    }
}
