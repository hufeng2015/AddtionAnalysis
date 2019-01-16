namespace AddtionAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Lexer = new System.Windows.Forms.Button();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.btn_DepParser = new System.Windows.Forms.Button();
            this.btn_WordEmbedding = new System.Windows.Forms.Button();
            this.btn_LexerCustom = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_DnnlmCn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Lexer
            // 
            this.btn_Lexer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Lexer.Location = new System.Drawing.Point(3, 3);
            this.btn_Lexer.Name = "btn_Lexer";
            this.btn_Lexer.Size = new System.Drawing.Size(160, 38);
            this.btn_Lexer.TabIndex = 5;
            this.btn_Lexer.Text = "词法分析";
            this.btn_Lexer.UseVisualStyleBackColor = true;
            // 
            // txtInPut
            // 
            this.txtInPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInPut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInPut.Location = new System.Drawing.Point(0, 0);
            this.txtInPut.Multiline = true;
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(327, 152);
            this.txtInPut.TabIndex = 0;
            // 
            // dataItems
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataItems.Location = new System.Drawing.Point(0, 0);
            this.dataItems.Name = "dataItems";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataItems.RowTemplate.Height = 27;
            this.dataItems.Size = new System.Drawing.Size(327, 154);
            this.dataItems.TabIndex = 4;
            // 
            // btn_DepParser
            // 
            this.btn_DepParser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DepParser.Location = new System.Drawing.Point(3, 47);
            this.btn_DepParser.Name = "btn_DepParser";
            this.btn_DepParser.Size = new System.Drawing.Size(160, 38);
            this.btn_DepParser.TabIndex = 3;
            this.btn_DepParser.Text = "依存句法分析";
            this.btn_DepParser.UseVisualStyleBackColor = true;
            // 
            // btn_WordEmbedding
            // 
            this.btn_WordEmbedding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WordEmbedding.Location = new System.Drawing.Point(169, 47);
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
            this.btn_LexerCustom.Location = new System.Drawing.Point(169, 3);
            this.btn_LexerCustom.Name = "btn_LexerCustom";
            this.btn_LexerCustom.Size = new System.Drawing.Size(160, 38);
            this.btn_LexerCustom.TabIndex = 2;
            this.btn_LexerCustom.Text = "词法分析（定制版）";
            this.btn_LexerCustom.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtInPut);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataItems);
            this.splitContainer2.Size = new System.Drawing.Size(327, 310);
            this.splitContainer2.SplitterDistance = 152;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Lexer);
            this.flowLayoutPanel1.Controls.Add(this.btn_LexerCustom);
            this.flowLayoutPanel1.Controls.Add(this.btn_DepParser);
            this.flowLayoutPanel1.Controls.Add(this.btn_WordEmbedding);
            this.flowLayoutPanel1.Controls.Add(this.btn_DnnlmCn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 310);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_DnnlmCn
            // 
            this.btn_DnnlmCn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DnnlmCn.Location = new System.Drawing.Point(3, 91);
            this.btn_DnnlmCn.Name = "btn_DnnlmCn";
            this.btn_DnnlmCn.Size = new System.Drawing.Size(160, 38);
            this.btn_DnnlmCn.TabIndex = 7;
            this.btn_DnnlmCn.Text = "DNN语言模型";
            this.btn_DnnlmCn.UseVisualStyleBackColor = true;
            this.btn_DnnlmCn.Click += new System.EventHandler(this.btn_DnnlmCn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 310);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "词法分析";
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
    }
}

