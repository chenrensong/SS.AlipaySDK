using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 多端应用信息
        /// </summary>
        [XmlArray("app_base_info_list")]
        [XmlArrayItem("mini_app_base_info_query_response")]
        public List<MiniAppBaseInfoQueryResponse> AppBaseInfoList { get; set; }
    }
}
