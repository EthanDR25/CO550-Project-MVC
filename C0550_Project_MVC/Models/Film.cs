using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CO550_Project_MVC.Models
{
    public class Film
    {
        
        [Key]
        public int FilmID { get; set; }

        [StringLength(81), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }

        
        public static void Display()
        {
            Film film = new Film();
            
            Console.WriteLine(film.Title);
        }
        
    }

}
