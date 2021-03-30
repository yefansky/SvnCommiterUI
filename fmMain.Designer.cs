namespace SvnCommiterUI
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.txtSearchPaths = new System.Windows.Forms.TextBox();
            this.txtOutputSvnPaths = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIgnore = new System.Windows.Forms.TextBox();
            this.btnIgnoreFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchPaths
            // 
            this.txtSearchPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPaths.Location = new System.Drawing.Point(9, 10);
            this.txtSearchPaths.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPaths.Multiline = true;
            this.txtSearchPaths.Name = "txtSearchPaths";
            this.txtSearchPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchPaths.Size = new System.Drawing.Size(513, 124);
            this.txtSearchPaths.TabIndex = 0;
            this.txtSearchPaths.WordWrap = false;
            // 
            // txtOutputSvnPaths
            // 
            this.txtOutputSvnPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputSvnPaths.Location = new System.Drawing.Point(9, 190);
            this.txtOutputSvnPaths.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputSvnPaths.Multiline = true;
            this.txtOutputSvnPaths.Name = "txtOutputSvnPaths";
            this.txtOutputSvnPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputSvnPaths.Size = new System.Drawing.Size(513, 404);
            this.txtOutputSvnPaths.TabIndex = 1;
            this.txtOutputSvnPaths.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(540, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIgnore
            // 
            this.txtIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgnore.Location = new System.Drawing.Point(44, 149);
            this.txtIgnore.Margin = new System.Windows.Forms.Padding(2);
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(478, 21);
            this.txtIgnore.TabIndex = 4;
            this.txtIgnore.Text = "*.dll;*.lib;*.so;*.a;*.pdb;*.exe;*.log";
            // 
            // btnIgnoreFilter
            // 
            this.btnIgnoreFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnoreFilter.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIgnoreFilter.Location = new System.Drawing.Point(540, 142);
            this.btnIgnoreFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnIgnoreFilter.Name = "btnIgnoreFilter";
            this.btnIgnoreFilter.Size = new System.Drawing.Size(91, 32);
            this.btnIgnoreFilter.TabIndex = 6;
            this.btnIgnoreFilter.Text = "过滤";
            this.btnIgnoreFilter.UseVisualStyleBackColor = true;
            this.btnIgnoreFilter.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "忽略";
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBrowser.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(540, 212);
            this.btnOpenBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(91, 32);
            this.btnOpenBrowser.TabIndex = 8;
            this.btnOpenBrowser.Text = "创建提交单";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 603);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgnoreFilter);
            this.Controls.Add(this.txtIgnore);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOutputSvnPaths);
            this.Controls.Add(this.txtSearchPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmMain";
            this.Text = "Jx3SvnCommiterUI                   yefan1@kingsoft.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPaths;
        private System.Windows.Forms.TextBox txtOutputSvnPaths;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIgnore;
        private System.Windows.Forms.Button btnIgnoreFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenBrowser;
    }
}

