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
            this.btnAddSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchPaths
            // 
            this.txtSearchPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPaths.Location = new System.Drawing.Point(12, 12);
            this.txtSearchPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchPaths.Multiline = true;
            this.txtSearchPaths.Name = "txtSearchPaths";
            this.txtSearchPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchPaths.Size = new System.Drawing.Size(889, 154);
            this.txtSearchPaths.TabIndex = 0;
            this.txtSearchPaths.WordWrap = false;
            // 
            // txtOutputSvnPaths
            // 
            this.txtOutputSvnPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputSvnPaths.Location = new System.Drawing.Point(12, 238);
            this.txtOutputSvnPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputSvnPaths.Multiline = true;
            this.txtOutputSvnPaths.Name = "txtOutputSvnPaths";
            this.txtOutputSvnPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputSvnPaths.Size = new System.Drawing.Size(889, 504);
            this.txtOutputSvnPaths.TabIndex = 1;
            this.txtOutputSvnPaths.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(927, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIgnore
            // 
            this.txtIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgnore.Location = new System.Drawing.Point(59, 186);
            this.txtIgnore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(843, 25);
            this.txtIgnore.TabIndex = 4;
            this.txtIgnore.Text = "*.dll;*.lib;*.so;*.a;*.pdb;*.exe;*.log";
            // 
            // btnIgnoreFilter
            // 
            this.btnIgnoreFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnoreFilter.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIgnoreFilter.Location = new System.Drawing.Point(927, 178);
            this.btnIgnoreFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIgnoreFilter.Name = "btnIgnoreFilter";
            this.btnIgnoreFilter.Size = new System.Drawing.Size(121, 40);
            this.btnIgnoreFilter.TabIndex = 6;
            this.btnIgnoreFilter.Text = "过滤";
            this.btnIgnoreFilter.UseVisualStyleBackColor = true;
            this.btnIgnoreFilter.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "忽略";
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBrowser.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(927, 265);
            this.btnOpenBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(121, 40);
            this.btnOpenBrowser.TabIndex = 8;
            this.btnOpenBrowser.Text = "创建提交单";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSearch.Location = new System.Drawing.Point(927, 12);
            this.btnAddSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(121, 40);
            this.btnAddSearch.TabIndex = 9;
            this.btnAddSearch.Text = "...";
            this.btnAddSearch.UseVisualStyleBackColor = true;
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearSearch.Location = new System.Drawing.Point(927, 58);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(121, 40);
            this.btnClearSearch.TabIndex = 10;
            this.btnClearSearch.Text = "清空";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 754);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnAddSearch);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgnoreFilter);
            this.Controls.Add(this.txtIgnore);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOutputSvnPaths);
            this.Controls.Add(this.txtSearchPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FmMain";
            this.Text = "Jx3SvnCommiterUI                   yefan1@kingsoft.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMain_FormClosing);
            this.Load += new System.EventHandler(this.FmMain_Load);
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
        private System.Windows.Forms.Button btnAddSearch;
        private System.Windows.Forms.Button btnClearSearch;
    }
}

