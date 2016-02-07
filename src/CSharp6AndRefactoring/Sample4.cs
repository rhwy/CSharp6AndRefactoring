namespace CSharp6AndRefactoring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sample4Version1
    {
        public List<double> Prices {get;private set;}
        public Sample4Version1()
        {
            Prices = new List<double>();
        }
        
        public string MessageWithTotal 
        {
            get{
                double total = Prices.Sum();
                int quantity = Prices.Count();
                return string.Format("Total : {0} ({1} products)",total,quantity);
            }
        }
    }
    
    public class Sample4Version2
    {
       public List<double> Prices {get;} = new List<double>();
       public string MessageWithTotal 
       => $"Total : {Prices.Sum()} ({Prices.Count()} products)";

    }
}