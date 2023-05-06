using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务poi信息列表
        /// </summary>
        [XmlElement("addresses")]
        public AddressDTO Addresses { get; set; }
    }
}
