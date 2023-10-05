

public class User : IUser
{
    // Implement the properties/methods of IUser interface
    public List<ICard> Deck { get; private set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Score => Wins - Losses;

    // Add methods for trading cards, battling, etc.
}