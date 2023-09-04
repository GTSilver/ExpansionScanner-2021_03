namespace Scaner_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.Start_B = new System.Windows.Forms.Button();
            this.BrowseInput_B = new System.Windows.Forms.Button();
            this.Stop_B = new System.Windows.Forms.Button();
            this.Desine_L1 = new System.Windows.Forms.Label();
            this.Desine_L2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Size_L = new System.Windows.Forms.Label();
            this.Folders_L = new System.Windows.Forms.Label();
            this.Files_L = new System.Windows.Forms.Label();
            this.Desine_L6 = new System.Windows.Forms.Label();
            this.Desine_L3 = new System.Windows.Forms.Label();
            this.Desine_L7 = new System.Windows.Forms.Label();
            this.Time_L = new System.Windows.Forms.Label();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.Extension_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_TB
            // 
            this.Input_TB.Location = new System.Drawing.Point(84, 6);
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.Size = new System.Drawing.Size(243, 20);
            this.Input_TB.TabIndex = 0;
            this.Input_TB.Text = "C:\\";
            this.Input_TB.TextChanged += new System.EventHandler(this.Input_TB_TextChanged);
            // 
            // Start_B
            // 
            this.Start_B.Location = new System.Drawing.Point(125, 80);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(98, 23);
            this.Start_B.TabIndex = 2;
            this.Start_B.Text = "Start";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // BrowseInput_B
            // 
            this.BrowseInput_B.Location = new System.Drawing.Point(229, 32);
            this.BrowseInput_B.Name = "BrowseInput_B";
            this.BrowseInput_B.Size = new System.Drawing.Size(98, 23);
            this.BrowseInput_B.TabIndex = 4;
            this.BrowseInput_B.Text = "Open";
            this.BrowseInput_B.UseVisualStyleBackColor = true;
            this.BrowseInput_B.Click += new System.EventHandler(this.BrowseInput_B_Click);
            // 
            // Stop_B
            // 
            this.Stop_B.Enabled = false;
            this.Stop_B.Location = new System.Drawing.Point(229, 80);
            this.Stop_B.Name = "Stop_B";
            this.Stop_B.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Stop_B.Size = new System.Drawing.Size(98, 23);
            this.Stop_B.TabIndex = 14;
            this.Stop_B.Text = "Stop";
            this.Stop_B.UseVisualStyleBackColor = true;
            this.Stop_B.Click += new System.EventHandler(this.Stop_B_Click);
            // 
            // Desine_L1
            // 
            this.Desine_L1.AutoSize = true;
            this.Desine_L1.Location = new System.Drawing.Point(6, 16);
            this.Desine_L1.Name = "Desine_L1";
            this.Desine_L1.Size = new System.Drawing.Size(31, 13);
            this.Desine_L1.TabIndex = 15;
            this.Desine_L1.Text = "Files:";
            // 
            // Desine_L2
            // 
            this.Desine_L2.AutoSize = true;
            this.Desine_L2.Location = new System.Drawing.Point(6, 32);
            this.Desine_L2.Name = "Desine_L2";
            this.Desine_L2.Size = new System.Drawing.Size(44, 13);
            this.Desine_L2.TabIndex = 16;
            this.Desine_L2.Text = "Folders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Size_L);
            this.groupBox2.Controls.Add(this.Folders_L);
            this.groupBox2.Controls.Add(this.Files_L);
            this.groupBox2.Controls.Add(this.Desine_L6);
            this.groupBox2.Controls.Add(this.Desine_L2);
            this.groupBox2.Controls.Add(this.Desine_L1);
            this.groupBox2.Location = new System.Drawing.Point(11, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scanned items";
            // 
            // Size_L
            // 
            this.Size_L.AutoSize = true;
            this.Size_L.Location = new System.Drawing.Point(55, 48);
            this.Size_L.Name = "Size_L";
            this.Size_L.Size = new System.Drawing.Size(13, 13);
            this.Size_L.TabIndex = 20;
            this.Size_L.Text = "0";
            // 
            // Folders_L
            // 
            this.Folders_L.AutoSize = true;
            this.Folders_L.Location = new System.Drawing.Point(55, 32);
            this.Folders_L.Name = "Folders_L";
            this.Folders_L.Size = new System.Drawing.Size(13, 13);
            this.Folders_L.TabIndex = 18;
            this.Folders_L.Text = "0";
            // 
            // Files_L
            // 
            this.Files_L.AutoSize = true;
            this.Files_L.Location = new System.Drawing.Point(55, 16);
            this.Files_L.Name = "Files_L";
            this.Files_L.Size = new System.Drawing.Size(13, 13);
            this.Files_L.TabIndex = 17;
            this.Files_L.Text = "0";
            // 
            // Desine_L6
            // 
            this.Desine_L6.AutoSize = true;
            this.Desine_L6.Location = new System.Drawing.Point(6, 48);
            this.Desine_L6.Name = "Desine_L6";
            this.Desine_L6.Size = new System.Drawing.Size(54, 13);
            this.Desine_L6.TabIndex = 19;
            this.Desine_L6.Text = "Size (Mb):";
            // 
            // Desine_L3
            // 
            this.Desine_L3.AutoSize = true;
            this.Desine_L3.Location = new System.Drawing.Point(12, 9);
            this.Desine_L3.Name = "Desine_L3";
            this.Desine_L3.Size = new System.Drawing.Size(61, 13);
            this.Desine_L3.TabIndex = 19;
            this.Desine_L3.Text = "Scan folder";
            // 
            // Desine_L7
            // 
            this.Desine_L7.AutoSize = true;
            this.Desine_L7.Location = new System.Drawing.Point(125, 37);
            this.Desine_L7.Name = "Desine_L7";
            this.Desine_L7.Size = new System.Drawing.Size(33, 13);
            this.Desine_L7.TabIndex = 21;
            this.Desine_L7.Text = "Time:";
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Location = new System.Drawing.Point(153, 37);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(70, 13);
            this.Time_L.TabIndex = 21;
            this.Time_L.Text = "00:00:00.000";
            // 
            // Result_DGV
            // 
            this.Result_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extension_C,
            this.Size_C,
            this.Percent_C});
            this.Result_DGV.Location = new System.Drawing.Point(11, 109);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.RowHeadersVisible = false;
            this.Result_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Result_DGV.ShowCellErrors = false;
            this.Result_DGV.ShowCellToolTips = false;
            this.Result_DGV.ShowEditingIcon = false;
            this.Result_DGV.ShowRowErrors = false;
            this.Result_DGV.Size = new System.Drawing.Size(316, 198);
            this.Result_DGV.TabIndex = 22;
            // 
            // Extension_C
            // 
            this.Extension_C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Extension_C.Frozen = true;
            this.Extension_C.HeaderText = "Extension";
            this.Extension_C.Name = "Extension_C";
            this.Extension_C.ReadOnly = true;
            this.Extension_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Extension_C.Width = 128;
            // 
            // Size_C
            // 
            this.Size_C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Size_C.HeaderText = "Size";
            this.Size_C.Name = "Size_C";
            this.Size_C.ReadOnly = true;
            this.Size_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Size_C.Width = 80;
            // 
            // Percent_C
            // 
            this.Percent_C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Percent_C.HeaderText = "Percent, %";
            this.Percent_C.Name = "Percent_C";
            this.Percent_C.ReadOnly = true;
            this.Percent_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Percent_C.Width = 88;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 331);
            this.Controls.Add(this.Result_DGV);
            this.Controls.Add(this.Time_L);
            this.Controls.Add(this.Desine_L7);
            this.Controls.Add(this.Desine_L3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Stop_B);
            this.Controls.Add(this.BrowseInput_B);
            this.Controls.Add(this.Start_B);
            this.Controls.Add(this.Input_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Extension scanner";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_TB;
        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.Button BrowseInput_B;
        private System.Windows.Forms.Button Stop_B;
        private System.Windows.Forms.Label Desine_L1;
        private System.Windows.Forms.Label Desine_L2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Folders_L;
        private System.Windows.Forms.Label Files_L;
        private System.Windows.Forms.Label Desine_L3;
        private System.Windows.Forms.Label Size_L;
        private System.Windows.Forms.Label Desine_L6;
        private System.Windows.Forms.Label Desine_L7;
        private System.Windows.Forms.Label Time_L;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_C;
    }
}

