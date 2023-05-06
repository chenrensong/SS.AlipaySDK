using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsAutoUserPointReceiveResponse.
    /// </summary>
    public class AlipayInsAutoUserPointReceiveResponse : AopResponse
    {
        /// <summary>
        /// 本次成功积攒的积分量  如攒油活动，则是本次积攒油量，单位ml
        /// </summary>
        [XmlElement("save_amount")]
        public long SaveAmount { get; set; }
    }
}
