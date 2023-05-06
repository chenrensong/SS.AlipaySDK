using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossContractManagementQueryResponse.
    /// </summary>
    public class AlipayBossContractManagementQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement("result_set")]
        public ContractBatchInfoOpenApiResult ResultSet { get; set; }
    }
}
