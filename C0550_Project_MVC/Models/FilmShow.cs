using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Razor.Models
{
    public class FilmShow
    {
        [Key]
        public int FilmShowID { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
    }
}
