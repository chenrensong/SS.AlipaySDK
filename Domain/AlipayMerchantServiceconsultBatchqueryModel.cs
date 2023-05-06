using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMerchantServiceconsultBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantServiceconsultBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询开始时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间30天前。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前页，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认10条，最多支持20条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 状态 商家处理中： MERCHANT_PROCESSING 商家已回复： MERCHANT_REPLIED 已撤销： CANCELLED 系统关闭： CLOSED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用信息
        /// </summary>
        [XmlArray("target_infos")]
        [XmlArrayItem("target_info")]
        public List<TargetInfo> TargetInfos { get; set; }
    }
}
