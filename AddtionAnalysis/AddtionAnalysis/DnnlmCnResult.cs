using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// DNN语言模型 返回数据参数详情
    /// </summary>
    public class DnnlmCnResult
    {
        /// <summary>
        /// 请求唯一标识码
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 返回的分析结果
        /// </summary>
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
        /// <summary>
        /// 描述句子通顺的值：数值越低，句子越通顺
        /// </summary>
        [JsonProperty("ppl")]
        public double Ppl { get; set; }

        /// <summary>
        /// 分析结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 句子的切词结果
            /// </summary>
            [JsonProperty("word")]
            public string Word { get; set; }
            /// <summary>
            /// 该词在句子中的概率值,取值范围[0,1]
            /// </summary>
            [JsonProperty("prob")]
            public double Prob { get; set; }
        }
    }
}