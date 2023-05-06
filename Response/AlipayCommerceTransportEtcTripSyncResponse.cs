using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcTripSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcTripSyncResponse : AopResponse
    {
        /// <summary>
        /// 是否同步成功，true/false
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
