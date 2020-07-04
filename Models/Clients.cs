using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SalesTrustAccount.Models
{
    public class Clients
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string MobilePhone { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneHome { get; set; }
        public string BankName { get; set; }
        public string BankBSB { get; set; }
        public string BankAccNumber { get; set; }
        public string Notes { get; set; }

    }
}
