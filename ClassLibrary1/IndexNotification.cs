using System;

namespace ClassLibrary1
{
    /// <summary>
    /// Represent a index model
    /// </summary>
    public sealed class IndexNotification
    {
        /// <summary>
        /// Represents where is the index data
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Represent a user name who creates the index
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Represent a date when it was created
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
