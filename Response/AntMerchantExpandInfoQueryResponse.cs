using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandInfoQueryResponse.
    /// </summary>
    public class AntMerchantExpandInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户基础信息返回接口
        /// </summary>
        [XmlElement("merchant_query_result")]
        public MerchantQueryResult MerchantQueryResult { get; set; }
    }
}
