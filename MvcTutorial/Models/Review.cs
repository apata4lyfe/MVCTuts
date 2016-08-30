using System.ComponentModel.DataAnnotations;

namespace MvcTutorial.Models
{
    public class Review
    {
        public int Reviewid { get; set; }

        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }


        public string Contents { get; set; }

        [Required()]
        [Display(Name ="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}