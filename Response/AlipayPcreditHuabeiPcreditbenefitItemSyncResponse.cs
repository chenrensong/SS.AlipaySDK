using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitItemSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitItemSyncResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
