using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiGoodsCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 来源识别标识码
        /// </summary>
        [XmlElement("biz_src")]
        public string BizSrc { get; set; }
    }
}
