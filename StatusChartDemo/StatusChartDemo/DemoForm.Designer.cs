namespace StatusChartDemo
{
    partial class DemoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.grpRefreshRate1 = new System.Windows.Forms.GroupBox();
            this.rdoRefreshSlow1 = new System.Windows.Forms.RadioButton();
            this.rdoRefreshNormal1 = new System.Windows.Forms.RadioButton();
            this.rdoRefreshFast1 = new System.Windows.Forms.RadioButton();
            this.tmrRandom = new System.Windows.Forms.Timer(this.components);
            this.grpRefreshRate2 = new System.Windows.Forms.GroupBox();
            this.rdoRefreshSlow2 = new System.Windows.Forms.RadioButton();
            this.rdoRefreshNormal2 = new System.Windows.Forms.RadioButton();
            this.rdoRefreshFast2 = new System.Windows.Forms.RadioButton();
            this.rdoEditAbove = new System.Windows.Forms.RadioButton();
            this.rdoEditBelow = new System.Windows.Forms.RadioButton();
            this.pgdSC = new System.Windows.Forms.PropertyGrid();
            this.nsc1 = new UI.StatusChart();
            this.nsc2 = new UI.StatusChart();
            this.nscDemo3 = new UI.StatusChart();
            this.nscDemo2 = new UI.StatusChart();
            this.nscDemo1 = new UI.StatusChart();
            this.grpRefreshRate1.SuspendLayout();
            this.grpRefreshRate2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRefreshRate1
            // 
            this.grpRefreshRate1.Controls.Add(this.rdoRefreshSlow1);
            this.grpRefreshRate1.Controls.Add(this.rdoRefreshNormal1);
            this.grpRefreshRate1.Controls.Add(this.rdoRefreshFast1);
            this.grpRefreshRate1.Location = new System.Drawing.Point(13, 135);
            this.grpRefreshRate1.Name = "grpRefreshRate1";
            this.grpRefreshRate1.Size = new System.Drawing.Size(261, 49);
            this.grpRefreshRate1.TabIndex = 1;
            this.grpRefreshRate1.TabStop = false;
            this.grpRefreshRate1.Text = "刷新速度";
            // 
            // rdoRefreshSlow1
            // 
            this.rdoRefreshSlow1.AutoSize = true;
            this.rdoRefreshSlow1.Location = new System.Drawing.Point(101, 21);
            this.rdoRefreshSlow1.Name = "rdoRefreshSlow1";
            this.rdoRefreshSlow1.Size = new System.Drawing.Size(35, 16);
            this.rdoRefreshSlow1.TabIndex = 0;
            this.rdoRefreshSlow1.Text = "低";
            this.rdoRefreshSlow1.UseVisualStyleBackColor = true;
            this.rdoRefreshSlow1.CheckedChanged += new System.EventHandler(this.rdoRefreshSlow1_CheckedChanged);
            // 
            // rdoRefreshNormal1
            // 
            this.rdoRefreshNormal1.AutoSize = true;
            this.rdoRefreshNormal1.Checked = true;
            this.rdoRefreshNormal1.Location = new System.Drawing.Point(48, 21);
            this.rdoRefreshNormal1.Name = "rdoRefreshNormal1";
            this.rdoRefreshNormal1.Size = new System.Drawing.Size(47, 16);
            this.rdoRefreshNormal1.TabIndex = 0;
            this.rdoRefreshNormal1.TabStop = true;
            this.rdoRefreshNormal1.Text = "正常";
            this.rdoRefreshNormal1.UseVisualStyleBackColor = true;
            this.rdoRefreshNormal1.CheckedChanged += new System.EventHandler(this.rdoRefreshNormal1_CheckedChanged);
            // 
            // rdoRefreshFast1
            // 
            this.rdoRefreshFast1.AutoSize = true;
            this.rdoRefreshFast1.Location = new System.Drawing.Point(7, 21);
            this.rdoRefreshFast1.Name = "rdoRefreshFast1";
            this.rdoRefreshFast1.Size = new System.Drawing.Size(35, 16);
            this.rdoRefreshFast1.TabIndex = 0;
            this.rdoRefreshFast1.Text = "高";
            this.rdoRefreshFast1.UseVisualStyleBackColor = true;
            this.rdoRefreshFast1.CheckedChanged += new System.EventHandler(this.rdoRefreshFast1_CheckedChanged);
            // 
            // tmrRandom
            // 
            this.tmrRandom.Enabled = true;
            this.tmrRandom.Interval = 4000;
            this.tmrRandom.Tick += new System.EventHandler(this.tmrRandom_Tick);
            // 
            // grpRefreshRate2
            // 
            this.grpRefreshRate2.Controls.Add(this.rdoRefreshSlow2);
            this.grpRefreshRate2.Controls.Add(this.rdoRefreshNormal2);
            this.grpRefreshRate2.Controls.Add(this.rdoRefreshFast2);
            this.grpRefreshRate2.Location = new System.Drawing.Point(13, 313);
            this.grpRefreshRate2.Name = "grpRefreshRate2";
            this.grpRefreshRate2.Size = new System.Drawing.Size(261, 49);
            this.grpRefreshRate2.TabIndex = 1;
            this.grpRefreshRate2.TabStop = false;
            this.grpRefreshRate2.Text = "刷新速度";
            // 
            // rdoRefreshSlow2
            // 
            this.rdoRefreshSlow2.AutoSize = true;
            this.rdoRefreshSlow2.Location = new System.Drawing.Point(101, 21);
            this.rdoRefreshSlow2.Name = "rdoRefreshSlow2";
            this.rdoRefreshSlow2.Size = new System.Drawing.Size(35, 16);
            this.rdoRefreshSlow2.TabIndex = 0;
            this.rdoRefreshSlow2.Text = "低";
            this.rdoRefreshSlow2.UseVisualStyleBackColor = true;
            this.rdoRefreshSlow2.CheckedChanged += new System.EventHandler(this.rdoRefreshSlow2_CheckedChanged);
            // 
            // rdoRefreshNormal2
            // 
            this.rdoRefreshNormal2.AutoSize = true;
            this.rdoRefreshNormal2.Checked = true;
            this.rdoRefreshNormal2.Location = new System.Drawing.Point(48, 21);
            this.rdoRefreshNormal2.Name = "rdoRefreshNormal2";
            this.rdoRefreshNormal2.Size = new System.Drawing.Size(47, 16);
            this.rdoRefreshNormal2.TabIndex = 0;
            this.rdoRefreshNormal2.TabStop = true;
            this.rdoRefreshNormal2.Text = "正常";
            this.rdoRefreshNormal2.UseVisualStyleBackColor = true;
            this.rdoRefreshNormal2.CheckedChanged += new System.EventHandler(this.rdoRefreshNormal2_CheckedChanged);
            // 
            // rdoRefreshFast2
            // 
            this.rdoRefreshFast2.AutoSize = true;
            this.rdoRefreshFast2.Location = new System.Drawing.Point(7, 21);
            this.rdoRefreshFast2.Name = "rdoRefreshFast2";
            this.rdoRefreshFast2.Size = new System.Drawing.Size(35, 16);
            this.rdoRefreshFast2.TabIndex = 0;
            this.rdoRefreshFast2.Text = "高";
            this.rdoRefreshFast2.UseVisualStyleBackColor = true;
            this.rdoRefreshFast2.CheckedChanged += new System.EventHandler(this.rdoRefreshFast2_CheckedChanged);
            // 
            // rdoEditAbove
            // 
            this.rdoEditAbove.AutoSize = true;
            this.rdoEditAbove.Checked = true;
            this.rdoEditAbove.Location = new System.Drawing.Point(280, 13);
            this.rdoEditAbove.Name = "rdoEditAbove";
            this.rdoEditAbove.Size = new System.Drawing.Size(95, 16);
            this.rdoEditAbove.TabIndex = 3;
            this.rdoEditAbove.TabStop = true;
            this.rdoEditAbove.Text = "波形图（上）";
            this.rdoEditAbove.UseVisualStyleBackColor = true;
            this.rdoEditAbove.CheckedChanged += new System.EventHandler(this.rdoEditAbove_CheckedChanged);
            // 
            // rdoEditBelow
            // 
            this.rdoEditBelow.AutoSize = true;
            this.rdoEditBelow.Location = new System.Drawing.Point(508, 13);
            this.rdoEditBelow.Name = "rdoEditBelow";
            this.rdoEditBelow.Size = new System.Drawing.Size(95, 16);
            this.rdoEditBelow.TabIndex = 3;
            this.rdoEditBelow.Text = "波形图（下）";
            this.rdoEditBelow.UseVisualStyleBackColor = true;
            this.rdoEditBelow.CheckedChanged += new System.EventHandler(this.rdoEditBelow_CheckedChanged);
            // 
            // pgdSC
            // 
            this.pgdSC.Location = new System.Drawing.Point(280, 44);
            this.pgdSC.Name = "pgdSC";
            this.pgdSC.SelectedObject = this.nsc1;
            this.pgdSC.Size = new System.Drawing.Size(324, 262);
            this.pgdSC.TabIndex = 2;
            // 
            // nsc1
            // 
            this.nsc1.BackColor = System.Drawing.Color.Black;
            this.nsc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nsc1.Enabled = false;
            this.nsc1.Interval = 2000;
            this.nsc1.Location = new System.Drawing.Point(12, 12);
            this.nsc1.Mode = UI.StatusChart.ChartMode.Waveform;
            this.nsc1.Name = "nsc1";
            this.nsc1.Size = new System.Drawing.Size(262, 116);
            this.nsc1.TabIndex = 0;
            this.nsc1.Value = 36;
            // 
            // nsc2
            // 
            this.nsc2.BackColor = System.Drawing.Color.Black;
            this.nsc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nsc2.Enabled = false;
            this.nsc2.Interval = 2000;
            this.nsc2.Location = new System.Drawing.Point(12, 190);
            this.nsc2.Name = "nsc2";
            this.nsc2.Size = new System.Drawing.Size(262, 116);
            this.nsc2.TabIndex = 0;
            this.nsc2.Value = 42;
            // 
            // nscDemo3
            // 
            this.nscDemo3.BackColor = System.Drawing.Color.White;
            this.nscDemo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nscDemo3.Enabled = false;
            this.nscDemo3.ForeColor = System.Drawing.Color.Red;
            this.nscDemo3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nscDemo3.GridShiftting = false;
            this.nscDemo3.GridWidth = 0;
            this.nscDemo3.Interval = 2000;
            this.nscDemo3.Location = new System.Drawing.Point(500, 313);
            this.nscDemo3.Mode = UI.StatusChart.ChartMode.Waveform;
            this.nscDemo3.Name = "nscDemo3";
            this.nscDemo3.Range = 10;
            this.nscDemo3.Size = new System.Drawing.Size(104, 49);
            this.nscDemo3.TabIndex = 0;
            this.nscDemo3.Value = 45;
            // 
            // nscDemo2
            // 
            this.nscDemo2.BackColor = System.Drawing.Color.Black;
            this.nscDemo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nscDemo2.Enabled = false;
            this.nscDemo2.ForeColor = System.Drawing.Color.SteelBlue;
            this.nscDemo2.GridColor = System.Drawing.Color.Black;
            this.nscDemo2.Interval = 2000;
            this.nscDemo2.Location = new System.Drawing.Point(390, 313);
            this.nscDemo2.Name = "nscDemo2";
            this.nscDemo2.Range = 10;
            this.nscDemo2.Size = new System.Drawing.Size(104, 49);
            this.nscDemo2.TabIndex = 0;
            this.nscDemo2.Value = 45;
            // 
            // nscDemo1
            // 
            this.nscDemo1.BackColor = System.Drawing.Color.Black;
            this.nscDemo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nscDemo1.Enabled = false;
            this.nscDemo1.ForeColor = System.Drawing.Color.Yellow;
            this.nscDemo1.GridColor = System.Drawing.Color.DimGray;
            this.nscDemo1.Interval = 2000;
            this.nscDemo1.Location = new System.Drawing.Point(280, 313);
            this.nscDemo1.Mode = UI.StatusChart.ChartMode.Waveform;
            this.nscDemo1.Name = "nscDemo1";
            this.nscDemo1.Range = 10;
            this.nscDemo1.Size = new System.Drawing.Size(104, 49);
            this.nscDemo1.TabIndex = 0;
            this.nscDemo1.Value = 45;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 372);
            this.Controls.Add(this.rdoEditBelow);
            this.Controls.Add(this.rdoEditAbove);
            this.Controls.Add(this.pgdSC);
            this.Controls.Add(this.grpRefreshRate2);
            this.Controls.Add(this.grpRefreshRate1);
            this.Controls.Add(this.nsc2);
            this.Controls.Add(this.nscDemo3);
            this.Controls.Add(this.nscDemo2);
            this.Controls.Add(this.nscDemo1);
            this.Controls.Add(this.nsc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "野比的状态波形图控件演示";
            this.grpRefreshRate1.ResumeLayout(false);
            this.grpRefreshRate1.PerformLayout();
            this.grpRefreshRate2.ResumeLayout(false);
            this.grpRefreshRate2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.StatusChart nsc1;
        private System.Windows.Forms.GroupBox grpRefreshRate1;
        private System.Windows.Forms.RadioButton rdoRefreshSlow1;
        private System.Windows.Forms.RadioButton rdoRefreshNormal1;
        private System.Windows.Forms.RadioButton rdoRefreshFast1;
        private System.Windows.Forms.Timer tmrRandom;
        private UI.StatusChart nsc2;
        private System.Windows.Forms.GroupBox grpRefreshRate2;
        private System.Windows.Forms.RadioButton rdoRefreshSlow2;
        private System.Windows.Forms.RadioButton rdoRefreshNormal2;
        private System.Windows.Forms.RadioButton rdoRefreshFast2;
        private System.Windows.Forms.PropertyGrid pgdSC;
        private System.Windows.Forms.RadioButton rdoEditAbove;
        private System.Windows.Forms.RadioButton rdoEditBelow;
        private UI.StatusChart nscDemo1;
        private UI.StatusChart nscDemo2;
        private UI.StatusChart nscDemo3;
    }
}

