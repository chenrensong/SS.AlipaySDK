using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyShopTransferResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyShopTransferResponse : AopResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [XmlElement("result_data")]
        public string ResultData { get; set; }
    }
}
