using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class PostStorage
    {
        private Dictionary<int, Post> Posts { get; } = new Dictionary<int, Post>();

        public void Create(Post Post)
        {
            Posts.Add(Post.Id_post, Post);
        }

        public Post Read(int Id_post)
        {
            return Posts[Id_post];
        }

        public Post Update(int Id_post, Post newPost)
        {
            Posts[Id_post] = newPost;
            return Posts[Id_post];
        }

        public bool Delete(int Id_post)
        {
            return Posts.Remove(Id_post);
        }
    }
}