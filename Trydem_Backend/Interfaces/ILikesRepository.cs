using System.Collections.Generic;
using System.Threading.Tasks;
using Trydem.DTOs;
using Trydem.Helpers;
using Trydem.Models;

namespace Trydem.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userID);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

    }
}
