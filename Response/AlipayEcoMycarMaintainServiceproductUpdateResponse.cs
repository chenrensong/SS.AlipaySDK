using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainServiceproductUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainServiceproductUpdateResponse : AopResponse
    {
        /// <summary>
        /// 车主平台生成的产品编号  新增：必填
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
