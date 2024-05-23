using EmployeeManagement.Model;
using EmployeeManagement.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace EmployeeManagement.Services
{
    public class LoginService
    {
        private static int ITERATIONS = 350000;
        private static int KEY_SIZE = 64;
        private static HashAlgorithmName HASH_ALGORITHM = HashAlgorithmName.SHA512;
        private static readonly EmployeeRepository repository = new EmployeeRepository();

        public Employee LogIn(string login, string password)
        {
            Employee employee = repository.GetEmployeeByLogin(login);
            if (employee == null) return null;

            return (VerifyPassword(password, employee.Password) ? employee : null);
        }

        public void RegisterNewEmployee(Employee employee)
        {
            byte[] salt;
            string hashedPassword = HashPassword(employee.Password, out salt);
            employee.Password = $"{hashedPassword}:{Convert.ToHexString(salt)}";

            repository.AddElement(employee);
        }

        private string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(KEY_SIZE);

            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, ITERATIONS, HASH_ALGORITHM, KEY_SIZE);
            return Convert.ToHexString(hash);
        }

        private bool VerifyPassword(string passwordToVerify, string hashedPassword)
        {
            string[] passwordParts = hashedPassword.Split(":");

            return VerifyPasswordWithHash(passwordToVerify, passwordParts[0], Convert.FromHexString(passwordParts[1]));
        }

        private bool VerifyPasswordWithHash(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, ITERATIONS, HASH_ALGORITHM, KEY_SIZE);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
