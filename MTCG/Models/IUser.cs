
// Interface for a user
public interface IUser
{
    string Username { get; }
    string Password { get; }
    List<ICard> Stack { get; }
    List<ICard> Deck { get; }
    int Coins { get; }

    // Add methods for managing cards, buying packages, etc.
}

