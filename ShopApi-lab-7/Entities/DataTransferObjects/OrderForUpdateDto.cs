﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class OrderForUpdateDto : OrderForManipulationDto
    {
        [Required(ErrorMessage = "Order name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Cost is 30 characters.")]
        public double Cost { get; set; }

        [Range(18, int.MaxValue, ErrorMessage = "Goods is required and it can't be lower than 18")]
        public string Goods { get; set; }

        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Date is 20 characters.")]
        public long Date { get; set; }

    }
}
