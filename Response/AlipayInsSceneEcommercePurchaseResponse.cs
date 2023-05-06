using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchaseResponse : AopResponse
    {
        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }
    }
}
