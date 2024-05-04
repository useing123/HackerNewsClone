using System.ComponentModel.DataAnnotations;

namespace HackerNewsClone.Models {
    public class NewsItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        public string ByUser { get; set; }

        public int Points { get; set; }

        public DateTime PostedOn { get; set; }

        public int CommentsCount { get; set; }

        public string VoteUrl { get; set; }

        public int Rank { get; set; }

        public string CommentsUrl { get; set; }
    }
}
