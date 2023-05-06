using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSceneprodFinanceConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodFinanceConsultResponse : AopResponse
    {
        /// <summary>
        /// 分行ipRoleid
        /// </summary>
        [XmlElement("finance_branch_ip_role_id")]
        public string FinanceBranchIpRoleId { get; set; }

        /// <summary>
        /// 分行名称
        /// </summary>
        [XmlElement("finance_branch_name")]
        public string FinanceBranchName { get; set; }

        /// <summary>
        /// 资方编码
        /// </summary>
        [XmlElement("finance_inst_code")]
        public string FinanceInstCode { get; set; }

        /// <summary>
        /// 资方名称
        /// </summary>
        [XmlElement("finance_inst_name")]
        public string FinanceInstName { get; set; }

        /// <summary>
        /// 响应请求场景描述
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 资方申请编号，用于在mybank.credit.sceneprod.loan.apply 接口申请贷款时，填充finance_inst_iprole_id 字段的值
        /// </summary>
        [XmlElement("route_no")]
        public string RouteNo { get; set; }

        /// <summary>
        /// 路由结果  SUCCESS:成功，同时route_no会有值  PROCESSING：咨询中，等待资方接口返回结果  FAIL: 匹配到的资方都拒绝准入
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}