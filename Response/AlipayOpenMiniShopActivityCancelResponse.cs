using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCancelResponse.
    /// </summary>
    public class AlipayOpenMiniShopActivityCancelResponse : AopResponse
    {
        /// <summary>
        /// 返回传入的业务处理流水号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
