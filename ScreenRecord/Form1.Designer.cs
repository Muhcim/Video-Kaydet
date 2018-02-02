namespace ScreenRecord
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            //if (_writer.IsOpen)
            //{
            //    _streamVideo.SignalToStop();
            //    _writer.Close();
            //    _writer.Dispose();
            //}
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.cb_VideoCodec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_BitRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_FPS = new System.Windows.Forms.NumericUpDown();
            this.tb_SaveFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_stopWatch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_screenSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(247, 124);
            this.bt_start.Margin = new System.Windows.Forms.Padding(2);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(56, 34);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Başla";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(184, 124);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(56, 34);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Dur";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(7, 129);
            this.lb_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(50, 13);
            this.lb_1.TabIndex = 3;
            this.lb_1.Text = "Çerçeve:";
            // 
            // cb_VideoCodec
            // 
            this.cb_VideoCodec.FormattingEnabled = true;
            this.cb_VideoCodec.Location = new System.Drawing.Point(76, 10);
            this.cb_VideoCodec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VideoCodec.Name = "cb_VideoCodec";
            this.cb_VideoCodec.Size = new System.Drawing.Size(102, 21);
            this.cb_VideoCodec.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VideoCodec:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bit Hızı:";
            // 
            // cb_BitRate
            // 
            this.cb_BitRate.FormattingEnabled = true;
            this.cb_BitRate.Location = new System.Drawing.Point(227, 10);
            this.cb_BitRate.Margin = new System.Windows.Forms.Padding(2);
            this.cb_BitRate.Name = "cb_BitRate";
            this.cb_BitRate.Size = new System.Drawing.Size(76, 21);
            this.cb_BitRate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FPS:";
            // 
            // nud_FPS
            // 
            this.nud_FPS.Location = new System.Drawing.Point(227, 34);
            this.nud_FPS.Margin = new System.Windows.Forms.Padding(2);
            this.nud_FPS.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_FPS.Name = "nud_FPS";
            this.nud_FPS.Size = new System.Drawing.Size(75, 20);
            this.nud_FPS.TabIndex = 9;
            this.nud_FPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_SaveFolder
            // 
            this.tb_SaveFolder.Location = new System.Drawing.Point(9, 102);
            this.tb_SaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SaveFolder.Name = "tb_SaveFolder";
            this.tb_SaveFolder.Size = new System.Drawing.Size(295, 20);
            this.tb_SaveFolder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Klasöre Kaydet:";
            // 
            // lb_stopWatch
            // 
            this.lb_stopWatch.AutoSize = true;
            this.lb_stopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_stopWatch.Location = new System.Drawing.Point(60, 54);
            this.lb_stopWatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stopWatch.Name = "lb_stopWatch";
            this.lb_stopWatch.Size = new System.Drawing.Size(202, 26);
            this.lb_stopWatch.TabIndex = 13;
            this.lb_stopWatch.Text = "00:00:00.0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ekran:";
            // 
            // cb_screenSelector
            // 
            this.cb_screenSelector.FormattingEnabled = true;
            this.cb_screenSelector.Location = new System.Drawing.Point(76, 35);
            this.cb_screenSelector.Margin = new System.Windows.Forms.Padding(2);
            this.cb_screenSelector.Name = "cb_screenSelector";
            this.cb_screenSelector.Size = new System.Drawing.Size(102, 21);
            this.cb_screenSelector.TabIndex = 15;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 165);
            this.Controls.Add(this.cb_screenSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_stopWatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SaveFolder);
            this.Controls.Add(this.nud_FPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_BitRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_VideoCodec);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.ComboBox cb_VideoCodec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_BitRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_FPS;
        private System.Windows.Forms.TextBox tb_SaveFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_stopWatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_screenSelector;
    }
}

