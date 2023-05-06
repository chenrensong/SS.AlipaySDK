using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnoticeModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result_modify")]
        public string ResultModify { get; set; }
    }
}
