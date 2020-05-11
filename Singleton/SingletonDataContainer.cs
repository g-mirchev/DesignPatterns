using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    /*
     * Represents the data container for capitals and their populations as a dictionary
     */
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        /*
         * Read all the lines from the txt and populate the Dictionary iterating trough two lines at a time
         * the first line of each line pair being the capital, the second its population
         */
        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing singleton object");

            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i+=2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        /*
         * Load single instance of this static class the lazy way (whenever it is needed) making it thread safe
         */
        private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => instance.Value;

        /*
         * Implementing the interface, return the population mapped to the parsed capital
         */
        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
