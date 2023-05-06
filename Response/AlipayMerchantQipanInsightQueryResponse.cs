using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantQipanInsightQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanInsightQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群洞察分析数据
        /// </summary>
        [XmlArray("portrait_data_list")]
        [XmlArrayItem("portrait_data_v_o")]
        public List<PortraitDataVO> PortraitDataList { get; set; }
    }
}
