using LogisticApp.DTOs;
using LogisticApp.Models;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace LogisticApp.Services
{
    public class AuthService
    {
        private readonly MongoDbService _mongoDbService;

        public AuthService(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public async Task<AuthResult> RegisterAsync(RegisterRequest request)
        {
            var existingUser = await _mongoDbService.Users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
            if (existingUser != null)
            {
                return new AuthResult { Success = false, Message = "User already exists" };
            }


            var newUser = new User { Email = request.Email, Password = BCrypt.Net.BCrypt.HashPassword(request.password) };
            await _mongoDbService.Users.InsertOneAsync(newUser);
            return new AuthResult { Success = true };
        }

        public async Task<AuthResult> LoginAsync(LoginRequest request)
        {
            var user = await _mongoDbService.Users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
            if (user == null || !Bcrypt.Net.Bcrypt.Verify(request.Password, user.Password))
            {
                return new AuthResult { Success = false, Message = "Invalid credentials" };
            }

            // generate token jwt (simplified)
            var token = "some-jwt-token";
            return new AuthResult { Success = true, Token = token };
        }
    }
}