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
            this.txtSearchPaths.Location = new System.Drawing.Point(12, 12);
            this.txtSearchPaths.Multiline = true;
            this.txtSearchPaths.Name = "txtSearchPaths";
            this.txtSearchPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchPaths.Size = new System.Drawing.Size(683, 154);
            this.txtSearchPaths.TabIndex = 0;
            this.txtSearchPaths.WordWrap = false;
            // 
            // txtOutputSvnPaths
            // 
            this.txtOutputSvnPaths.Location = new System.Drawing.Point(12, 238);
            this.txtOutputSvnPaths.Multiline = true;
            this.txtOutputSvnPaths.Name = "txtOutputSvnPaths";
            this.txtOutputSvnPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputSvnPaths.Size = new System.Drawing.Size(683, 504);
            this.txtOutputSvnPaths.TabIndex = 1;
            this.txtOutputSvnPaths.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(720, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIgnore
            // 
            this.txtIgnore.Location = new System.Drawing.Point(139, 186);
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(556, 25);
            this.txtIgnore.TabIndex = 4;
            this.txtIgnore.Text = "*.dll;*.lib;*.so;*.pdb;*.exe";
            // 
            // btnIgnoreFilter
            // 
            this.btnIgnoreFilter.Location = new System.Drawing.Point(720, 176);
            this.btnIgnoreFilter.Name = "btnIgnoreFilter";
            this.btnIgnoreFilter.Size = new System.Drawing.Size(103, 40);
            this.btnIgnoreFilter.TabIndex = 6;
            this.btnIgnoreFilter.Text = "filter";
            this.btnIgnoreFilter.UseVisualStyleBackColor = true;
            this.btnIgnoreFilter.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ignore";
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(720, 265);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(103, 40);
            this.btnOpenBrowser.TabIndex = 8;
            this.btnOpenBrowser.Text = "browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 754);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgnoreFilter);
            this.Controls.Add(this.txtIgnore);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOutputSvnPaths);
            this.Controls.Add(this.txtSearchPaths);
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

