using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringKdsInfoQueryResponse.
    /// </summary>
    public class KoubeiCateringKdsInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// kds 配置信息列表
        /// </summary>
        [XmlArray("kds_info_model_list")]
        [XmlArrayItem("kds_info_model")]
        public List<KdsInfoModel> KdsInfoModelList { get; set; }
    }
}
