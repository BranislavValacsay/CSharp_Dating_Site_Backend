using System.ComponentModel.DataAnnotations.Schema;

namespace Trydem.Models
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        //fully defining relationship betwee AppUser and Photos classes
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

    }
}