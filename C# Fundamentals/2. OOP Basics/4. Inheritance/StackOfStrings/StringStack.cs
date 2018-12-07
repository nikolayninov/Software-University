namespace CustomStack
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class StackOfStrings : List<string>
    {
        public void Push(string element)
        {
            Add(element);
        }
        public string Pop()
        {
            string element = GetLastElement();
            this.RemoveAt(Count - 1);
            return element;
        }
        public string Peek()
        {
            return GetLastElement();
        }
        public bool IsEmpty()
        {
            return Count < 1;
        }
        private string GetLastElement()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return this.Last();
        }
    }
}