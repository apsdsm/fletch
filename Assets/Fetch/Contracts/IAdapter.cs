namespace Fetch {
    
    /// <summary>
    /// An adapter is a link between a game obejct and some other non-monobehaviour
    /// object. By implementing the Bridge interface, the IOC knows to route requests
    /// for the non-monobehaviour class through the monobehaviour wrapper.
    /// </summary>
    /// <typeparam name="T">The type of object linked to by the adapter</typeparam>
    public interface IAdapter<T> {

        /// <summary>
        /// Must provide a getter to the controller object.
        /// </summary>
        T controller { get; }
    }
}
