using System;

namespace Fetch
{
    /// <summary>
    /// Holds a single reservation that will be fulfilled in the future.
    /// </summary>
    public class Parameter
    {
        // type of object reserved
        public Type type;

        // identifier for the reservation
        public object reference;

        // true if this parameter has been assigned
        public bool assigned;
    }
}
