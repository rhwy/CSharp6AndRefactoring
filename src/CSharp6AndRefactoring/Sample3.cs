namespace CSharp6AndRefactoring
{
    using System;

    public class Sample3Version1
    {
        public event Action<string> onNewMessage;
        public void SaySomething(string message)
        {
            if(onNewMessage != null)
            {
                onNewMessage(message);
            }
        }
    }
    
    public class Sample3Version2
    {
        public event Action<string> onNewMessage;
        public void SaySomething(string message)
        => onNewMessage?.Invoke(message);
    }
}