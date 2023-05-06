using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecQueryResponse.
    /// </summary>
    public class KoubeiCateringPosSpecQueryResponse : AopResponse
    {
        /// <summary>
        /// 规格列表
        /// </summary>
        [XmlArray("specs")]
        [XmlArrayItem("spec_entity")]
        public List<SpecEntity> Specs { get; set; }
    }
}
