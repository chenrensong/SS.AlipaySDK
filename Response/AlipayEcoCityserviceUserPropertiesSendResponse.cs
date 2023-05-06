using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoCityserviceUserPropertiesSendResponse.
    /// </summary>
    public class AlipayEcoCityserviceUserPropertiesSendResponse : AopResponse
    {
        /// <summary>
        /// 数据同步结果
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
