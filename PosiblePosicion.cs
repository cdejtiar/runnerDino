abstract class PosiblePosicion : IWeightable
{
    public string AlturaObstaculo;
    public int weight;

    public int Weight => weight;

    public override string ToString()
    {
        return AlturaObstaculo;
    }
}
