using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialQueryResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialQueryResponse : AopResponse
    {
        /// <summary>
        /// 配料对象
        /// </summary>
        [XmlArray("material_entity_list")]
        [XmlArrayItem("material_entity")]
        public List<MaterialEntity> MaterialEntityList { get; set; }
    }
}
