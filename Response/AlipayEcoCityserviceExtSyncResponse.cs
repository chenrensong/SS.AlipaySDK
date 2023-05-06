using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoCityserviceExtSyncResponse.
    /// </summary>
    public class AlipayEcoCityserviceExtSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("result")]
        public SyncDataResult Result { get; set; }
    }
}
