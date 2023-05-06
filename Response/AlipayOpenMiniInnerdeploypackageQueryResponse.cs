using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerdeploypackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerdeploypackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序部署包模型
        /// </summary>
        [XmlElement("app_deploy_package")]
        public OpenAppDeployPackageVO AppDeployPackage { get; set; }
    }
}
