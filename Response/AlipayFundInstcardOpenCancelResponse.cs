using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundInstcardOpenCancelResponse.
    /// </summary>
    public class AlipayFundInstcardOpenCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否销户成功
        /// </summary>
        [XmlElement("canceled")]
        public bool Canceled { get; set; }
    }
}
