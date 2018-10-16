﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogDemo.Domain.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int AuthorId { get; set; }
        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Required]
        [RegularExpression("^[a-z0-9-]+$", ErrorMessage = "Slug format not valid.")]
        [StringLength(160)]
        public string Slug { get; set; }

        [Required]
        [StringLength(450)]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }


        public string Categories { get; set; }

        [StringLength(255)]
        public string Cover { get; set; }

        public int PostViews { get; set; }
        public double Rating { get; set; }

        public bool IsFeatured { get; set; }

        public DateTime Published { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
