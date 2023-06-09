using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffCancelstockoutorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffCancelstockoutorderQueryModel : AopObject
    {
        /// <summary>
        /// 扩展字段，备用
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 分页查询当前查询页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询每页数据量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
