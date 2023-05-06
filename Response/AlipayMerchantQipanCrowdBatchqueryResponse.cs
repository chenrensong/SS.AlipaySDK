using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商家自定义人群列表
        /// </summary>
        [XmlElement("crowd_list")]
        public QipanMerchantCrowd CrowdList { get; set; }

        /// <summary>
        /// 返回查询结果的总条数
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
