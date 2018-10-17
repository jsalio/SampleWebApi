using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public sealed class BatchNotification
    {
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> id 
        /// </summary>
        public long BatchId { get; set; }
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> name 
        /// </summary>
        public string BatchName { get; set; }
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> current state
        /// </summary>
        public int BatchStatus { get; set; }
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> <see cref="Core.Model.Documents.Document"/> resume counter.
        /// </summary>
        public int BatchDocumentCounter { get; set; }
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> <see cref="Core.Model.Pages.Page"/> resume counter
        /// </summary>
        public int BatchPagesCounter { get; set; }
        /// <summary>
        /// The date of send notification
        /// </summary>
        public DateTime NotificationDate { get; set; }
        /// <summary>
        /// The <see cref="Core.Model.Batches.Batch"/> user creator
        /// </summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// The <see cref="ISet{T}"/> of <see cref="BatchExternalProperties"/> associate to this <see cref="Core.Model.Batches.Batch"/> 
        /// </summary>
        public ISet<ExternalProperties> ExternalProperties { get; set; }

    }
}
