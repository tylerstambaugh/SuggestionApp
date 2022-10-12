namespace SuggestionAppLibrary.DataAccess;

public interface IUserData
{
    Task CreateUser(UserModel user);
    Task<UserModel> GetUserByAuth(string objectId);
    Task<UserModel> GetUserById(string id);
    Task<List<UserModel>> GetUsersAsync();
    Task UpdateUser(UserModel user);
}