namespace CSharp6AndRefactoring
{
    using System.Collections.Generic;
    using System.Linq;

    public class Sample2Version1
    {
        public string GetPrettyName(string title)
		{
			if(title!=null)
			{
				if(title.Contains(" "))
				{
					string result="";
					var items=title.Split(' ');
					foreach(var word in items)
					{
                        if(word.Length>0)
                        {
                            result+=word.Substring(0,1).ToUpper()
						              +word.Substring(1).ToLower()
						              + " ";
                        }
					}
					return result.Trim();
				}
			}
			return "";
		}
    }
    
    public class Sample2Version2
    {
        public string GetPrettyName(string title)
		=> (string.Join(" ",
				title?.Split(' ')
				.Where(word => word.Length>0)
				.Select( word=>
					word?.Substring(0,1).ToUpper()
					+word?.Substring(1).ToLower())
                ?? new string[]{}
			));
    }
    
    public class Sample2Version3
    {
        public string PrettifyWord (string word) 
        => word?.Substring(0,1).ToUpper()
          +word?.Substring(1).ToLower();

        public IEnumerable<string> GetPrettifiedWordsIfNotNull(string phrase)
        => 	phrase?
              .Split(' ')
              .Where(word=>word.Length>0)
              .Select(PrettifyWord)
            ?? new string[]{};
                
        public string GetPrettyName(string title)
        => string.Join(" ",GetPrettifiedWordsIfNotNull(title));
                    
    }
}