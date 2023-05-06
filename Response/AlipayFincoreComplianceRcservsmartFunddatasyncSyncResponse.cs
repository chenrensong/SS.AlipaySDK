using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartFunddatasyncSyncResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservsmartFunddatasyncSyncResponse : AopResponse
    {
        /// <summary>
        /// 中欧基金数据同步返回体
        /// </summary>
        [XmlElement("rcsmart_common_response")]
        public RcSmartFundDataSyncResponse RcsmartCommonResponse { get; set; }
    }
}
