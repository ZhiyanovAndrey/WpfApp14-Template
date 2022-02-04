using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14_Template
{
    public enum ProductCategoryes
    {
        Бытовая_техника,
        Еда
    }

    public class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImagePath { get; set; }
        public ProductCategoryes ProductСategory { get; set; }


    }
}
