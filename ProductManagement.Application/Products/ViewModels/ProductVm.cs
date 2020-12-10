using ProductManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.ViewModels
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
