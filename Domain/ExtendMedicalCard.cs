using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ExtendMedicalCard Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendMedicalCard : AopObject
    {
        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构名称
        /// </summary>
        [XmlElement("card_org_name")]
        public string CardOrgName { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构编号
        /// </summary>
        [XmlElement("card_org_no")]
        public string CardOrgNo { get; set; }

        /// <summary>
        /// 城市编码(格式为：行政区域代码)  多个地市逗号分隔
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// Json格式的业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  签约成功时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 000102020011
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  医保卡号，敏感信息脱敏输出
        /// </summary>
        [XmlElement("medical_card_no")]
        public string MedicalCardNo { get; set; }

        /// <summary>
        /// 市医保：CITY_INS  省医保:PROVINCE_INS  县医保:COUNTY_INS
        /// </summary>
        [XmlElement("medical_card_type")]
        public string MedicalCardType { get; set; }

        /// <summary>
        /// 医保卡持卡人证件号码(脱敏)
        /// </summary>
        [XmlElement("out_user_card_no")]
        public string OutUserCardNo { get; set; }

        /// <summary>
        /// 医保卡持有人姓名( 脱敏)
        /// </summary>
        [XmlElement("out_user_name")]
        public string OutUserName { get; set; }

        /// <summary>
        /// 绑定状态  已激活:signed  已解绑:unsigned
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
