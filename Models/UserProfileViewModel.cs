using Microsoft.Extensions.Hosting;

namespace HackerNewsClone.Models {
    public class UserProfileViewModel
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}
