using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantQipanBoardQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanBoardQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群看板分析数据
        /// </summary>
        [XmlArray("index_list")]
        [XmlArrayItem("board_index")]
        public List<BoardIndex> IndexList { get; set; }
    }
}
