using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitOrderSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
