using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderDetailQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 部署单列表
        /// </summary>
        [XmlArray("deploy_order_list")]
        [XmlArrayItem("dx_deploy_order_info")]
        public List<DxDeployOrderInfo> DeployOrderList { get; set; }
    }
}
