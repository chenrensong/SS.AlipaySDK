using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序基本信息
        /// </summary>
        [XmlArray("base_info_list")]
        [XmlArrayItem("mini_app_base_info_query_response")]
        public List<MiniAppBaseInfoQueryResponse> BaseInfoList { get; set; }
    }
}
