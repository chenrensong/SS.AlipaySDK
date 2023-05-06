using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniDeploypackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeploypackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 包数据
        /// </summary>
        [XmlElement("pack_json")]
        public string PackJson { get; set; }
    }
}
