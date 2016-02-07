namespace CSharp6AndRefactoring
{
    using System;
    using System.Linq;

    public class SimplicityNotFacility
    {
        public void Sample1Normal(int[] list)
        {
            int counter=0;
            for (int i = 0; i < list.Length; i++)
            {
                var current = list[i];
                if((current % 2 != 0) && (current % 3 == 0))
                {
                    if(current % 5 != 0)
                    {
                        Console.WriteLine(current);
                        counter++;
                    }
                }
                if(counter==3)
                    break;
            }
        }
        
        public void Sample1Refactored(int[] list)
        {
            
            Func<int,bool> IsOddAndDivisibleBy3 = 
                number => (number % 2 != 0) && (number % 3 == 0);
            
            Func<int,bool> IsNotDivisibleBy5 = 
                number => (number % 5 != 0) ;
            
            list
                .Where(IsOddAndDivisibleBy3)
                .Where(IsNotDivisibleBy5)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}