using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace task13.DTO
{
    public class ConfectioneryDTO
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Notes { get; set; }
    }
    public class AddOrderRequest
    {
        [Required]
        public DateTime DateAccepted { get; set; }
        [Required]
        [MaxLength(255)]
        public string Notes { get; set; }
        [Required]
        public List<ConfectioneryDTO> Confectionery { get; set; }
    }
}