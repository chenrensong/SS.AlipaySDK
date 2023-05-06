using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// SiData Data Structure.
    /// </summary>
    [Serializable]
    public class SiData : AopObject
    {
        /// <summary>
        /// 唯一定位一次报文请求，由商户生成， 确保唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝处理完请求后，当前页面跳转到商户网站里指定页面的http路径，业务详情url。
        /// </summary>
        [XmlElement("service_return_url")]
        public string ServiceReturnUrl { get; set; }

        /// <summary>
        /// 目标人扩展信息,Json值
        /// </summary>
        [XmlElement("target_extend_params")]
        public string TargetExtendParams { get; set; }

        /// <summary>
        /// 目标人证件号
        /// </summary>
        [XmlElement("target_idcard")]
        public string TargetIdcard { get; set; }

        /// <summary>
        /// 目标人证件类型  证件类型  身份证：01   等
        /// </summary>
        [XmlElement("target_idcard_type")]
        public string TargetIdcardType { get; set; }

        /// <summary>
        /// 目标人手机号
        /// </summary>
        [XmlElement("target_mobile")]
        public string TargetMobile { get; set; }

        /// <summary>
        /// 支付宝用户ID,可以通过获取会员信息产品 获取支付宝用户ID  证件信息和userid同时存在以userid为主  target_user_id>target_idcard
        /// </summary>
        [XmlElement("target_open_id")]
        public string TargetOpenId { get; set; }

        /// <summary>
        /// 社会保障卡卡号
        /// </summary>
        [XmlElement("target_sicard_no")]
        public string TargetSicardNo { get; set; }

        /// <summary>
        /// 支付宝用户ID,可以通过获取会员信息产品 获取支付宝用户ID  证件信息和userid同时存在以userid为主  target_user_id>target_idcard
        /// </summary>
        [XmlElement("target_user_id")]
        public string TargetUserId { get; set; }

        /// <summary>
        /// 目标人证件姓名
        /// </summary>
        [XmlElement("target_user_name")]
        public string TargetUserName { get; set; }

        /// <summary>
        /// 模板数据
        /// </summary>
        [XmlElement("template_data")]
        public string TemplateData { get; set; }

        /// <summary>
        /// 业务类型对应的模板编号：联调时需要咨询技术
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 场景数据的类型的版本,默认1.0
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }
    }
}
