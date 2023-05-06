using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// PosFixedDishGroupModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosFixedDishGroupModel : AopObject
    {
        /// <summary>
        /// 固定菜的数量，有固定菜时必传
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 选中的sku的规格中文名
        /// </summary>
        [XmlElement("detail_sku_spec_name")]
        public string DetailSkuSpecName { get; set; }

        /// <summary>
        /// 菜品的单位中文名
        /// </summary>
        [XmlElement("detail_sku_unit_name")]
        public string DetailSkuUnitName { get; set; }

        /// <summary>
        /// 固定菜的菜品ID，有固定菜时必传
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 固定菜名字，仅在查询返回时返回
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 固定菜的组ID，更新的时候需要传
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 固定菜的售价,有固定菜时必传
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 固定菜的SKU的id，有固定菜时必传
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 固定菜的排序字段，有固定菜时必传
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
