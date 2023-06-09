using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditLoanDeductApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanDeductApplyModel : AopObject
    {
        /// <summary>
        /// 贷款申请单号，客户申请贷款时借呗系统生成的全局唯一业务流水号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 备注信息，机构填写的发起强扣申请的原因，要求尽量详细
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人名称，机构操作发起强扣人员姓名，用于信息追溯
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部请求幂等流水号，请求的幂等字段，申请用户贷款强扣时由机构生成的唯一请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
