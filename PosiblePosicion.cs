class PosiblePosicion : IWeightable
{
    public IObstaculo obstaculo;
    public int weight;

    public int Weight => weight;

    // public override string ToString()
    // {
    //     return AlturaObstaculo;
    // }
}
