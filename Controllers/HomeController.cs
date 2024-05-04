using HackerNewsClone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HackerNewsClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var newsItems = GetSampleNewsItems();
            return View(newsItems);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Comments(int id)
        {
            var comments = FetchComments(id);
            return View(comments);
        }

        public IActionResult Profile(string username)
        {
            var user = FetchUserDetails(username);
            var posts = FetchUserPosts(username);
            var model = new UserProfileViewModel
            {
                User = user,
                Posts = posts
            };
            return View(model);
        }

        private List<NewsItem> GetSampleNewsItems()
        {
            return new List<NewsItem>
            {
                new NewsItem { Id = 1, Title = "Example News 1", Url = "https://example1.com", ByUser = "user1", Points = 100, PostedOn = DateTime.Now, CommentsCount = 5, VoteUrl = "vote?id=1&how=up&goto=news", Rank = 1, CommentsUrl = "item?id=1" }
            };
        }

        private List<Comment> FetchComments(int newsItemId)
        {
            return new List<Comment> { new Comment { Id = 1, Author = "user1", Text = "Interesting article!", PostedOn = DateTime.Now } };
        }

        private User FetchUserDetails(string username)
        {
            return new User { Username = username, Email = "user@example.com" };
        }

        private List<Post> FetchUserPosts(string username)
        {
            return new List<Post> { new Post { Id = 1, Title = "My first post", Content = "Content here" } };
        }
    }
}
