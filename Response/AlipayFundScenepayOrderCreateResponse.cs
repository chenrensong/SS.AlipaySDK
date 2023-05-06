using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundScenepayOrderCreateResponse.
    /// </summary>
    public class AlipayFundScenepayOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 场景支付业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
