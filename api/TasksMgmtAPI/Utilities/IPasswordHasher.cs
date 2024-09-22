namespace TasksMgmtAPI.Utilities
{
    public interface IPasswordHasher
    {
        string GeneratePasswordHash(string password);

        bool VerifyPassword(string password);
    }
}
