using Data.Entities;

namespace Data.Services;

public interface IUserManager
{
    public void SignIn(User user);

    public void SignOut();
    
    public int? UserId { get; }
    
    public bool IsAuthenticated { get; }
}