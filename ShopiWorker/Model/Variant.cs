using System;
using System.Collections.Generic;

namespace ShopiWorker.Model
{
    public class Variant
    {
       
        public int cloudId { get; set; } 
        public string groupName { get; set; } 
        public string groupId { get; set; } 
        public List<Features> features { get; set; }
        public int order { get; set; }
        public Selected selected { get; set; }
        
    }
}
