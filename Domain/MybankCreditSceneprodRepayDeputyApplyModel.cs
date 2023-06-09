using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MybankCreditSceneprodRepayDeputyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodRepayDeputyApplyModel : AopObject
    {
        /// <summary>
        /// 网商分配的申请单号
        /// </summary>
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 如果需要调整代客还款信息的时候，该项必填
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("scene_prod_deputy_payment_bill_detail")]
        public List<SceneProdDeputyPaymentBillDetail> BillList { get; set; }

        /// <summary>
        /// 网商分配的支用单号
        /// </summary>
        [XmlElement("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 操作类型：申请/修改/删除：  APPLY   ,  查询：QUERY
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
