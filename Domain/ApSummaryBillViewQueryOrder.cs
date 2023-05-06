using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ApSummaryBillViewQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ApSummaryBillViewQueryOrder : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单结束月份
        /// </summary>
        [XmlElement("bill_end_month")]
        public string BillEndMonth { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [XmlArray("bill_nos")]
        [XmlArrayItem("string")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 账单起始月份
        /// </summary>
        [XmlElement("bill_start_month")]
        public string BillStartMonth { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlArray("bill_status_list")]
        [XmlArrayItem("string")]
        public List<string> BillStatusList { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlArray("biz_pd_code_list")]
        [XmlArrayItem("string")]
        public List<string> BizPdCodeList { get; set; }

        /// <summary>
        /// 智科业务是：外部合约号outContractId，前端给到参数“outContractId=XXXX”
        /// </summary>
        [XmlElement("business_dimension_1")]
        public string BusinessDimension1 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_2")]
        public string BusinessDimension2 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_3")]
        public string BusinessDimension3 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_4")]
        public string BusinessDimension4 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_5")]
        public string BusinessDimension5 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_6")]
        public string BusinessDimension6 { get; set; }

        /// <summary>
        /// 见分析维度1描述
        /// </summary>
        [XmlElement("business_dimension_7")]
        public string BusinessDimension7 { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 机构ou
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// 负账单查询标识
        /// </summary>
        [XmlElement("negative")]
        public string Negative { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlArray("sales_product_code_list")]
        [XmlArrayItem("string")]
        public List<string> SalesProductCodeList { get; set; }

        /// <summary>
        /// 结算对象pid
        /// </summary>
        [XmlElement("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }

        /// <summary>
        /// 结算对象mid
        /// </summary>
        [XmlElement("settle_merchant_id")]
        public string SettleMerchantId { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [XmlArray("settle_status_list")]
        [XmlArrayItem("string")]
        public List<string> SettleStatusList { get; set; }

        /// <summary>
        /// 结算时点类型
        /// </summary>
        [XmlArray("settle_time_type_list")]
        [XmlArrayItem("string")]
        public List<string> SettleTimeTypeList { get; set; }
    }
}
