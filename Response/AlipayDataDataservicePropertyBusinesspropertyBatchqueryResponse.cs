using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 业务画像标签元信息列表
        /// </summary>
        [XmlArray("business_propertys")]
        [XmlArrayItem("business_property_d_t_o")]
        public List<BusinessPropertyDTO> BusinessPropertys { get; set; }
    }
}
