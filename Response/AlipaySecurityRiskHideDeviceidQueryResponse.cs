using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityRiskHideDeviceidQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHideDeviceidQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备指纹的apdid
        /// </summary>
        [XmlElement("deviceid")]
        public string Deviceid { get; set; }
    }
}
