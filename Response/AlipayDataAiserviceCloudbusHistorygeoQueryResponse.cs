using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusHistorygeoQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusHistorygeoQueryResponse : AopResponse
    {
        /// <summary>
        /// 地图问题geo hash码
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("string")]
        public List<string> Result { get; set; }
    }
}
