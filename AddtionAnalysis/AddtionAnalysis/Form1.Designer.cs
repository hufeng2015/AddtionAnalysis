﻿namespace AddtionAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Lexer = new System.Windows.Forms.Button();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.btn_DepParser = new System.Windows.Forms.Button();
            this.btn_WordEmbedding = new System.Windows.Forms.Button();
            this.btn_LexerCustom = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtInPut2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_DnnlmCn = new System.Windows.Forms.Button();
            this.btn_WordSimEmbedding = new System.Windows.Forms.Button();
            this.btn_Simnet = new System.Windows.Forms.Button();
            this.btn_CommentTag = new System.Windows.Forms.Button();
            this.btn_SentimentClassify = new System.Windows.Forms.Button();
            this.btn_Keyword = new System.Windows.Forms.Button();
            this.btn_Topic = new System.Windows.Forms.Button();
            this.btn_Ecnet = new System.Windows.Forms.Button();
            this.btn_Emotion = new System.Windows.Forms.Button();
            this.btn_NewsSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Lexer
            // 
            this.btn_Lexer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Lexer.Location = new System.Drawing.Point(3, 2);
            this.btn_Lexer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Lexer.Name = "btn_Lexer";
            this.btn_Lexer.Size = new System.Drawing.Size(160, 38);
            this.btn_Lexer.TabIndex = 5;
            this.btn_Lexer.Text = "词法分析";
            this.btn_Lexer.UseVisualStyleBackColor = true;
            this.btn_Lexer.Click += new System.EventHandler(this.Btn_Lexer_Click);
            // 
            // txtInPut
            // 
            this.txtInPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInPut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInPut.Location = new System.Drawing.Point(0, 0);
            this.txtInPut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInPut.Multiline = true;
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(107, 151);
            this.txtInPut.TabIndex = 0;
            // 
            // dataItems
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataItems.Location = new System.Drawing.Point(0, 0);
            this.dataItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataItems.Name = "dataItems";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataItems.RowTemplate.Height = 27;
            this.dataItems.Size = new System.Drawing.Size(326, 155);
            this.dataItems.TabIndex = 4;
            // 
            // btn_DepParser
            // 
            this.btn_DepParser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DepParser.Location = new System.Drawing.Point(3, 44);
            this.btn_DepParser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DepParser.Name = "btn_DepParser";
            this.btn_DepParser.Size = new System.Drawing.Size(160, 38);
            this.btn_DepParser.TabIndex = 3;
            this.btn_DepParser.Text = "依存句法分析";
            this.btn_DepParser.UseVisualStyleBackColor = true;
            this.btn_DepParser.Click += new System.EventHandler(this.Btn_DepParser_Click);
            // 
            // btn_WordEmbedding
            // 
            this.btn_WordEmbedding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WordEmbedding.Location = new System.Drawing.Point(169, 44);
            this.btn_WordEmbedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_WordEmbedding.Name = "btn_WordEmbedding";
            this.btn_WordEmbedding.Size = new System.Drawing.Size(160, 38);
            this.btn_WordEmbedding.TabIndex = 6;
            this.btn_WordEmbedding.Text = "词向量表示";
            this.btn_WordEmbedding.UseVisualStyleBackColor = true;
            this.btn_WordEmbedding.Click += new System.EventHandler(this.btn_WordEmbedding_Click);
            // 
            // btn_LexerCustom
            // 
            this.btn_LexerCustom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LexerCustom.Location = new System.Drawing.Point(169, 2);
            this.btn_LexerCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LexerCustom.Name = "btn_LexerCustom";
            this.btn_LexerCustom.Size = new System.Drawing.Size(160, 38);
            this.btn_LexerCustom.TabIndex = 2;
            this.btn_LexerCustom.Text = "词法分析（定制版）";
            this.btn_LexerCustom.UseVisualStyleBackColor = true;
            this.btn_LexerCustom.Click += new System.EventHandler(this.Btn_LexerCustom_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(664, 310);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataItems);
            this.splitContainer2.Size = new System.Drawing.Size(326, 310);
            this.splitContainer2.SplitterDistance = 151;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtInPut);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtInPut2);
            this.splitContainer3.Size = new System.Drawing.Size(326, 151);
            this.splitContainer3.SplitterDistance = 107;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtInPut2
            // 
            this.txtInPut2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInPut2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInPut2.Location = new System.Drawing.Point(0, 0);
            this.txtInPut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInPut2.Multiline = true;
            this.txtInPut2.Name = "txtInPut2";
            this.txtInPut2.Size = new System.Drawing.Size(215, 151);
            this.txtInPut2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Lexer);
            this.flowLayoutPanel1.Controls.Add(this.btn_LexerCustom);
            this.flowLayoutPanel1.Controls.Add(this.btn_DepParser);
            this.flowLayoutPanel1.Controls.Add(this.btn_WordEmbedding);
            this.flowLayoutPanel1.Controls.Add(this.btn_DnnlmCn);
            this.flowLayoutPanel1.Controls.Add(this.btn_WordSimEmbedding);
            this.flowLayoutPanel1.Controls.Add(this.btn_Simnet);
            this.flowLayoutPanel1.Controls.Add(this.btn_CommentTag);
            this.flowLayoutPanel1.Controls.Add(this.btn_SentimentClassify);
            this.flowLayoutPanel1.Controls.Add(this.btn_Keyword);
            this.flowLayoutPanel1.Controls.Add(this.btn_Topic);
            this.flowLayoutPanel1.Controls.Add(this.btn_Ecnet);
            this.flowLayoutPanel1.Controls.Add(this.btn_Emotion);
            this.flowLayoutPanel1.Controls.Add(this.btn_NewsSummary);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 310);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_DnnlmCn
            // 
            this.btn_DnnlmCn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DnnlmCn.Location = new System.Drawing.Point(3, 86);
            this.btn_DnnlmCn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DnnlmCn.Name = "btn_DnnlmCn";
            this.btn_DnnlmCn.Size = new System.Drawing.Size(160, 38);
            this.btn_DnnlmCn.TabIndex = 7;
            this.btn_DnnlmCn.Text = "DNN语言模型";
            this.btn_DnnlmCn.UseVisualStyleBackColor = true;
            this.btn_DnnlmCn.Click += new System.EventHandler(this.btn_DnnlmCn_Click);
            // 
            // btn_WordSimEmbedding
            // 
            this.btn_WordSimEmbedding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WordSimEmbedding.Location = new System.Drawing.Point(169, 86);
            this.btn_WordSimEmbedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_WordSimEmbedding.Name = "btn_WordSimEmbedding";
            this.btn_WordSimEmbedding.Size = new System.Drawing.Size(160, 38);
            this.btn_WordSimEmbedding.TabIndex = 8;
            this.btn_WordSimEmbedding.Text = "词义相似度";
            this.btn_WordSimEmbedding.UseVisualStyleBackColor = true;
            this.btn_WordSimEmbedding.Click += new System.EventHandler(this.btn_WordSimEmbedding_Click);
            // 
            // btn_Simnet
            // 
            this.btn_Simnet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Simnet.Location = new System.Drawing.Point(3, 128);
            this.btn_Simnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Simnet.Name = "btn_Simnet";
            this.btn_Simnet.Size = new System.Drawing.Size(160, 38);
            this.btn_Simnet.TabIndex = 9;
            this.btn_Simnet.Text = "短文本相似度";
            this.btn_Simnet.UseVisualStyleBackColor = true;
            this.btn_Simnet.Click += new System.EventHandler(this.btn_Simnet_Click);
            // 
            // btn_CommentTag
            // 
            this.btn_CommentTag.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CommentTag.Location = new System.Drawing.Point(169, 128);
            this.btn_CommentTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CommentTag.Name = "btn_CommentTag";
            this.btn_CommentTag.Size = new System.Drawing.Size(160, 38);
            this.btn_CommentTag.TabIndex = 10;
            this.btn_CommentTag.Text = "评论观点抽取";
            this.btn_CommentTag.UseVisualStyleBackColor = true;
            this.btn_CommentTag.Click += new System.EventHandler(this.btn_CommentTag_Click);
            // 
            // btn_SentimentClassify
            // 
            this.btn_SentimentClassify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SentimentClassify.Location = new System.Drawing.Point(3, 170);
            this.btn_SentimentClassify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SentimentClassify.Name = "btn_SentimentClassify";
            this.btn_SentimentClassify.Size = new System.Drawing.Size(160, 38);
            this.btn_SentimentClassify.TabIndex = 11;
            this.btn_SentimentClassify.Text = "情感倾向分析";
            this.btn_SentimentClassify.UseVisualStyleBackColor = true;
            this.btn_SentimentClassify.Click += new System.EventHandler(this.btn_SentimentClassify_Click);
            // 
            // btn_Keyword
            // 
            this.btn_Keyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Keyword.Location = new System.Drawing.Point(169, 170);
            this.btn_Keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Keyword.Name = "btn_Keyword";
            this.btn_Keyword.Size = new System.Drawing.Size(160, 38);
            this.btn_Keyword.TabIndex = 12;
            this.btn_Keyword.Text = "文章标签";
            this.btn_Keyword.UseVisualStyleBackColor = true;
            this.btn_Keyword.Click += new System.EventHandler(this.btn_Keyword_Click);
            // 
            // btn_Topic
            // 
            this.btn_Topic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Topic.Location = new System.Drawing.Point(3, 212);
            this.btn_Topic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Topic.Name = "btn_Topic";
            this.btn_Topic.Size = new System.Drawing.Size(160, 38);
            this.btn_Topic.TabIndex = 13;
            this.btn_Topic.Text = "文章分类";
            this.btn_Topic.UseVisualStyleBackColor = true;
            this.btn_Topic.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // btn_Ecnet
            // 
            this.btn_Ecnet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ecnet.Location = new System.Drawing.Point(169, 212);
            this.btn_Ecnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ecnet.Name = "btn_Ecnet";
            this.btn_Ecnet.Size = new System.Drawing.Size(160, 38);
            this.btn_Ecnet.TabIndex = 14;
            this.btn_Ecnet.Text = "文本纠错";
            this.btn_Ecnet.UseVisualStyleBackColor = true;
            this.btn_Ecnet.Click += new System.EventHandler(this.btn_Ecnet_Click);
            // 
            // btn_Emotion
            // 
            this.btn_Emotion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Emotion.Location = new System.Drawing.Point(3, 254);
            this.btn_Emotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Emotion.Name = "btn_Emotion";
            this.btn_Emotion.Size = new System.Drawing.Size(160, 38);
            this.btn_Emotion.TabIndex = 15;
            this.btn_Emotion.Text = "对话情绪识别接口";
            this.btn_Emotion.UseVisualStyleBackColor = true;
            this.btn_Emotion.Click += new System.EventHandler(this.btn_Emotion_Click);
            // 
            // btn_NewsSummary
            // 
            this.btn_NewsSummary.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_NewsSummary.Location = new System.Drawing.Point(169, 254);
            this.btn_NewsSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NewsSummary.Name = "btn_NewsSummary";
            this.btn_NewsSummary.Size = new System.Drawing.Size(160, 38);
            this.btn_NewsSummary.TabIndex = 16;
            this.btn_NewsSummary.Text = "新闻摘要接口";
            this.btn_NewsSummary.UseVisualStyleBackColor = true;
            this.btn_NewsSummary.Click += new System.EventHandler(this.btn_NewsSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 310);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "词法分析";
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtInPut;
        private System.Windows.Forms.Button btn_LexerCustom;
        private System.Windows.Forms.Button btn_DepParser;
        private System.Windows.Forms.DataGridView dataItems;
        private System.Windows.Forms.Button btn_Lexer;
        private System.Windows.Forms.Button btn_WordEmbedding;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_DnnlmCn;
        private System.Windows.Forms.Button btn_WordSimEmbedding;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtInPut2;
        private System.Windows.Forms.Button btn_Simnet;
        private System.Windows.Forms.Button btn_CommentTag;
        private System.Windows.Forms.Button btn_SentimentClassify;
        private System.Windows.Forms.Button btn_Keyword;
        private System.Windows.Forms.Button btn_Topic;
        private System.Windows.Forms.Button btn_Ecnet;
        private System.Windows.Forms.Button btn_Emotion;
        private System.Windows.Forms.Button btn_NewsSummary;
    }
}

