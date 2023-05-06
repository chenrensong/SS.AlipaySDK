using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserSportshealthAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthAccountQueryModel : AopObject
    {
        /// <summary>
        /// 外部渠道
        /// </summary>
        [XmlElement("out_biz_channel")]
        public string OutBizChannel { get; set; }
    }
}
