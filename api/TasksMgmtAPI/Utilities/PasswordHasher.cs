using System.Security.Cryptography;

namespace TasksMgmtAPI.Utilities
{
    public class PasswordHasher : IPasswordHasher
    {
        private const int SaltSize = 16; //128 bits = 16 bytes
        private const int HashSize = 32; //256 bits = 32 bytes
        private const int Iterations = 100000;

        private readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;
        public string GeneratePasswordHash(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithm, HashSize);

            var hashedPassword = $"{Convert.ToHexString(hash)}{"-"}{Convert.ToHexString(salt)}";

            return hashedPassword;
        }

        public bool VerifyPassword(string loginPassword, string savedPassword)
        {
            var parts = savedPassword.Split('-');

            byte[] savedHash = Convert.FromHexString(parts[0]);
            byte[] salt = Convert.FromHexString(parts[1]);

            byte[] derivedHashFromLoginPassword = Rfc2898DeriveBytes.Pbkdf2(loginPassword, salt, Iterations, HashAlgorithm, HashSize);

            //If savedHash and derivedHashFromLoginPassword are equal, then password is CORRECT else NOT
            return CryptographicOperations.FixedTimeEquals(savedHash, derivedHashFromLoginPassword);
        }
    }
}
