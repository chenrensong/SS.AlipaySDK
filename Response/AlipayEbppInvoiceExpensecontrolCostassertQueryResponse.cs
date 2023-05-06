using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolCostassertQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolCostassertQueryResponse : AopResponse
    {
        /// <summary>
        /// 消耗资产明细列表
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("expense_asset_info")]
        public List<ExpenseAssetInfo> AssetList { get; set; }
    }
}
