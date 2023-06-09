using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerSmileliveInitializeModel : AopObject
    {
        /// <summary>
        /// { "apdidToken": "设备指纹", "appName": "应用名称", "appVersion": "应用版本", "bioMetaInfo": "生物信息如2.3.0:3,-4" }
        /// </summary>
        [XmlElement("zimmetainfo")]
        public string Zimmetainfo { get; set; }
    }
}
