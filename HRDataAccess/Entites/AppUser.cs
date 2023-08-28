using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace HRDataAccess.Entites
{
    public class AppUser : IdentityUser
    {
        public readonly ClaimsIdentity Username;
    }
}
