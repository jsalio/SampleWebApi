using ClassLibrary1;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        readonly NotificationLog _notificationLog = new NotificationLog();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentNotification"></param>
        [HttpPost]
        [Route("api/values/incoming-document-message")]
        public void UnconmingMessage([FromBody] DocumentNotification documentNotification)
        {
            
            _notificationLog.WriteDocumentNotification(Newtonsoft.Json.JsonConvert.SerializeObject(documentNotification));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchNotification"></param>
        [HttpPost]
        [Route("api/values/incoming-batch-notification")]
        public void UncomingBatchNotification([FromBody] BatchNotification batchNotification)
        {

            _notificationLog.WriteBatchNotification(Newtonsoft.Json.JsonConvert.SerializeObject(batchNotification));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchNotification"></param>
        [HttpPost]
        [Route("api/values/incoming-batch-index-notification")]
        public void IncommingBatchWhenIndex([FromBody] BatchNotification batchNotification)
        {

            _notificationLog.WriteBatchIndexNotification(Newtonsoft.Json.JsonConvert.SerializeObject(batchNotification));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentNotification"></param>
        [HttpPost]
        [Route("api/values/incoming-document-index-message")]
        public void UnconmingDocumentIndexMessage([FromBody] DocumentNotification documentNotification)
        {
            _notificationLog.WriteDocumentIndexNotification(Newtonsoft.Json.JsonConvert.SerializeObject(documentNotification));
        }
    }
}
