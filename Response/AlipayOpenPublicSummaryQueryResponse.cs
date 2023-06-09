using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicSummaryQueryResponse.
    /// </summary>
    public class AlipayOpenPublicSummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 生活号摘要信息列表
        /// </summary>
        [XmlArray("public_info_list")]
        [XmlArrayItem("summary_info")]
        public List<SummaryInfo> PublicInfoList { get; set; }
    }
}
