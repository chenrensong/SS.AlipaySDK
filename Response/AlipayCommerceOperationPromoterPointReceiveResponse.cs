using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterPointReceiveResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterPointReceiveResponse : AopResponse
    {
        /// <summary>
        /// 积分领取结果
        /// </summary>
        [XmlElement("point_receive_result")]
        public PointReceiveInfo PointReceiveResult { get; set; }
    }
}
