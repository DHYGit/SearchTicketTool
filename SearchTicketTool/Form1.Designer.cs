namespace SearchTicketTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_StartStation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_EndStation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "始发站";
            // 
            // comboBox_StartStation
            // 
            this.comboBox_StartStation.FormattingEnabled = true;
            this.comboBox_StartStation.Location = new System.Drawing.Point(92, 56);
            this.comboBox_StartStation.Name = "comboBox_StartStation";
            this.comboBox_StartStation.Size = new System.Drawing.Size(121, 24);
            this.comboBox_StartStation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "终点站";
            // 
            // comboBox_EndStation
            // 
            this.comboBox_EndStation.FormattingEnabled = true;
            this.comboBox_EndStation.Location = new System.Drawing.Point(92, 93);
            this.comboBox_EndStation.Name = "comboBox_EndStation";
            this.comboBox_EndStation.Size = new System.Drawing.Size(121, 24);
            this.comboBox_EndStation.TabIndex = 1;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(92, 133);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(127, 26);
            this.dateTimePicker_Date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(321, 56);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "查询";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 360);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.comboBox_EndStation);
            this.Controls.Add(this.comboBox_StartStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_StartStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_EndStation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Search;
    }
}

