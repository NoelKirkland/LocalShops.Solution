using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using LocalShops.Models;
using LocalShops.Helpers;

namespace LocalShops.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }

    public class UserService : IUserService
    {
        // private List<User> _users = new List<User>
        // {
        // new User { Id = 1, Username = "noel", Password = "noel", Role = Role.Admin },
        // new User { Id = 2, Username = "user", Password = "user", Role = Role.User }
        // };

        private LocalShopsContext _users;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, LocalShopsContext db)
        {
            _users = db;
            _appSettings = appSettings.Value;
        }

        public User Authenticate(string username, string password)
        {
            var user = _users.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            // return users without passwords
            List<User> list = new List<User>{};
            list = _users.Users.ToList();
            return list.Select(x => {
                x.Password = null;
                return x;
            });
        }

        public User GetById(int id) {
            var user = _users.Users.FirstOrDefault(x => x.Id == id);

            // return user without password
            if (user != null) 
                user.Password = null;

            return user;
        }
    }
}