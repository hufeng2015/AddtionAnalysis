using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddtionAnalysis
{
    /// <summary>
    /// 词性分析结果
    /// </summary>
    public class LexerResult
    {
        /// <summary>
        /// 调用日志id
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }
        /// <summary>
        /// 是   原始单条请求文本
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// 是 词汇数组，每个元素对应结果中的一个词
        /// </summary>
        [JsonProperty("items")]
        public List<Result> Items { get; set; }

        /// <summary>
        /// 分析结果
        /// </summary>
        public class Result
        {
            /// <summary>
            /// 是   词汇的字符串
            /// </summary>
            [JsonProperty("item")]
            public string Item { get; set; }
            /// <summary>
            /// 是   命名实体类型，命名实体识别算法使用。词性标注算法中，此项为空串
            /// </summary>
            [JsonProperty("ne")]
            public string Ne { get; set; }
            /// <summary>
            /// 专名识别缩略词含义
            /// </summary>
            public string NamedEntityRecognition { get { return PartOfSpeech.ResourceManager.GetString(Ne); } }
            /// <summary>
            /// 是   词性，词性标注算法使用。命名实体识别算法中，此项为空串
            /// </summary>
            [JsonProperty("pos")]
            public string Pos { get; set; }
            /// <summary>
            /// 词性缩略说明
            /// </summary>
            public string LexicalAbbreviations { get { return PartOfSpeech.ResourceManager.GetString(Pos); } }
            /// <summary>
            /// 是   在text中的字节级offset（使用GBK编码）
            /// </summary>
            [JsonProperty("byte_offset")]
            public int Byte_offset { get; set; }
            /// <summary>
            /// 是   字节级length（使用GBK编码）
            /// </summary>
            [JsonProperty("byte_length")]
            public int Byte_length { get; set; }
            /// <summary>
            /// 否   链指到知识库的URI，只对命名实体有效。对于非命名实体和链接不到知识库的命名实体，此项为空串
            /// </summary>
            [JsonProperty("uri")]
            public string Uri { get; set; }
            /// <summary>
            /// 否   词汇的标准化表达，主要针对时间、数字单位，没有归一化表达的，此项为空串
            /// </summary>
            [JsonProperty("formal")]
            public string Formal { get; set; }
            /// <summary>
            ///  是 基本词成分
            /// </summary>
            [JsonProperty("basic_words")]
            public List<string> Basic_words { get; set; }
            /// <summary>
            /// 否 地址成分，非必需，仅对地址型命名实体有效，没有地址成分的，此项为空数组。
            /// </summary>
            [JsonProperty("loc_details")]
            public List<LocDetail> LocDetails { get; set; }
        }
        /// <summary>
        /// 地址成分
        /// </summary>
        public class LocDetail
        {
            /// <summary>
            /// 是   成分类型，如省、市、区、县
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }
            /// <summary>
            /// 是   在item中的字节级offset（使用GBK编码）
            /// </summary>
            [JsonProperty("byte_offset")]
            public int Byte_offset { get; set; }
            /// <summary>
            /// 是   字节级length（使用GBK编码）
            /// </summary>
            [JsonProperty("byte_length")]
            public int Byte_length { get; set; }
        }
    }
    
}
