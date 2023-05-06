using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserCardLevelQueryResponse.
    /// </summary>
    public class AlipayUserCardLevelQueryResponse : AopResponse
    {
        /// <summary>
        /// card_level_configs：卡等级配置
        /// </summary>
        [XmlArray("card_level_configs")]
        [XmlArrayItem("card_level_config_d_t_o")]
        public List<CardLevelConfigDTO> CardLevelConfigs { get; set; }
    }
}
