using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectBindConsultResponse.
    /// </summary>
    public class AntMerchantExpandIndirectBindConsultResponse : AopResponse
    {
        /// <summary>
        /// 解绑结果
        /// </summary>
        [XmlElement("handle_result")]
        public string HandleResult { get; set; }
    }
}
