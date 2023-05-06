using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniBizdataTemplatemessageUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBizdataTemplatemessageUploadModel : AopObject
    {
        /// <summary>
        /// 服务信息列表，列表大小不超过50
        /// </summary>
        [XmlArray("biz_data_list")]
        [XmlArrayItem("user_app_biz_data_info")]
        public List<UserAppBizDataInfo> BizDataList { get; set; }
    }
}
