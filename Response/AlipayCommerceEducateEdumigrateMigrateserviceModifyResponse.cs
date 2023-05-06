using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateEdumigrateMigrateserviceModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateEdumigrateMigrateserviceModifyResponse : AopResponse
    {
        /// <summary>
        /// data字段为迁移服务数据返回 JSON结构
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
