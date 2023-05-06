using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPayAppTransportCardinfoQueryResponse.
    /// </summary>
    public class AlipayPayAppTransportCardinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡信息密文
        /// </summary>
        [XmlElement("card_data_cipher")]
        public string CardDataCipher { get; set; }
    }
}
