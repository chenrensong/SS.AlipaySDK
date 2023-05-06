using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdDeviceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDeviceinfoQueryModel : AopObject
    {
        /// <summary>
        /// biz_name，用于标识接入方名称，注意新接入的业务该字段为必填字段，请联系owner分配
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// terminal_type，用于标识当前所属的终端类型，目前支持APP这种终端类型
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }

        /// <summary>
        /// tokenID，客户端对应的token值：token由应用系统生成，缓存在业务模块，业务可以通过token反查到设备数据信息
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }
    }
}
