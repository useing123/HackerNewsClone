using System.ComponentModel.DataAnnotations;

namespace HackerNewsClone.Models
{
    public class CommentViewModel
    {
        [Required]
        public string Text { get; set; }

        public DateTime PostedOn { get; set; }

        [Required]
        public int NewsItemId { get; set; }
    }
}
