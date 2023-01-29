using System.ComponentModel.DataAnnotations;

namespace C0550_Project_MVC.Models
{
    public class DatabaseConnection
    {
        public string? FilmID { get; set; }

        public string? Title { get; set; }

        public string? ReleaseDate { get; set; }

        public string? Duration { get; set; }

        public string? Price { get; set; }

        public string? Genre { get; set; }

        public string? Director { get; set; }


     
        public void BookFilm()
        {
                  
        }
    }
}
