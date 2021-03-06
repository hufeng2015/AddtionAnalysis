﻿using Baidu.Aip.Nlp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddtionAnalysis
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 自然语言处理客户端
        /// </summary>
        private Nlp client;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化客户端
            client = new Nlp(PartOfSpeech.API_KEY, PartOfSpeech.SECRET_KEY);
            //设置超时时间
            client.Timeout = 60000;
        }
        /// <summary>
        /// 依存语法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DepParser_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var options = new Dictionary<string, object> { { "mode", 1 } };
                var results = client.DepParser(txtInPut.Text).ToObject<DepParserResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
            }
        }

        /// <summary>
        /// 词法分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Lexer_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.Lexer(txtInPut.Text).ToObject<LexerResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
            }
        }

        /// <summary>
        /// 词法分析（定制版）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LexerCustom_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.LexerCustom(txtInPut.Text).ToObject<LexerResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items.FindAll(f=>f.Pos != PartOfSpeech.w);
            }
        }

        /// <summary>
        /// 界面输入校验
        /// </summary>
        /// <returns></returns>
        private bool CheckFormData()
        {
            return string.IsNullOrWhiteSpace(txtInPut.Text) == false;
        }

        /// <summary>
        /// 词向量表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WordEmbedding_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.WordEmbedding(txtInPut.Text).ToObject<WordEmbeddingResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results;
            }
        }
        /// <summary>
        /// DNN语言模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DnnlmCn_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.DnnlmCn(txtInPut.Text).ToObject<DnnlmCnResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
                MessageBox.Show(results.Ppl.ToString());
            }
        }
        /// <summary>
        /// 词义相似度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WordSimEmbedding_Click(object sender, EventArgs e)
        {
            if (CheckFormData2())
            {
                var results = client.WordSimEmbedding(txtInPut.Text, txtInPut2.Text).ToObject<WordSimEmbeddingResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }
        /// <summary>
        /// 界面输入校验
        /// </summary>
        /// <returns></returns>
        private bool CheckFormData2()
        {
            return string.IsNullOrWhiteSpace(txtInPut.Text) == false && string.IsNullOrWhiteSpace(txtInPut2.Text) == false;
        }

        /// <summary>
        /// 短文本相似度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Simnet_Click(object sender, EventArgs e)
        {
            if (CheckFormData2())
            {
                var options = new Dictionary<string, object>{
        {"model", "CNN"}
    };
                var results = client.Simnet(txtInPut.Text, txtInPut2.Text, options).ToObject<SimnetResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }

        /// <summary>
        /// 评论观点抽取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CommentTag_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var options = new Dictionary<string, object> { { "type", int.Parse(PartOfSpeech.商业) } };
        
                var results = client.CommentTag(txtInPut.Text, options).ToObject<CommentTagResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }
        /// <summary>
        /// 情感倾向分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SentimentClassify_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.SentimentClassify(txtInPut.Text).ToObject<SentimentClassifyResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
            }
        }

        /// <summary>
        /// 文章标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Keyword_Click(object sender, EventArgs e)
        {
            if (CheckFormData2())
            {
                var results = client.Keyword(txtInPut.Text, txtInPut2.Text).ToObject<KeywordResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }

        private void btn_Topic_Click(object sender, EventArgs e)
        {
            if (CheckFormData2())
            {
                var results = client.Topic(txtInPut.Text, txtInPut2.Text).ToObject<TopicResult>();
                Text = $"调用日志ID为：{results.LogId}";
                var resultsAll = results.Result.lv1_tag_list;
                resultsAll.AddRange(results.Result.lv2_tag_list);
                dataItems.DataSource = resultsAll;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }

        /// <summary>
        /// 文本纠错
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ecnet_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var results = client.Ecnet(txtInPut.Text).ToObject<EcnetResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }

        private void btn_Emotion_Click(object sender, EventArgs e)
        {

            if (CheckFormData())
            {
                // 调用对话情绪识别接口，可能会抛出网络等异常，请使用try/catch捕获
                var results = client.Emotion(txtInPut.Text).ToObject<EmotionResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results.Items;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);


                //// 如果有可选参数
                //var options = new Dictionary<string, object>{
                //    {"scene", "talk"}
                //};
                //// 带参数调用对话情绪识别接口
                //result = client.Emotion(txtInPut.Text, options).ToObject<EmotionResult>();
                //Console.WriteLine(result);
            }



        }

        private void btn_NewsSummary_Click(object sender, EventArgs e)
        {
            if (CheckFormData())
            {
                var maxSummaryLen = 300;
                var results = client.NewsSummary(txtInPut.Text, maxSummaryLen).ToObject<NewsSummaryResult>();
                Text = $"调用日志ID为：{results.LogId}";
                dataItems.DataSource = results;
                txtInPut2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(results);
            }
        }
    }
}
