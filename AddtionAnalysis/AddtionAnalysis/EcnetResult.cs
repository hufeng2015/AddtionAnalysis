using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 文本纠错
    /// </summary>
    public class EcnetResult
    {
        /// <summary>
        /// 调用日志
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }

        //分析结果
        [JsonProperty("item")]
        public Item Items { get; set; }
        /// <summary>
        /// 原始文本
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public class Item
        {
            /// <summary>
            /// 替换候选片段信息
            /// </summary>
            [JsonProperty("vec_fragment")]
            public List<VecFragment> VecFragments { get; set; }

            /// <summary>
            /// 纠错后的文本
            /// </summary>
            [JsonProperty("correct_query")]
            public string CorrectQuery { get; set; }
            //模型置信度打分
            [JsonProperty("score")]
            public double Score { get; set; }
            /// <summary>
            /// 替换候选片段信息
            /// </summary>
            public class VecFragment
            {
                /// <summary>
                /// 原片段
                /// </summary>
                [JsonProperty("ori_frag")]
                public string OriFrag { get; set; }
                /// <summary>
                /// 替换片段
                /// </summary>
                [JsonProperty("correct_frag")]
                public string CorrectFrag { get; set; }

                /// <summary>
                /// 起始(长度单位)
                /// </summary>
                [JsonProperty("begin_pos")]
                public int BeginPos { get; set; }
                /// <summary>
                /// 结尾(长度单位)
                /// </summary>
                [JsonProperty("end_pos")]
                public int EndPos { get; set; }
            }
        }
    }
}