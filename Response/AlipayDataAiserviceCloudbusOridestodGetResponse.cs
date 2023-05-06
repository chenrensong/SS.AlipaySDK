using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOridestodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOridestodGetResponse : AopResponse
    {
        /// <summary>
        /// 7OD  结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("ori_dest_od_item")]
        public List<OriDestOdItem> Result { get; set; }
    }
}
