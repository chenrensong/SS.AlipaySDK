using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionLastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionLastQueryModel : AopObject
    {
        /// <summary>
        /// 业务来源场景
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序主体
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
