using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniPrivacySystemfieldQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPrivacySystemfieldQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序使用的系统定义的隐私字段
        /// </summary>
        [XmlArray("system_privacy_fields")]
        [XmlArrayItem("owned_system_privacy_field")]
        public List<OwnedSystemPrivacyField> SystemPrivacyFields { get; set; }
    }
}
