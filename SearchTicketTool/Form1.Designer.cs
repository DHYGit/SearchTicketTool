using SearchTicketTool.ProTool;
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
            this.tableLayoutPanel_Result = new System.Windows.Forms.TableLayoutPanel();
            this.label_TrainNum = new System.Windows.Forms.Label();
            this.label_SourceStation = new System.Windows.Forms.Label();
            this.label_DstStation = new System.Windows.Forms.Label();
            this.label_SpendTime = new System.Windows.Forms.Label();
            this.label_BusinessClass = new System.Windows.Forms.Label();
            this.label_FirstClass = new System.Windows.Forms.Label();
            this.label_SecondClass = new System.Windows.Forms.Label();
            this.label_AdvancedSoftSleeper = new System.Windows.Forms.Label();
            this.label_SoftSleeper = new System.Windows.Forms.Label();
            this.label_StillSleeper = new System.Windows.Forms.Label();
            this.label_HardSleeper = new System.Windows.Forms.Label();
            this.label_SoftClass = new System.Windows.Forms.Label();
            this.label_HardClass = new System.Windows.Forms.Label();
            this.label_NoClass = new System.Windows.Forms.Label();
            this.label_Else = new System.Windows.Forms.Label();
            this.label_Remark = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "始发站";
            // 
            // comboBox_StartStation
            // 
            this.comboBox_StartStation.FormattingEnabled = true;
            this.comboBox_StartStation.Location = new System.Drawing.Point(89, 6);
            this.comboBox_StartStation.Name = "comboBox_StartStation";
            this.comboBox_StartStation.Size = new System.Drawing.Size(121, 24);
            this.comboBox_StartStation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "终点站";
            // 
            // comboBox_EndStation
            // 
            this.comboBox_EndStation.FormattingEnabled = true;
            this.comboBox_EndStation.Location = new System.Drawing.Point(293, 6);
            this.comboBox_EndStation.Name = "comboBox_EndStation";
            this.comboBox_EndStation.Size = new System.Drawing.Size(121, 24);
            this.comboBox_EndStation.TabIndex = 1;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(486, 4);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(127, 26);
            this.dateTimePicker_Date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(629, 3);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(96, 28);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "查询";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // tableLayoutPanel_Result
            // 
            this.tableLayoutPanel_Result.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_Result.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Result.ColumnCount = 16;
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773665F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.314078F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.314911F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.313363F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.773666F));
            this.tableLayoutPanel_Result.Controls.Add(this.label_TrainNum, 0, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_SourceStation, 1, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_DstStation, 2, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_SpendTime, 3, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_BusinessClass, 4, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_FirstClass, 5, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_SecondClass, 6, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_AdvancedSoftSleeper, 7, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_SoftSleeper, 8, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_StillSleeper, 9, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_HardSleeper, 10, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_SoftClass, 11, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_HardClass, 12, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_NoClass, 13, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_Else, 14, 0);
            this.tableLayoutPanel_Result.Controls.Add(this.label_Remark, 15, 0);
            this.tableLayoutPanel_Result.Location = new System.Drawing.Point(17, 49);
            this.tableLayoutPanel_Result.Name = "tableLayoutPanel_Result";
            this.tableLayoutPanel_Result.RowCount = 1;
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel_Result.Size = new System.Drawing.Size(835, 42);
            this.tableLayoutPanel_Result.TabIndex = 4;
            // 
            // label_TrainNum
            // 
            this.label_TrainNum.AutoSize = true;
            this.label_TrainNum.BackColor = System.Drawing.SystemColors.Control;
            this.label_TrainNum.Location = new System.Drawing.Point(4, 1);
            this.label_TrainNum.Name = "label_TrainNum";
            this.label_TrainNum.Size = new System.Drawing.Size(40, 16);
            this.label_TrainNum.TabIndex = 0;
            this.label_TrainNum.Text = "车次";
            // 
            // label_SourceStation
            // 
            this.label_SourceStation.AutoSize = true;
            this.label_SourceStation.BackColor = System.Drawing.SystemColors.Control;
            this.label_SourceStation.Location = new System.Drawing.Point(52, 1);
            this.label_SourceStation.Name = "label_SourceStation";
            this.label_SourceStation.Size = new System.Drawing.Size(40, 16);
            this.label_SourceStation.TabIndex = 1;
            this.label_SourceStation.Text = "发站";
            // 
            // label_DstStation
            // 
            this.label_DstStation.AutoSize = true;
            this.label_DstStation.BackColor = System.Drawing.SystemColors.Control;
            this.label_DstStation.Location = new System.Drawing.Point(100, 1);
            this.label_DstStation.Name = "label_DstStation";
            this.label_DstStation.Size = new System.Drawing.Size(40, 16);
            this.label_DstStation.TabIndex = 1;
            this.label_DstStation.Text = "到站";
            // 
            // label_SpendTime
            // 
            this.label_SpendTime.AutoSize = true;
            this.label_SpendTime.BackColor = System.Drawing.SystemColors.Control;
            this.label_SpendTime.Location = new System.Drawing.Point(148, 1);
            this.label_SpendTime.Name = "label_SpendTime";
            this.label_SpendTime.Size = new System.Drawing.Size(40, 16);
            this.label_SpendTime.TabIndex = 1;
            this.label_SpendTime.Text = "历时";
            // 
            // label_BusinessClass
            // 
            this.label_BusinessClass.AutoSize = true;
            this.label_BusinessClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_BusinessClass.Location = new System.Drawing.Point(196, 1);
            this.label_BusinessClass.Name = "label_BusinessClass";
            this.label_BusinessClass.Size = new System.Drawing.Size(56, 32);
            this.label_BusinessClass.TabIndex = 1;
            this.label_BusinessClass.Text = "商务座特等座";
            // 
            // label_FirstClass
            // 
            this.label_FirstClass.AutoSize = true;
            this.label_FirstClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_FirstClass.Location = new System.Drawing.Point(265, 1);
            this.label_FirstClass.Name = "label_FirstClass";
            this.label_FirstClass.Size = new System.Drawing.Size(56, 16);
            this.label_FirstClass.TabIndex = 1;
            this.label_FirstClass.Text = "一等座";
            // 
            // label_SecondClass
            // 
            this.label_SecondClass.AutoSize = true;
            this.label_SecondClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_SecondClass.Location = new System.Drawing.Point(334, 1);
            this.label_SecondClass.Name = "label_SecondClass";
            this.label_SecondClass.Size = new System.Drawing.Size(56, 16);
            this.label_SecondClass.TabIndex = 1;
            this.label_SecondClass.Text = "二等座";
            // 
            // label_AdvancedSoftSleeper
            // 
            this.label_AdvancedSoftSleeper.AutoSize = true;
            this.label_AdvancedSoftSleeper.BackColor = System.Drawing.SystemColors.Control;
            this.label_AdvancedSoftSleeper.Location = new System.Drawing.Point(403, 1);
            this.label_AdvancedSoftSleeper.Name = "label_AdvancedSoftSleeper";
            this.label_AdvancedSoftSleeper.Size = new System.Drawing.Size(40, 32);
            this.label_AdvancedSoftSleeper.TabIndex = 1;
            this.label_AdvancedSoftSleeper.Text = "高级软卧";
            // 
            // label_SoftSleeper
            // 
            this.label_SoftSleeper.AutoSize = true;
            this.label_SoftSleeper.BackColor = System.Drawing.SystemColors.Control;
            this.label_SoftSleeper.Location = new System.Drawing.Point(451, 1);
            this.label_SoftSleeper.Name = "label_SoftSleeper";
            this.label_SoftSleeper.Size = new System.Drawing.Size(40, 16);
            this.label_SoftSleeper.TabIndex = 1;
            this.label_SoftSleeper.Text = "软卧";
            // 
            // label_StillSleeper
            // 
            this.label_StillSleeper.AutoSize = true;
            this.label_StillSleeper.BackColor = System.Drawing.SystemColors.Control;
            this.label_StillSleeper.Location = new System.Drawing.Point(499, 1);
            this.label_StillSleeper.Name = "label_StillSleeper";
            this.label_StillSleeper.Size = new System.Drawing.Size(40, 16);
            this.label_StillSleeper.TabIndex = 1;
            this.label_StillSleeper.Text = "动卧";
            // 
            // label_HardSleeper
            // 
            this.label_HardSleeper.AutoSize = true;
            this.label_HardSleeper.BackColor = System.Drawing.SystemColors.Control;
            this.label_HardSleeper.Location = new System.Drawing.Point(547, 1);
            this.label_HardSleeper.Name = "label_HardSleeper";
            this.label_HardSleeper.Size = new System.Drawing.Size(40, 16);
            this.label_HardSleeper.TabIndex = 1;
            this.label_HardSleeper.Text = "硬卧";
            // 
            // label_SoftClass
            // 
            this.label_SoftClass.AutoSize = true;
            this.label_SoftClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_SoftClass.Location = new System.Drawing.Point(595, 1);
            this.label_SoftClass.Name = "label_SoftClass";
            this.label_SoftClass.Size = new System.Drawing.Size(40, 16);
            this.label_SoftClass.TabIndex = 1;
            this.label_SoftClass.Text = "软座";
            // 
            // label_HardClass
            // 
            this.label_HardClass.AutoSize = true;
            this.label_HardClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_HardClass.Location = new System.Drawing.Point(643, 1);
            this.label_HardClass.Name = "label_HardClass";
            this.label_HardClass.Size = new System.Drawing.Size(40, 16);
            this.label_HardClass.TabIndex = 1;
            this.label_HardClass.Text = "硬座";
            // 
            // label_NoClass
            // 
            this.label_NoClass.AutoSize = true;
            this.label_NoClass.BackColor = System.Drawing.SystemColors.Control;
            this.label_NoClass.Location = new System.Drawing.Point(691, 1);
            this.label_NoClass.Name = "label_NoClass";
            this.label_NoClass.Size = new System.Drawing.Size(40, 16);
            this.label_NoClass.TabIndex = 1;
            this.label_NoClass.Text = "无座";
            // 
            // label_Else
            // 
            this.label_Else.AutoSize = true;
            this.label_Else.BackColor = System.Drawing.SystemColors.Control;
            this.label_Else.Location = new System.Drawing.Point(739, 1);
            this.label_Else.Name = "label_Else";
            this.label_Else.Size = new System.Drawing.Size(40, 16);
            this.label_Else.TabIndex = 1;
            this.label_Else.Text = "其他";
            // 
            // label_Remark
            // 
            this.label_Remark.AutoSize = true;
            this.label_Remark.BackColor = System.Drawing.SystemColors.Control;
            this.label_Remark.Location = new System.Drawing.Point(787, 1);
            this.label_Remark.Name = "label_Remark";
            this.label_Remark.Size = new System.Drawing.Size(40, 16);
            this.label_Remark.TabIndex = 1;
            this.label_Remark.Text = "购票";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(769, 6);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(83, 25);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 360);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.tableLayoutPanel_Result);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.comboBox_EndStation);
            this.Controls.Add(this.comboBox_StartStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_Result.ResumeLayout(false);
            this.tableLayoutPanel_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HttpDataResponseTool httpTool;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_StartStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_EndStation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Result;
        private System.Windows.Forms.Label label_TrainNum;
        private System.Windows.Forms.Label label_SourceStation;
        private System.Windows.Forms.Label label_DstStation;
        private System.Windows.Forms.Label label_SpendTime;
        private System.Windows.Forms.Label label_BusinessClass;
        private System.Windows.Forms.Label label_FirstClass;
        private System.Windows.Forms.Label label_SecondClass;
        private System.Windows.Forms.Label label_AdvancedSoftSleeper;
        private System.Windows.Forms.Label label_SoftSleeper;
        private System.Windows.Forms.Label label_StillSleeper;
        private System.Windows.Forms.Label label_HardSleeper;
        private System.Windows.Forms.Label label_SoftClass;
        private System.Windows.Forms.Label label_HardClass;
        private System.Windows.Forms.Label label_NoClass;
        private System.Windows.Forms.Label label_Else;
        private System.Windows.Forms.Label label_Remark;
        private System.Windows.Forms.Button button_Login;
    }
}

