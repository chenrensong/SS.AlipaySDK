using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayWeiboEbppRechargeResponse.
    /// </summary>
    public class AlipayWeiboEbppRechargeResponse : AopResponse
    {
        /// <summary>
        /// 返回缴费页面
        /// </summary>
        [XmlElement("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
