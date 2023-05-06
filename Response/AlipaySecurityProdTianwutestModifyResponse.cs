using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdTianwutestModifyResponse.
    /// </summary>
    public class AlipaySecurityProdTianwutestModifyResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("ceshi")]
        public string Ceshi { get; set; }
    }
}
