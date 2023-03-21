using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LABA333.Models;
using LABA333.Repository;


namespace LABA333.Controllers
{
    public class PostController : Controller
    {
        [HttpPut]
        public Post Create(Post post)
        {
            Storage.PostStorage.Create(post);
            return Storage.PostStorage.Read(post.Id_post);
        }

        [HttpGet]
        public Post Read(int postId)
        {
            return Storage.PostStorage.Read(postId);
        }

        [HttpPatch]
        public Post Update(int postId, Post newpost)
        {
            return Storage.PostStorage.Update(postId, newpost);
        }

        [HttpDelete]
        public bool Delete(int postId)
        {
            return Storage.PostStorage.Delete(postId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}