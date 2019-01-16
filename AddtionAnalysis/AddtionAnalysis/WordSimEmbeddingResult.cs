using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 词义相似度 返回数据参数详情
    /// </summary>
    public class WordSimEmbeddingResult
    {
        /// <summary>
        /// 请求唯一标识码,随机数
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 相似度结果，(0,1]，分数越高说明相似度越高
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; set; }
        /// <summary>
        /// 输入的词列表
        /// </summary>
        [JsonProperty("words")]
        public Word Words { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public class Word
        {
            /// <summary>
            /// 输入的word1参数
            /// </summary>
            [JsonProperty("word_1")]
            public string Word1 { get; set; }
            /// <summary>
            /// 输入的word2参数
            /// </summary>
            [JsonProperty("word_2")]
            public string Word2 { get; set; }
        }
    }
}