using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEcoActivityRecycleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoActivityRecycleQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
