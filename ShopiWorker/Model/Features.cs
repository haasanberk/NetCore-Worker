using System;
namespace ShopiWorker.Model
{
    public class Features
    {
       
            public int cloudId { get; set; }
        public string displayName { get; set; }
        public string value { get; set; }
        public string productId { get; set; }
        public string gtin { get; set; }
        public bool isProductChanger { get; set; }
        public bool isInStock { get; set; }
        public int order { get; set; }
        public Picture picture { get; set; }
        
    }
}
