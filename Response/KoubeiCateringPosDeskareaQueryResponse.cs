using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaQueryResponse : AopResponse
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [XmlArray("pos_desk_area_list")]
        [XmlArrayItem("desk_area_entity")]
        public List<DeskAreaEntity> PosDeskAreaList { get; set; }
    }
}
