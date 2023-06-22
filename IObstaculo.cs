interface IObstaculo
{
    string AlturaObstaculo{ get; }
    
    bool LoMato(Jugador jugador);
}