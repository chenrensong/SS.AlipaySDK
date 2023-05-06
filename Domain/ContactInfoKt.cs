using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ContactInfoKt Data Structure.
    /// </summary>
    [Serializable]
    public class ContactInfoKt : AopObject
    {
        /// <summary>
        /// 联系人电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 联系人身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 学校联系人业务标识枚举，表示联系人的职责。异议处理接口人:02; 关键联系人:06;数据反馈接口人:11;服务联动接口人:08
        /// </summary>
        [XmlArray("tag")]
        [XmlArrayItem("string")]
        public List<string> Tag { get; set; }

        /// <summary>
        /// 联系人类型，取值范围：LEGAL_PERSON：法人；CONTROLLER：实际控制人；AGENT：代理人；OTHER：其他
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
