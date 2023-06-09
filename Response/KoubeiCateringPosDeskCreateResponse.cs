using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateResponse.
    /// </summary>
    public class KoubeiCateringPosDeskCreateResponse : AopResponse
    {
        /// <summary>
        /// 桌位ID
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }
    }
}
