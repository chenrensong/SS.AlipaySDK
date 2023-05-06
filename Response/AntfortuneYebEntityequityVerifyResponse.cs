using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntfortuneYebEntityequityVerifyResponse.
    /// </summary>
    public class AntfortuneYebEntityequityVerifyResponse : AopResponse
    {
        /// <summary>
        /// web层返回对象封装
        /// </summary>
        [XmlElement("response")]
        public BaseWebResponse Response { get; set; }
    }
}
