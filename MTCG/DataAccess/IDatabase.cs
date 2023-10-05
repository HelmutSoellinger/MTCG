
// Interface for a data access layer (DAL) to interact with the database
public interface IDatabase
{
    IUser GetUserByUsername(string username);
    void SaveUser(IUser user);
    CardPackage GetCardPackage();
    // Add additional methods as needed
}
