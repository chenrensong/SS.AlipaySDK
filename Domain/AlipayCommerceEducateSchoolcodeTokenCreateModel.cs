using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcodeTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolcodeTokenCreateModel : AopObject
    {
        /// <summary>
        /// 对应证件类型的证件号，用于生成token，学校提供
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 学校国标码，用于生成token，学校提供
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 废弃、请勿使用！！！ 对应证件类型的证件号，用于生成token，学校提供
        /// </summary>
        [XmlElement("student_cert_no")]
        public long StudentCertNo { get; set; }

        /// <summary>
        /// 学生证件类型，用于生成token，枚举值: {"1": "居民身份证", "2": "军官证", "3": "士兵证", "4": "文职干部证", "5": "部队离退休证", "6": "香港特区护照/身份证明", "7": "澳门特区护照/身份证明", "8": "台湾居民来往大陆通行证", "9": "境外永久居住证", "A": "护照", "B": "户口簿", "Z": "其他"} ，学校提供
        /// </summary>
        [XmlElement("student_cert_type")]
        public string StudentCertType { get; set; }

        /// <summary>
        /// 学生名称，用于生成token，学校提供
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }
    }
}
