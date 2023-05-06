using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryResponse.
    /// </summary>
    public class ZhimaCustomerContractDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 合约详情
        /// </summary>
        [XmlElement("contract_detail")]
        public ApiContractDetail ContractDetail { get; set; }
    }
}
