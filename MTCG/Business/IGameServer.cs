
// Updated interface for the game server with additional methods for game mechanics
public interface IGameServer
{
    IUser RegisterUser(string username, string password);
    IUser AuthenticateUser(string username, string password);
    CardPackage BuyCardPackage(IUser user);
    bool BuildDeck(IUser user, List<ICard> selectedCards);
    bool Battle(IUser challenger, IUser opponent);
    List<IUser> GetLeaderboard();
    // Add additional methods as needed
}
