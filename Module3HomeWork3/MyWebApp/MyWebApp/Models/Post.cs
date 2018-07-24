using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Post
    { 
    
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TimeOfPosting { get; set; }

        public string Message { get; set; }
        public MessageType PostType { get; set; }
        public bool IsSticky { get; set; }
        public Priority Priority { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }

    public enum MessageType
    {
        Text,
        Photo
    }

    public enum Priority
    {
        Urgent,
        Important,
        ReadASAP,
        NotImportant
    }
}