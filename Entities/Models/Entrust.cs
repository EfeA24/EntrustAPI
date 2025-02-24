﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Entrust
    {
        [Key]
        public int EntrustId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = null!;

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; } = null!;

        public DateTime EntrustDate { get; set; } = DateTime.Now;
    }
}