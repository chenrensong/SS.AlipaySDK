using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransPayeeBindQueryResponse.
    /// </summary>
    public class AlipayFundTransPayeeBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否绑定收款账号。true：已绑定；false：未绑定
        /// </summary>
        [XmlElement("bind")]
        public string Bind { get; set; }
    }
}
