namespace Quota_Calculator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabJobs = new System.Windows.Forms.TabControl();
            this.tblQuotaChart = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage1.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblQuotaChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabJobs
            // 
            this.tabJobs.Controls.Add(this.tabPage1);
            this.tabJobs.Location = new System.Drawing.Point(175, 35);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.SelectedIndex = 0;
            this.tabJobs.Size = new System.Drawing.Size(599, 515);
            this.tabJobs.TabIndex = 0;
            // 
            // tblQuotaChart
            // 
            this.tblQuotaChart.AutoScroll = true;
            this.tblQuotaChart.BackColor = System.Drawing.Color.Gainsboro;
            this.tblQuotaChart.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblQuotaChart.ColumnCount = 4;
            this.tblQuotaChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblQuotaChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblQuotaChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblQuotaChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblQuotaChart.Location = new System.Drawing.Point(3, 32);
            this.tblQuotaChart.Name = "tblQuotaChart";
            this.tblQuotaChart.RowCount = 1;
            this.tblQuotaChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQuotaChart.Size = new System.Drawing.Size(579, 54);
            this.tblQuotaChart.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 611);
            this.Controls.Add(this.tabJobs);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabJobs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabJobs;
        private System.Windows.Forms.TableLayoutPanel tblQuotaChart;
    }
}

