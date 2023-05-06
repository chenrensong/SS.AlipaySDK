using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniReleaststBatchqueryModel : AopObject
    {
        /// <summary>
        /// 20
        /// </summary>
        [XmlElement("canshu")]
        public string Canshu { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("fuza")]
        public GavintestNewLeveaOne Fuza { get; set; }
    }
}
