using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbyQueryModel : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
