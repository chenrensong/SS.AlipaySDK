using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [XmlElement("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
