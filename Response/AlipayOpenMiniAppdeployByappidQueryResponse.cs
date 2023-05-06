using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployByappidQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序发布信息
        /// </summary>
        [XmlArray("deploys")]
        [XmlArrayItem("mini_app_deploy_response")]
        public List<MiniAppDeployResponse> Deploys { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
