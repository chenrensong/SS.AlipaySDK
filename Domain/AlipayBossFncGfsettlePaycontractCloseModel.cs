using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettlePaycontractCloseModel : AopObject
    {
        /// <summary>
        /// 付款条款基础信息
        /// </summary>
        [XmlElement("paycontractbasedto")]
        public PayContractBaseDTO Paycontractbasedto { get; set; }
    }
}
