using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappServicePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappServicePublishModel : AopObject
    {
        /// <summary>
        /// 服务发布logo
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序模板所属PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 服务子标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
