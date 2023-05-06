using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceDetailQueryResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 业财受理详情查询结果
        /// </summary>
        [XmlElement("result")]
        public GFAOpenAPIDetailQueryResult Result { get; set; }
    }
}
