using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Model to represent AC and map Action enum to appropriate factory
     */
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        /*
         * instantiate dictionary an dynamically populate mapping each Action from the enumerables
         * to a newly created instance of the corresponding factory type
         */
        private AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>();

            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        /*
         * Initialize class with factory method to allow chaining syntax
         */
        public static AirConditioner InitializeFactories() => new AirConditioner();

        /*
         * Execute creation of appropriate manager using factory mapped to the action passed as param
         * with the temperature passed as param 
         */
        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
    }
}
