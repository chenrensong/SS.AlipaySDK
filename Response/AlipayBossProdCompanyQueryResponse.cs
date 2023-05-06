using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdCompanyQueryResponse.
    /// </summary>
    public class AlipayBossProdCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 符合查询条件的公司信息
        /// </summary>
        [XmlArray("open_api_company_query_result")]
        [XmlArrayItem("company_detail")]
        public List<CompanyDetail> OpenApiCompanyQueryResult { get; set; }
    }
}
