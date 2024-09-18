using System.Threading.Tasks;
using Trydem.Models;

namespace Trydem.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
