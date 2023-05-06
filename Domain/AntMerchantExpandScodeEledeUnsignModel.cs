using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeEledeUnsignModel : AopObject
    {
        /// <summary>
        /// 去标请求
        /// </summary>
        [XmlArray("remove_tag_request")]
        [XmlArrayItem("remove_tag_request")]
        public List<RemoveTagRequest> RemoveTagRequest { get; set; }
    }
}
