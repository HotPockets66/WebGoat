using System;
using System.ComponentModel.DataAnnotations;
using WebGoat.NET.Models.Products;
using WebGoat.NET.Moels.Products;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Product
    {
        [Required]
        [Display(Name = "Product Id:")]
        public ProductID ProductId { get; set; }

        [Display(Name = "Product Name:")]
        public ProductName ProductName { get; set; }

        [Required]
        public SupplierID SupplierId { get; set; }

        [Required]
        public CategoryID CategoryId { get; set; }

        [Display(Name = "Quantity per unit:")]
        public QuantityPerUnit QuantityPerUnit { get; set; }

        [Display(Name = "Unit price:")]
        public UnitPrice UnitPrice { get; set; }

        [Display(Name = "Units in stock:")]
        public UnitsInStock UnitsInStock { get; set; }

        [Display(Name = "Units on order:")]
        public UnitsOnOrder UnitsOnOrder { get; set; }

        [Display(Name = "Reorder level:")]
        public ReorderLevel ReorderLevel { get; set; }

        [Display(Name = "Discontinued")]
        public Discontinued Discontinued { get; set; }

        [Display(Name = "Category:")]
        public virtual Category Category { get; set; }

        [Display(Name = "Supplier:")]
        public virtual Supplier Supplier { get; set; }
    }
}
