using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiCateringKmsBakingBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKmsBakingBatchqueryModel : AopObject
    {
        /// <summary>
        /// 预测日期，目前只支持预测当天日期
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品skuId，数组结构，目前批量最多只支持100个sku
        /// </summary>
        [XmlArray("sku_id")]
        [XmlArrayItem("string")]
        public List<string> SkuId { get; set; }
    }
}
