using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 返回
    /// </summary>
    public class CommentTagResult
    {
        /// <summary>
        /// 调用日志id
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        /// <summary>
        /// 具体结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 匹配上的属性词
            /// </summary>
            [JsonProperty("prop")]
            public string Prop { get; set; }
            /// <summary>
            /// 匹配上的描述词
            /// </summary>
            [JsonProperty("adj")]
            public string Adj { get; set; }
            /// <summary>
            /// 该情感搭配的极性（0表示消极，1表示中性，2表示积极）
            /// </summary>
            [JsonProperty("sentiment")]
            public int Sentiment { get; set; }
            /// <summary>
            /// 该情感搭配在句子中的开始位置
            /// </summary>
            [JsonProperty("begin_pos")]
            public int BeginPos { get; set; }
            /// <summary>
            /// 该情感搭配在句子中的结束位置
            /// </summary>
            [JsonProperty("end_pos")]
            public int EndPos { get; set; }
            /// <summary>
            /// 对应于该情感搭配的短句摘要
            /// </summary>
            [JsonProperty("abstract")]
            public string Abstract { get; set; }
        }
    }
}