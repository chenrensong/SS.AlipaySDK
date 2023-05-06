using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDataQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 汇总结果数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("data_detail")]
        public List<DataDetail> DataList { get; set; }
    }
}
