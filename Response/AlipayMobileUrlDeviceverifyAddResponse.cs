using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMobileUrlDeviceverifyAddResponse.
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddResponse : AopResponse
    {
        /// <summary>
        /// 返回业务操作是否成功
        /// </summary>
        [XmlElement("response")]
        public bool Response { get; set; }
    }
}
