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
            //词法分析
            btn_Lexer.Click += Btn_Lexer_Click;
            //词法分析（定制版）
            btn_LexerCustom.Click += Btn_LexerCustom_Click;
            //依存语法
            btn_DepParser.Click += Btn_DepParser_Click;
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
    }
}
