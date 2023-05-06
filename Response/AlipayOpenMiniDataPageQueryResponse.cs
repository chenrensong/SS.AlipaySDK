using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniDataPageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDataPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 页面访问数据结果
        /// </summary>
        [XmlArray("page_visit_data_list_response")]
        [XmlArrayItem("page_visit_data_response")]
        public List<PageVisitDataResponse> PageVisitDataListResponse { get; set; }
    }
}
