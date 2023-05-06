using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceSchemaQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务schema版本
        /// </summary>
        [XmlElement("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务schema
        /// </summary>
        [XmlElement("schema_xml")]
        public string SchemaXml { get; set; }
    }
}
