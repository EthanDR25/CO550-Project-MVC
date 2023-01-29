using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Razor.Models
{
    public class Ticket
    {
        
        
        [Key]
        public int TicketID { get; set; }

        [DataType(DataType.Date)]
        public DateTime TicketDate { get; set; }

        public decimal AmountPaid { get; set; }

    }
}
