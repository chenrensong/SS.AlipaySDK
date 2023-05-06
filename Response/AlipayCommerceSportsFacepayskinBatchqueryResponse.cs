using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceSportsFacepayskinBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceSportsFacepayskinBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户付款码皮肤信息列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("user_face_pay_skin_info")]
        public List<UserFacePaySkinInfo> DataList { get; set; }
    }
}
