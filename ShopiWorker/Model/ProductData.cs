using System.Collections.Generic;
using ShopiWorker.Model;

namespace shopiApi.Model
{
    
    public class ProductData
    {

        public string id { get; set; } 
        public int cloudId { get; set; } 
        public string itemId { get; set; } 
        public string productName { get; set; } 
        public decimal listPrice { get; set; } 
        public string headline { get; set; } 
        public bool inStock { get; set; }
        public List< Variant> variants { get; set; } 
        public List<Filter> filters { get; set; } 
        public Picture picture { get; set; } 
        public List<Pictures> pictures { get; set; } 
        public string productDetailUrl { get; set; } 
        public List<Review> reviews { get; set; }
        public string quantity { get; set; }
        public Category category { get; set; }
        public string sku { get; set; }
        public string ProductUrl { get; set; }
        
    }
}