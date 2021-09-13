using System;
namespace ShopiWorker.Model
{
    public class Category
    {
       
        public string id { get; set; }
        public string name { get; set; }
        public string parentCategoryId { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        
    }
}
