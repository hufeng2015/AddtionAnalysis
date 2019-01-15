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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Lexer = new System.Windows.Forms.Button();
            this.btn_DepParser = new System.Windows.Forms.Button();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.btn_LexerCustom = new System.Windows.Forms.Button();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.btn_WordEmbedding = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Lexer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInPut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_DepParser, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_WordEmbedding, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_LexerCustom, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Lexer
            // 
            this.btn_Lexer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Lexer.Location = new System.Drawing.Point(3, 269);
            this.btn_Lexer.Name = "btn_Lexer";
            this.btn_Lexer.Size = new System.Drawing.Size(160, 38);
            this.btn_Lexer.TabIndex = 5;
            this.btn_Lexer.Text = "词法分析";
            this.btn_Lexer.UseVisualStyleBackColor = true;
            // 
            // btn_DepParser
            // 
            this.btn_DepParser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DepParser.Location = new System.Drawing.Point(335, 269);
            this.btn_DepParser.Name = "btn_DepParser";
            this.btn_DepParser.Size = new System.Drawing.Size(160, 38);
            this.btn_DepParser.TabIndex = 3;
            this.btn_DepParser.Text = "依存句法分析";
            this.btn_DepParser.UseVisualStyleBackColor = true;
            // 
            // txtInPut
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtInPut, 3);
            this.txtInPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInPut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInPut.Location = new System.Drawing.Point(3, 3);
            this.txtInPut.Multiline = true;
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(492, 127);
            this.txtInPut.TabIndex = 0;
            // 
            // btn_LexerCustom
            // 
            this.btn_LexerCustom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LexerCustom.Location = new System.Drawing.Point(169, 269);
            this.btn_LexerCustom.Name = "btn_LexerCustom";
            this.btn_LexerCustom.Size = new System.Drawing.Size(160, 38);
            this.btn_LexerCustom.TabIndex = 2;
            this.btn_LexerCustom.Text = "词法分析（定制版）";
            this.btn_LexerCustom.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.SetColumnSpan(this.dataItems, 3);
            this.dataItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataItems.Location = new System.Drawing.Point(3, 136);
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
            this.dataItems.Size = new System.Drawing.Size(492, 127);
            this.dataItems.TabIndex = 4;
            // 
            // btn_WordEmbedding
            // 
            this.btn_WordEmbedding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WordEmbedding.Location = new System.Drawing.Point(501, 269);
            this.btn_WordEmbedding.Name = "btn_WordEmbedding";
            this.btn_WordEmbedding.Size = new System.Drawing.Size(160, 38);
            this.btn_WordEmbedding.TabIndex = 6;
            this.btn_WordEmbedding.Text = "词向量表示";
            this.btn_WordEmbedding.UseVisualStyleBackColor = true;
            this.btn_WordEmbedding.Click += new System.EventHandler(this.btn_WordEmbedding_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 310);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "词法分析";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtInPut;
        private System.Windows.Forms.Button btn_LexerCustom;
        private System.Windows.Forms.Button btn_DepParser;
        private System.Windows.Forms.DataGridView dataItems;
        private System.Windows.Forms.Button btn_Lexer;
        private System.Windows.Forms.Button btn_WordEmbedding;
    }
}

