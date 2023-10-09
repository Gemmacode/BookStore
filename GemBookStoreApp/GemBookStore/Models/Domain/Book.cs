﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GemBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string TotalPages { get; set; }
       
        [Required]
        public int AuthorId{ get; set; }
        public int PublisherId { get; set; }    
        public int GenreId { get; set; }

        [NotMapped]
        public string ? AuthorName { get; set; }
        [NotMapped]
        public string ? PublisherName { get; set; }
        [NotMapped]
        public string ? GenreName { get; set; }
        [NotMapped]
        public List<SelectListItem> ? AuthorList { get; set; }
        [NotMapped]
        public List<SelectListItem>? PublisherList { get; set; }
        [NotMapped]
        public List<SelectListItem>? GenreList { get; set; }

    }
}
