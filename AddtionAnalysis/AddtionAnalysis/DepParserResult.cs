using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddtionAnalysis
{
    /// <summary>
    /// 依存语法分析结果
    /// </summary>
    public class DepParserResult
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
        /// 返回结果
        /// </summary>
        public class Result
        {
            /// <summary>
            /// id number  词的ID
            /// </summary>
            [JsonProperty("id")]
            public int ID { get; set; }
            /// <summary>
            /// word    string 词
            /// </summary>
            [JsonProperty("word")]
            public string Word { get; set; }
            /// <summary>
            /// postag string 词性，请参照API文档中的词性（postag)取值范围
            /// </summary>
            [JsonProperty("postag")]
            public string Postag { get; set; }
            /// <summary>
            /// 专名识别缩略词含义
            /// </summary>
            public string NamedEntityRecognition { get { return PartOfSpeech.ResourceManager.GetString(Postag); } }
            /// <summary>
            /// head    int 词的父节点ID
            /// </summary>
            [JsonProperty("head")]
            public int Head { get; set; }
            /// <summary>
            /// deprel string 词与父节点的依存关系，请参照API文档的依存关系标识
            /// </summary>
            [JsonProperty("deprel")]
            public string Deprel { get; set; }
            /// <summary>
            /// 依存关系缩略词含义
            /// </summary>
            public string DependencyRelationship { get { return PartOfSpeech.ResourceManager.GetString(Deprel); } }
        }
    }


}
