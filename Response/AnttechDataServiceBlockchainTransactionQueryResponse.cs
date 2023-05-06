using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainTransactionQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainTransactionQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易列表
        /// </summary>
        [XmlArray("transaction_list")]
        [XmlArrayItem("block_chain_transaction_api_d_o")]
        public List<BlockChainTransactionApiDO> TransactionList { get; set; }
    }
}
