using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeQueryResponse : AopResponse
    {
        /// <summary>
        /// 做法模型
        /// </summary>
        [XmlArray("practice_entity_list")]
        [XmlArrayItem("practice_entity")]
        public List<PracticeEntity> PracticeEntityList { get; set; }
    }
}
