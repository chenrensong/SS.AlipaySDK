using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序版本信息
        /// </summary>
        [XmlArray("version_info_list")]
        [XmlArrayItem("mini_app_version_info")]
        public List<MiniAppVersionInfo> VersionInfoList { get; set; }
    }
}
