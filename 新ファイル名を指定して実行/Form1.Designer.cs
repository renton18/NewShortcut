namespace 新ファイル名を指定して実行
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            新ファイル名を指定して実行.Properties.Settings settings2 = new 新ファイル名を指定して実行.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.labelDetailInformation = new System.Windows.Forms.Label();
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxKidoSetting = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(65, 56);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(307, 20);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.TextUpdate += new System.EventHandler(this.comboBoxMain_TextUpdate);
            this.comboBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxMain_KeyDown);
            // 
            // labelDetailInformation
            // 
            this.labelDetailInformation.AutoSize = true;
            this.labelDetailInformation.BackColor = System.Drawing.Color.Orange;
            this.labelDetailInformation.Location = new System.Drawing.Point(72, 30);
            this.labelDetailInformation.Name = "labelDetailInformation";
            this.labelDetailInformation.Size = new System.Drawing.Size(0, 12);
            this.labelDetailInformation.TabIndex = 1;
            // 
            // comboBoxDisplay
            // 
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Items.AddRange(new object[] {
            "左上",
            "左下"});
            this.comboBoxDisplay.Location = new System.Drawing.Point(77, 34);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(56, 20);
            this.comboBoxDisplay.TabIndex = 3;
            this.comboBoxDisplay.Text = "左上";
            this.comboBoxDisplay.TextChanged += new System.EventHandler(this.comboBoxDisplay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "表示場所：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxKidoSetting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDisplay);
            this.panel1.Location = new System.Drawing.Point(14, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 128);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxKidoSetting
            // 
            this.checkBoxKidoSetting.AutoSize = true;
            settings2.COMMANDS = ((System.Collections.Specialized.StringCollection)(resources.GetObject("settings2.COMMANDS")));
            settings2.displaySetting = "左上";
            settings2.kidoSetting = false;
            settings2.SettingsKey = "";
            this.checkBoxKidoSetting.Checked = settings2.kidoSetting;
            this.checkBoxKidoSetting.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings2, "kidoSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxKidoSetting.Location = new System.Drawing.Point(14, 12);
            this.checkBoxKidoSetting.Name = "checkBoxKidoSetting";
            this.checkBoxKidoSetting.Size = new System.Drawing.Size(69, 16);
            this.checkBoxKidoSetting.TabIndex = 2;
            this.checkBoxKidoSetting.Text = "常に起動";
            this.checkBoxKidoSetting.UseVisualStyleBackColor = true;
            this.checkBoxKidoSetting.CheckedChanged += new System.EventHandler(this.checkBoxKidoSetting_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名前(O) :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::新ファイル名を指定して実行.Properties.Resources._25_b3;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(63, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "管理者権限:CTRL+SHIFT 設定:F1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDetailInformation);
            this.Controls.Add(this.comboBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新ファイル名を指定して実行";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.Label labelDetailInformation;
        private System.Windows.Forms.CheckBox checkBoxKidoSetting;
        private System.Windows.Forms.ComboBox comboBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

