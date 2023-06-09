using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionInfoQueryModel : AopObject
    {
        /// <summary>
        /// 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 查询版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
