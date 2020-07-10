using System;
using System.ComponentModel.DataAnnotations;

namespace libraryapi.Models
{
    public class Book
    {
        public Book(string title, string author, string description, int inStock, int pageCount, string genre, bool availability)
        {

            Title = title;
            Author = author;
            Description = description;
            InStock = inStock;
            PageCount = pageCount;
            Genre = genre;
            Id = Guid.NewGuid().ToString();
            Availability = availability;

        }
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int InStock { get; set; }
        public int PageCount { get; set; }

        public string Genre { get; set; }

        public bool Availability { get; set; }

        public Book()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}