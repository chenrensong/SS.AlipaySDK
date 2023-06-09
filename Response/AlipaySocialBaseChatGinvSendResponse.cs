using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinvSendResponse : AopResponse
    {
        /// <summary>
        /// 结果提示信息
        /// </summary>
        [XmlElement("result_tip")]
        public string ResultTip { get; set; }
    }
}
