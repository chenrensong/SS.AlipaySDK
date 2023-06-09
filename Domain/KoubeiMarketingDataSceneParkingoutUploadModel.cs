using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSceneParkingoutUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataSceneParkingoutUploadModel : AopObject
    {
        /// <summary>
        /// 停车出库场景业务参数
        /// </summary>
        [XmlElement("biz_info")]
        public ParkingOutScene BizInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部请求号，确保唯一，用于幂等控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
