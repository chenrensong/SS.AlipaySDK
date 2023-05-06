using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherpackageBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页参数，需要查询的页码，起始页是1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页参数，每页记录数，最大不可超过30
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 券包购买开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("voucher_package_purchase_start_time")]
        public string VoucherPackagePurchaseStartTime { get; set; }

        /// <summary>
        /// 券包状态：不指定可查全部状态，指定时只支持查单个状态 枚举值： CREATED：已创建, ENABLE：已发布（包含过期）, PAUSED：已暂停, DISABLE：已停止;
        /// </summary>
        [XmlElement("voucher_package_status")]
        public string VoucherPackageStatus { get; set; }
    }
}
