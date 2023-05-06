using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntLinkeAlcollectioncenterPreviewurlQueryResponse.
    /// </summary>
    public class AntLinkeAlcollectioncenterPreviewurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 预览链接
        /// </summary>
        [XmlArray("urls")]
        [XmlArrayItem("string")]
        public List<string> Urls { get; set; }
    }
}
