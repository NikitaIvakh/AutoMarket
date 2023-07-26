using System.ComponentModel.DataAnnotations;

namespace AutoMarket.Presentation.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Input name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The length of the name should be no more than 20 characters")]
        public string Name { get; set; }

        [Display(Name = "Input surname")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The length of the surname should be no more than 20 characters")]
        public string SurName { get; set; }

        [Display(Name = "Input address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The length of the address should not exceed 50 characters")]
        public string Address { get; set; }

        [Display(Name = "Input phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The length of the phone should not exceed 20 characters")]
        public string Phone { get; set; }

        [Display(Name = "Input email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The length of the email should be no more than 20 characters")]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}