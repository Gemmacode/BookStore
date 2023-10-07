﻿using System.ComponentModel.DataAnnotations;

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

    }
}
