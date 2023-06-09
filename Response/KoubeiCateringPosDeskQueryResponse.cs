using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDeskQueryResponse : AopResponse
    {
        /// <summary>
        /// 餐台信息
        /// </summary>
        [XmlArray("pos_desk_list")]
        [XmlArrayItem("desk_entity")]
        public List<DeskEntity> PosDeskList { get; set; }
    }
}
