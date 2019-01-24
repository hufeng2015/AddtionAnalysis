using Newtonsoft.Json;

namespace AddtionAnalysis
{
    public class NewsSummaryResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 摘要结果
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}