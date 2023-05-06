using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseFrastressQuerybusinessdomainQueryResponse.
    /// </summary>
    public class AlipayBossBaseFrastressQuerybusinessdomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回实体结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("risk_biz_domain")]
        public List<RiskBizDomain> Result { get; set; }
    }
}
