using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAuthAppCancelResponse.
    /// </summary>
    public class AlipayOpenAuthAppCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消授权结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
