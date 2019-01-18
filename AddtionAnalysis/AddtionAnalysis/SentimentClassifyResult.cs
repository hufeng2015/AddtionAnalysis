using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 情感倾向分析 返回示例
    /// </summary>
    public class SentimentClassifyResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 输入的文本内容
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// 输入的词列表
        /// </summary>
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 表示情感极性分类结果, 0:负向，1:中性，2:正向
            /// </summary>
            [JsonProperty("sentiment")]
            public double Sentiment { get; set; }
            /// <summary>
            /// 表示情感极性分类结果, 0:负向，1:中性，2:正向
            /// </summary>
            public string SentimentText
            {
                get
                {
                    if (Sentiment == 0)
                    {
                        return "负向";
                    }
                    else if (Sentiment == 2)
                    {
                        return "正向";
                    }
                    else
                    {
                        return "中性";
                    }
                }
            }
            /// <summary>
            /// 表示分类的置信度
            /// </summary>
            [JsonProperty("confidence")]
            public double Confidence { get; set; }
            /// <summary>
            /// 表示属于积极类别的概率
            /// </summary>
            [JsonProperty("positive_prob")]
            public double Positive_prob { get; set; }
            /// <summary>
            /// 表示属于消极类别的概率
            /// </summary>
            [JsonProperty("negative_prob")]
            public double Negative_prob { get; set; }
        }
    }
}