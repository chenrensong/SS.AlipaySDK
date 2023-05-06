using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNotaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 存证信息集合
        /// </summary>
        [XmlArray("notaries")]
        [XmlArrayItem("notary_result_d_t_o")]
        public List<NotaryResultDTO> Notaries { get; set; }
    }
}
