using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class DocumentNotification
    {
        /// <summary>
        /// A Document status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// A document type id
        /// </summary>
        public int DocumentType { get; set; }
        /// <summary>
        /// A notification <see cref="DateTime"/>
        /// </summary>
        public DateTime DateNotification
        {
            get;
            set;
        }
        /// <summary>
        /// A document id
        /// </summary>
        public int DocumentId { get; set; }
        /// <summary>
        /// A <see cref="IndexNotification"/> 
        /// </summary>
        public List<IndexNotification> KeyWords { get; set; }
    }
}
