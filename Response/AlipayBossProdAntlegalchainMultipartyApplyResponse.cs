using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainMultipartyApplyResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainMultipartyApplyResponse : AopResponse
    {
        /// <summary>
        /// 法链业务ID,用于查询上链状态
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }
    }
}
