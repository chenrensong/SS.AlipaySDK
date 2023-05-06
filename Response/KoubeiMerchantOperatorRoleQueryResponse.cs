using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleQueryResponse : AopResponse
    {
        /// <summary>
        /// 角色信息包含角色ID和角色名称,以及权限汇总信息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("koubei_merchant_role")]
        public List<KoubeiMerchantRole> List { get; set; }
    }
}
