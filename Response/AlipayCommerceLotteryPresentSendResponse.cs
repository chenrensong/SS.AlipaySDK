using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceLotteryPresentSendResponse.
    /// </summary>
    public class AlipayCommerceLotteryPresentSendResponse : AopResponse
    {
        /// <summary>
        /// 是否赠送成功
        /// </summary>
        [XmlElement("send_result")]
        public bool SendResult { get; set; }
    }
}
