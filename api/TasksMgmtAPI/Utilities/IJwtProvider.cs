using TasksMgmt.Core.Entities;

namespace TasksMgmt.API.Utilities
{
    public interface IJwtProvider
    {
        string GenerateToken(User user);
    }
}
