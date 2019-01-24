using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 文章分类
    /// </summary>
    public class TopicResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 分类结果，包含一级与二级分类
        /// </summary>
        [JsonProperty("item")]
        public Item Result { get; set; }
        /// <summary>
        /// 分类结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 一级分类结果
            /// </summary>
            [JsonProperty("lv1_tag_list")]
            public List<Tag> lv1_tag_list { get; set; }
            /// <summary>
            /// 二级分类结果
            /// </summary>
            [JsonProperty("lv2_tag_list")]
            public List<Tag> lv2_tag_list { get; set; }
            /// <summary>
            /// 分类结果
            /// </summary>
            public class Tag
            {
                /// <summary>
                /// 类别标签对应得分，范围0-1
                /// </summary>
                [JsonProperty("score")]
                public double score { get; set; }
                /// <summary>
                /// 类别标签
                /// </summary>
                [JsonProperty("tag")]
                public string tag { get; set; }
            }
        }
    }
}