using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseBcGroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝群详情
        /// </summary>
        [XmlElement("group_detail")]
        public GroupDetail GroupDetail { get; set; }
    }
}
