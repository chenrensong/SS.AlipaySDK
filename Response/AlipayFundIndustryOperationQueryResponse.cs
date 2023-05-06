using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundIndustryOperationQueryResponse.
    /// </summary>
    public class AlipayFundIndustryOperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的流水信息
        /// </summary>
        [XmlElement("operation")]
        public FundOperationDTO Operation { get; set; }
    }
}
