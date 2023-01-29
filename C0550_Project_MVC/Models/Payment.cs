using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Razor.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [StringLength(81), Required]
        public string CardName { get; set; }

        [Required]
        public int SecurityNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        

    }
}
