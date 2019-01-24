using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    public class EmotionResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 原始文本
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        //分析结果
        [JsonProperty("items")]
        public List<Item> Items { get; set; }


        public class Item
        {


            [JsonProperty("subitems")]
            public List<SubItem> SubItems { get; set; }
            public class SubItem
            {
                [JsonProperty("label")]
                public string Label { get; set; }
                /// <summary>
                /// item标签对应的概率
                /// </summary>
                [JsonProperty("prob")]
                public double Prob { get; set; }
            }
            /// <summary>
            /// 回复
            /// </summary>
            public List<string> replies { get; set; }

            /// <summary>
            /// item的分类标签；pessimistic（强烈负向情绪）、neutral（非强烈负向情绪）
            /// </summary>
            [JsonProperty("label")]
            public string Label { get; set; }
            /// <summary>
            /// item标签对应的概率
            /// </summary>
            [JsonProperty("prob")]
            public double Prob { get; set; }


        }
    }
}