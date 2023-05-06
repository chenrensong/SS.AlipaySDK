using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAppinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 应用信息列表
        /// </summary>
        [XmlArray("app_basic_info_response_list")]
        [XmlArrayItem("app_basic_info_response")]
        public List<AppBasicInfoResponse> AppBasicInfoResponseList { get; set; }
    }
}
