using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]
        public string Producent { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for a 1-50")]
        public double Price { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for a 50-100")]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for a 100+")]
        public double Price100 { get; set; }
        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        [Display(Name ="Cover Type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverType CoverType { get; set; }


    }
}
