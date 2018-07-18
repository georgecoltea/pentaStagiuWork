using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public string Message { get; set; }
        public MessageType PostType { get; set; }
        public bool IsSticky { get; set; }
        public int Priority { get; set; }
    }

    public enum MessageType
    {
        Text,
        Photo
    }
}