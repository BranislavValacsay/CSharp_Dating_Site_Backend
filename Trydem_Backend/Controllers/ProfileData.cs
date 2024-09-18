using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UdemyLogin.Data;
using UdemyLogin.Models;
using UdemyLogin.DTOs;
using System.Linq;

namespace UdemyLogin.Controllers
{
    public class ProfileDataController : BaseApiController
    {
        private readonly DataContext _context;

        public ProfileDataController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfileData>>> GetUsersProfiles()
        {
            var result = await _context.ProfileData.ToListAsync();
            return Ok(result);
        }

        /*
        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ActionResult<IEnumerable<ProfileData>>> GetUserProfile(int id)
        {
            //var fck = await _context.ProfileData.Where(e => e.Id == id).ToListAsync();
            return await _context.ProfileData.Where(e => e.Id == id).ToListAsync(); //AcceptedAtAction("GetProfile", fck);
        }
        */
        /*
        [HttpGet("{name}")]
        [Authorize]
        public async Task<ActionResult<ProfileData>> GetUserProfile(string name)
        {
            //var x = await _context.ProfileData.Where(e => e.UserName == name).Select(e => e.Id).ToListAsync();
            //return await _context.ProfileData.Where(e => e.UserName == name).ToListAsync();
            return await _context.ProfileData.Where(e => e.UserName == name).FirstAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProfileDto>> PostProfile(ProfileDto profileDto)
        {
            var profile = new ProfileData
            {
                UserName = profileDto.UserName,
                StageName = profileDto.StageName,
                Country = profileDto.Country
            };
            _context.ProfileData.Add(profile);
            await _context.SaveChangesAsync();
            return profileDto;
        }
        
        [HttpPut("{id}")]
        [Authorize]
        //        public async Task<ActionResult> PutProfile(int id,ProfileData profile)
        public async Task<ActionResult> PutProfile(int id, ProfileDto profileDto)

        {   
            var profile = new ProfileData
            {
                UserName = profileDto.UserName,
                StageName = profileDto.StageName,
                Country = profileDto.Country
            };
            profile.Id = id;
            _context.Entry(profile).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return AcceptedAtAction("PutProfile", id, profile);
        }
       */

    }
}