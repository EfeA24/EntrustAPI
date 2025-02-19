using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int ItemQuantity { get; set; }
    }
}
