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
            this.btnPostXml = new System.Windows.Forms.Button();
            this.tbXmlResult = new System.Windows.Forms.TextBox();
            this.gbTriggerInput = new System.Windows.Forms.GroupBox();
            this.tbTriggerInputInputID = new System.Windows.Forms.Label();
            this.lblTriggerInputControllerID = new System.Windows.Forms.Label();
            this.tbControlInputControllerID = new System.Windows.Forms.TextBox();
            this.tbControlInputInputID = new System.Windows.Forms.TextBox();
            this.cbControlInputState = new System.Windows.Forms.ComboBox();
            this.btnControlInputSend = new System.Windows.Forms.Button();
            this.gbTriggerInput.SuspendLayout();
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
            this.btnXmlFromFile.Location = new System.Drawing.Point(155, 298);
            this.btnXmlFromFile.Name = "btnXmlFromFile";
            this.btnXmlFromFile.Size = new System.Drawing.Size(100, 23);
            this.btnXmlFromFile.TabIndex = 3;
            this.btnXmlFromFile.Text = "Load From File";
            this.btnXmlFromFile.UseVisualStyleBackColor = true;
            this.btnXmlFromFile.Click += new System.EventHandler(this.btnXmlFromFile_Click);
            // 
            // btnPostXml
            // 
            this.btnPostXml.Location = new System.Drawing.Point(261, 298);
            this.btnPostXml.Name = "btnPostXml";
            this.btnPostXml.Size = new System.Drawing.Size(75, 23);
            this.btnPostXml.TabIndex = 4;
            this.btnPostXml.Text = "Post XML";
            this.btnPostXml.UseVisualStyleBackColor = true;
            this.btnPostXml.Click += new System.EventHandler(this.btnPostXml_Click);
            // 
            // tbXmlResult
            // 
            this.tbXmlResult.Location = new System.Drawing.Point(12, 327);
            this.tbXmlResult.Multiline = true;
            this.tbXmlResult.Name = "tbXmlResult";
            this.tbXmlResult.ReadOnly = true;
            this.tbXmlResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXmlResult.Size = new System.Drawing.Size(708, 159);
            this.tbXmlResult.TabIndex = 5;
            this.tbXmlResult.WordWrap = false;
            // 
            // gbTriggerInput
            // 
            this.gbTriggerInput.Controls.Add(this.btnControlInputSend);
            this.gbTriggerInput.Controls.Add(this.cbControlInputState);
            this.gbTriggerInput.Controls.Add(this.tbControlInputInputID);
            this.gbTriggerInput.Controls.Add(this.tbControlInputControllerID);
            this.gbTriggerInput.Controls.Add(this.tbTriggerInputInputID);
            this.gbTriggerInput.Controls.Add(this.lblTriggerInputControllerID);
            this.gbTriggerInput.Location = new System.Drawing.Point(342, 12);
            this.gbTriggerInput.Name = "gbTriggerInput";
            this.gbTriggerInput.Size = new System.Drawing.Size(158, 135);
            this.gbTriggerInput.TabIndex = 6;
            this.gbTriggerInput.TabStop = false;
            this.gbTriggerInput.Text = "Control Input";
            // 
            // tbTriggerInputInputID
            // 
            this.tbTriggerInputInputID.AutoSize = true;
            this.tbTriggerInputInputID.Location = new System.Drawing.Point(27, 50);
            this.tbTriggerInputInputID.Name = "tbTriggerInputInputID";
            this.tbTriggerInputInputID.Size = new System.Drawing.Size(45, 13);
            this.tbTriggerInputInputID.TabIndex = 1;
            this.tbTriggerInputInputID.Text = "Input ID";
            // 
            // lblTriggerInputControllerID
            // 
            this.lblTriggerInputControllerID.AutoSize = true;
            this.lblTriggerInputControllerID.Location = new System.Drawing.Point(7, 24);
            this.lblTriggerInputControllerID.Name = "lblTriggerInputControllerID";
            this.lblTriggerInputControllerID.Size = new System.Drawing.Size(65, 13);
            this.lblTriggerInputControllerID.TabIndex = 0;
            this.lblTriggerInputControllerID.Text = "Controller ID";
            // 
            // tbControlInputControllerID
            // 
            this.tbControlInputControllerID.Location = new System.Drawing.Point(78, 17);
            this.tbControlInputControllerID.Name = "tbControlInputControllerID";
            this.tbControlInputControllerID.Size = new System.Drawing.Size(74, 20);
            this.tbControlInputControllerID.TabIndex = 1;
            // 
            // tbControlInputInputID
            // 
            this.tbControlInputInputID.Location = new System.Drawing.Point(78, 43);
            this.tbControlInputInputID.Name = "tbControlInputInputID";
            this.tbControlInputInputID.Size = new System.Drawing.Size(74, 20);
            this.tbControlInputInputID.TabIndex = 2;
            // 
            // cbControlInputState
            // 
            this.cbControlInputState.FormattingEnabled = true;
            this.cbControlInputState.Items.AddRange(new object[] {
            "Alarm",
            "Restore"});
            this.cbControlInputState.Location = new System.Drawing.Point(78, 69);
            this.cbControlInputState.MaxDropDownItems = 2;
            this.cbControlInputState.Name = "cbControlInputState";
            this.cbControlInputState.Size = new System.Drawing.Size(74, 21);
            this.cbControlInputState.TabIndex = 3;
            // 
            // btnControlInputSend
            // 
            this.btnControlInputSend.Location = new System.Drawing.Point(35, 96);
            this.btnControlInputSend.Name = "btnControlInputSend";
            this.btnControlInputSend.Size = new System.Drawing.Size(75, 23);
            this.btnControlInputSend.TabIndex = 4;
            this.btnControlInputSend.Text = "Send";
            this.btnControlInputSend.UseVisualStyleBackColor = true;
            this.btnControlInputSend.Click += new System.EventHandler(this.btnControlInputSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 498);
            this.Controls.Add(this.gbTriggerInput);
            this.Controls.Add(this.tbXmlResult);
            this.Controls.Add(this.btnPostXml);
            this.Controls.Add(this.btnXmlFromFile);
            this.Controls.Add(this.tbXml);
            this.Controls.Add(this.btn_Url);
            this.Controls.Add(this.tbUrl);
            this.Name = "frmMain";
            this.Text = "Integriti REST";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbTriggerInput.ResumeLayout(false);
            this.gbTriggerInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btn_Url;
        private System.Windows.Forms.TextBox tbXml;
        private System.Windows.Forms.Button btnXmlFromFile;
        private System.Windows.Forms.Button btnPostXml;
        private System.Windows.Forms.TextBox tbXmlResult;
        private System.Windows.Forms.GroupBox gbTriggerInput;
        private System.Windows.Forms.Label tbTriggerInputInputID;
        private System.Windows.Forms.Label lblTriggerInputControllerID;
        private System.Windows.Forms.TextBox tbControlInputControllerID;
        private System.Windows.Forms.TextBox tbControlInputInputID;
        private System.Windows.Forms.ComboBox cbControlInputState;
        private System.Windows.Forms.Button btnControlInputSend;
    }
}

