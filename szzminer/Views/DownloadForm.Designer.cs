﻿
using Sunny.UI;

namespace szzminer.Views
{
    partial class DownloadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.labelDescription = new Sunny.UI.UILabel();
            this.processBar = new Sunny.UI.UIProcessBar();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelDescription.Location = new System.Drawing.Point(32, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(198, 21);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "正在下载内核中，请稍候...";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processBar
            // 
            this.processBar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.processBar.Location = new System.Drawing.Point(32, 91);
            this.processBar.MinimumSize = new System.Drawing.Size(70, 23);
            this.processBar.Name = "processBar";
            this.processBar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.processBar.Size = new System.Drawing.Size(409, 29);
            this.processBar.TabIndex = 3;
            this.processBar.Text = "0.0%";
            this.processBar.ValueChanged += new Sunny.UI.UIProcessBar.OnValueChanged(this.processBar_ValueChanged);
            // 
            // DownloadForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(473, 153);
            this.ControlBox = false;
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.labelDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadForm";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "松之宅矿工";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            this.Shown += new System.EventHandler(this.DownloadForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UILabel labelDescription;
        private UIProcessBar processBar;
    }
}