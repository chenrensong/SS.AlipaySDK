using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// InterTradetContractOpenApiStartResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradetContractOpenApiStartResult : AopObject
    {
        /// <summary>
        /// 合约审批地址
        /// </summary>
        [XmlArray("contract_workflow_urls")]
        [XmlArrayItem("contract_workflow_url_result")]
        public List<ContractWorkflowUrlResult> ContractWorkflowUrls { get; set; }
    }
}
