using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityDataSssModifyResponse.
    /// </summary>
    public class AlipaySecurityDataSssModifyResponse : AopResponse
    {
        /// <summary>
        /// 复杂类型
        /// </summary>
        [XmlElement("dff")]
        public ActivityGoods Dff { get; set; }

        /// <summary>
        /// 323
        /// </summary>
        [XmlElement("kjkj")]
        public string Kjkj { get; set; }
    }
}
