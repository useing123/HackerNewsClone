namespace HackerNewsClone.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; } // Ensure this is correct or change to ByUser if that's the intended name
        public string Text { get; set; }
        public DateTime PostedOn { get; set; }
    }
}
