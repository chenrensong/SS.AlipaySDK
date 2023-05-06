using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPointBalanceGetResponse.
    /// </summary>
    public class AlipayPointBalanceGetResponse : AopResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }
    }
}
