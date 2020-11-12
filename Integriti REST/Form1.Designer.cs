namespace Integriti_REST
{
    partial class frmMain
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
            if (disposing && (components != null)) {
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btn_Url = new System.Windows.Forms.Button();
            this.tbXml = new System.Windows.Forms.TextBox();
            this.btnXmlFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(100, 20);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.Text = "http://127.0.0.1/";
            // 
            // btn_Url
            // 
            this.btn_Url.Location = new System.Drawing.Point(118, 12);
            this.btn_Url.Name = "btn_Url";
            this.btn_Url.Size = new System.Drawing.Size(56, 23);
            this.btn_Url.TabIndex = 1;
            this.btn_Url.Text = "Set IP";
            this.btn_Url.UseVisualStyleBackColor = true;
            this.btn_Url.Click += new System.EventHandler(this.btnUrl_click);
            // 
            // tbXml
            // 
            this.tbXml.Location = new System.Drawing.Point(12, 41);
            this.tbXml.Multiline = true;
            this.tbXml.Name = "tbXml";
            this.tbXml.Size = new System.Drawing.Size(324, 251);
            this.tbXml.TabIndex = 2;
            // 
            // btnXmlFromFile
            // 
            this.btnXmlFromFile.Location = new System.Drawing.Point(12, 298);
            this.btnXmlFromFile.Name = "btnXmlFromFile";
            this.btnXmlFromFile.Size = new System.Drawing.Size(100, 23);
            this.btnXmlFromFile.TabIndex = 3;
            this.btnXmlFromFile.Text = "Load From File";
            this.btnXmlFromFile.UseVisualStyleBackColor = true;
            this.btnXmlFromFile.Click += new System.EventHandler(this.btnXmlFromFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 498);
            this.Controls.Add(this.btnXmlFromFile);
            this.Controls.Add(this.tbXml);
            this.Controls.Add(this.btn_Url);
            this.Controls.Add(this.tbUrl);
            this.Name = "frmMain";
            this.Text = "Integriti REST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btn_Url;
        private System.Windows.Forms.TextBox tbXml;
        private System.Windows.Forms.Button btnXmlFromFile;
    }
}

