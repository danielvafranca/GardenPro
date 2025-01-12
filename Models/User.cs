using System;

namespace GardenPro.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PassWordHash { get; set; }
    public string Slug { get; set; }

    public Ilis<Role> Roles { get; set; }

    public IEnumerable<Claim> GetClaims()
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, Id.ToString()),
            new Claim(ClaimTypes.Name, Name),
            new Claim(ClaimTypes.Email, Email)
        };
        if(Roles != null)
        {
            foreach(var role in Roles)
            {
                claims.Add(new claim(ClaimTypes.Role, role.Name));
            }
        }
        return claims;
    }

}
