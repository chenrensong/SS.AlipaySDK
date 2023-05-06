using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceConsumIndexQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceConsumIndexQueryResponse : AopResponse
    {
        /// <summary>
        /// 指数结果详情
        /// </summary>
        [XmlArray("index_detail")]
        [XmlArrayItem("index_detail")]
        public List<IndexDetail> IndexDetail { get; set; }
    }
}
