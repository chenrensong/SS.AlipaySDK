using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsAutoServiceCouponVerifyResponse.
    /// </summary>
    public class AlipayInsAutoServiceCouponVerifyResponse : AopResponse
    {
        /// <summary>
        /// 核销同步结果，返回成功或失败。
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
