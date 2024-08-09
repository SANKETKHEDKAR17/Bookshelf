using Application.bookshelf.Core;
using Application.bookshelf.Repository;
using Application.bookshelf.Services;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;

    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<User> GetUserbyUserNameAndPassword(string email, string password)
    {
        return await _userRepo.GetUserbyUserNameAndPassword(email, password);
    }
}
