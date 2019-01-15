using Newtonsoft.Json;

namespace AddtionAnalysis
{
    public class WordEmbeddingResult
    {
        /// <summary>
        /// 请求唯一标识码
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// string 查询词
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        /// <summary>
        /// vec float 词向量结果表示
        /// </summary>
        [JsonProperty("vec")]
        public decimal[] Vec { get; set; }
    }
}