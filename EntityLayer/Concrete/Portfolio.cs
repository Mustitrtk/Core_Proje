﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; } 
        public string Title { get; set; } 
        public string ImageUrl { get; set; } 
        public string PathUrl { get; set; } 
        public string ImageUrl2 { get; set; }
        public string Platform {  get; set; }
        public string Price { get; set; }
        public Boolean Status { get; set; } = true;
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public int Value { get; set; }
    }
}
