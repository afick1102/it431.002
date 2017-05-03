using IT431Site.DAL;
using IT431Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace IT431Site.Controllers.API
{
    public class PostsController : ApiController
    {
        private SiteDataContext1 db = new SiteDataContext1();


        // GET: api/Participants
        public IQueryable<Post> GetPosts()
        {
            return db.Posts;
        }

        // POST: api/Posts
        [ResponseType(typeof(Post))]
        public IHttpActionResult Post(Post post)
        {
            post.Author = "John Smith";
            post.Date = DateTime.Now;
            db.Posts.Add(post);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = post.Id }, post);
        }
    }
}
