using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderUnbindResponse.
    /// </summary>
    public class AlipayCommerceEcServiceOrderUnbindResponse : AopResponse
    {
        /// <summary>
        /// 在需要解约的情况下，返回取消服务选择需要解约的地址
        /// </summary>
        [XmlElement("cancel_contract_url")]
        public string CancelContractUrl { get; set; }
    }
}
