using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /*
     * Interface for the singleton container
     */
    public interface ISingletonContainer
    {
        int GetPopulation(string name);
    }
}
