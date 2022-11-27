using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BanjoStorefront.DATA.EF.Metadata
{
    public class CustomerMetadata
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public string CustomerDetails { get; set; }

    }

    public class ProductMetadata
    {
        [Required]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]      
        public decimal Price { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Brand")]
        public string Brand { get; set; }

        public bool InStock { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }
    }

    public class SuppliersMetadata
    {
        [Required]
        public int SupplierID { get; set; }

        [Required]
        public string SupplierDetails { get; set; }

    }


}

