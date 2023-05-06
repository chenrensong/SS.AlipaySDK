using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantQipanBehaviorQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanBehaviorQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群行为分析数据
        /// </summary>
        [XmlArray("multi_data_list")]
        [XmlArrayItem("multi_data_open_result")]
        public List<MultiDataOpenResult> MultiDataList { get; set; }
    }
}
