using Newtonsoft.Json;

namespace AddtionAnalysis
{
    /// <summary>
    /// 短文本相似度 返回数据参数详情
    /// </summary>
    public class SimnetResult
    {
        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 相似度结果取值(0,1]，分数越高说明相似度越高
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; set; }
        /// <summary>
        /// 输入文本
        /// </summary>
        [JsonProperty("texts")]
        public TextInput Texts { get; set; }

        /// <summary>
        /// 输入文本
        /// </summary>
        public class TextInput
        {
            /// <summary>
            /// 第一个短文本
            /// </summary>
            [JsonProperty("text_1")]
            public string Text1 { get; set; }
            /// <summary>
            /// 第二个短文本
            /// </summary>
            [JsonProperty("text_2")]
            public string Text2 { get; set; }
        }
    }
}