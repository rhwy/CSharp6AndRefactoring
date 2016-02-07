namespace CSharp6AndRefactoring   
{
    using System;
    using static System.Console;

    public class Program
	{
		public static void Main(params string[] args)
		{
            switch (args[0])
            {
                case "1":
                    WriteLine("Sample 1:");
                    Sample1();
                    break;
                case "2":
                    WriteLine("Sample 2:");
                    Sample2();
                    break;
                case "3":
                    WriteLine("Sample 3:");
                    Sample3();
                    break;
                case "4":
                    WriteLine("Sample 4:");
                    Sample4();
                    break;
                default:
                    WriteLine("nothing to show :-)");
                    break;
            }
	    }
        
        public static void Sample1()
        {
            WriteLine("Facility vs Simplicity");
            var someNumbers = new []{3,6,8,12,13,15,18,21,25,27,30,35};
            
            WriteLine("3 first Odd numbers / by 3 but not by 5");
            new SimplicityNotFacility().Sample1Normal(someNumbers);	
            
            WriteLine("3 first Odd numbers / by 3 but not by 5");
            new SimplicityNotFacility().Sample1Refactored(someNumbers);
		}
        
        public static void Sample2()
        {
            string title = "demo CSHarp 6 for CLEANer code";
            //test it with : title=null;title=" ";title="a bB  c";
            WriteLine($"[{new Sample2Version1().GetPrettyName(title)}]");
            WriteLine($"[{new Sample2Version2().GetPrettyName(title)}]");
            WriteLine($"[{new Sample2Version3().GetPrettyName(title)}]");
            
        }
        
        public static void Sample3()
        {
           
            var v1=new Sample3Version1();
            
            v1.onNewMessage += 
                (message)=>Console.WriteLine(message);
            v1.SaySomething("hello1");
            
            var v2=new Sample3Version2();
            
            v2.onNewMessage += WriteLine;
            v2.SaySomething("hello2");
            
        }
        
        
        public static void Sample4()
        {
            WriteLine("V1 : ");
            var v1 = new Sample4Version1();
            v1.Prices.Add(1.2);
            v1.Prices.Add(5.3);
            WriteLine(v1.MessageWithTotal);
            
            WriteLine("V2 : ");
            var v2 = new Sample4Version2();
            v2.Prices.Add(1.2);
            v2.Prices.Add(5.3);
            WriteLine(v2.MessageWithTotal);
            
            
        }
	}
	
    
}