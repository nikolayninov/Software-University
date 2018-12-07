namespace CustomRandomList
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;
    public class RandomList : List<string>
    {
        public Random randomGenerator { get; set; }
        public RandomList()
        {
            randomGenerator = new Random();
        }

        public string RandomString()
        {
            if (Count < 1)
            {
                return "No questions available";
            }
            var index = randomGenerator.Next(0, Count);
            string result = this [index];
            RemoveAt(index);
            return result;
        }
    }
}