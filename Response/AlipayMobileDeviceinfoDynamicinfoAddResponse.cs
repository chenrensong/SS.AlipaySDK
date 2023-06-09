using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoDynamicinfoAddResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AopResponse
    {
        /// <summary>
        /// 同步处理结果
        /// </summary>
        [XmlElement("operateresult")]
        public bool Operateresult { get; set; }
    }
}
