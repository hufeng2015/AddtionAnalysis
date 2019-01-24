using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 文章标签
    /// </summary>
    public class KeywordResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 关键词结果数组，每个元素对应抽取到的一个关键词
        /// </summary>
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 关注点字符串
            /// </summary>
            [JsonProperty("tag")]
            public string Tag { get; set; }
            /// <summary>
            /// 权重(取值范围0~1)
            /// </summary>
            [JsonProperty("score")]
            public double Score { get; set; }
        }
    }
}