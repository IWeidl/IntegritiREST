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
            this.btnSet = new System.Windows.Forms.Button();
            this.tbXml = new System.Windows.Forms.TextBox();
            this.btnXmlFromFile = new System.Windows.Forms.Button();
            this.btnPostXml = new System.Windows.Forms.Button();
            this.tbXmlResult = new System.Windows.Forms.TextBox();
            this.gbTriggerInput = new System.Windows.Forms.GroupBox();
            this.btnControlInputSend = new System.Windows.Forms.Button();
            this.cbControlInputState = new System.Windows.Forms.ComboBox();
            this.tbControlInputInputID = new System.Windows.Forms.TextBox();
            this.tbTriggerInputInputID = new System.Windows.Forms.Label();
            this.lblControllerID = new System.Windows.Forms.Label();
            this.tbControllerID = new System.Windows.Forms.TextBox();
            this.gbControlArea = new System.Windows.Forms.GroupBox();
            this.btnControlAreaSend = new System.Windows.Forms.Button();
            this.cbControlAreaState = new System.Windows.Forms.ComboBox();
            this.tbControlAreaAreaID = new System.Windows.Forms.TextBox();
            this.lblControlAreaAreaID = new System.Windows.Forms.Label();
            this.cbXmlSamples = new System.Windows.Forms.ComboBox();
            this.gbControlAux = new System.Windows.Forms.GroupBox();
            this.btnControlAuxSend = new System.Windows.Forms.Button();
            this.cbControlAuxState = new System.Windows.Forms.ComboBox();
            this.tbControlAuxAuxID = new System.Windows.Forms.TextBox();
            this.lblControlAuxAuxID = new System.Windows.Forms.Label();
            this.gbTriggerInput.SuspendLayout();
            this.gbControlArea.SuspendLayout();
            this.gbControlAux.SuspendLayout();
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
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(269, 9);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(56, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
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
            this.gbTriggerInput.Controls.Add(this.tbTriggerInputInputID);
            this.gbTriggerInput.Location = new System.Drawing.Point(342, 12);
            this.gbTriggerInput.Name = "gbTriggerInput";
            this.gbTriggerInput.Size = new System.Drawing.Size(143, 116);
            this.gbTriggerInput.TabIndex = 6;
            this.gbTriggerInput.TabStop = false;
            this.gbTriggerInput.Text = "Control Input";
            // 
            // btnControlInputSend
            // 
            this.btnControlInputSend.Location = new System.Drawing.Point(57, 79);
            this.btnControlInputSend.Name = "btnControlInputSend";
            this.btnControlInputSend.Size = new System.Drawing.Size(75, 23);
            this.btnControlInputSend.TabIndex = 4;
            this.btnControlInputSend.Text = "Send";
            this.btnControlInputSend.UseVisualStyleBackColor = true;
            this.btnControlInputSend.Click += new System.EventHandler(this.btnControlInputSend_Click);
            // 
            // cbControlInputState
            // 
            this.cbControlInputState.FormattingEnabled = true;
            this.cbControlInputState.Items.AddRange(new object[] {
            "Alarm",
            "Restore"});
            this.cbControlInputState.Location = new System.Drawing.Point(57, 52);
            this.cbControlInputState.MaxDropDownItems = 2;
            this.cbControlInputState.Name = "cbControlInputState";
            this.cbControlInputState.Size = new System.Drawing.Size(74, 21);
            this.cbControlInputState.TabIndex = 3;
            // 
            // tbControlInputInputID
            // 
            this.tbControlInputInputID.Location = new System.Drawing.Point(57, 26);
            this.tbControlInputInputID.Name = "tbControlInputInputID";
            this.tbControlInputInputID.Size = new System.Drawing.Size(74, 20);
            this.tbControlInputInputID.TabIndex = 2;
            // 
            // tbTriggerInputInputID
            // 
            this.tbTriggerInputInputID.AutoSize = true;
            this.tbTriggerInputInputID.Location = new System.Drawing.Point(6, 29);
            this.tbTriggerInputInputID.Name = "tbTriggerInputInputID";
            this.tbTriggerInputInputID.Size = new System.Drawing.Size(45, 13);
            this.tbTriggerInputInputID.TabIndex = 1;
            this.tbTriggerInputInputID.Text = "Input ID";
            // 
            // lblControllerID
            // 
            this.lblControllerID.AutoSize = true;
            this.lblControllerID.Location = new System.Drawing.Point(118, 15);
            this.lblControllerID.Name = "lblControllerID";
            this.lblControllerID.Size = new System.Drawing.Size(65, 13);
            this.lblControllerID.TabIndex = 0;
            this.lblControllerID.Text = "Controller ID";
            // 
            // tbControllerID
            // 
            this.tbControllerID.Location = new System.Drawing.Point(189, 12);
            this.tbControllerID.Name = "tbControllerID";
            this.tbControllerID.Size = new System.Drawing.Size(74, 20);
            this.tbControllerID.TabIndex = 1;
            // 
            // gbControlArea
            // 
            this.gbControlArea.Controls.Add(this.btnControlAreaSend);
            this.gbControlArea.Controls.Add(this.cbControlAreaState);
            this.gbControlArea.Controls.Add(this.tbControlAreaAreaID);
            this.gbControlArea.Controls.Add(this.lblControlAreaAreaID);
            this.gbControlArea.Location = new System.Drawing.Point(342, 134);
            this.gbControlArea.Name = "gbControlArea";
            this.gbControlArea.Size = new System.Drawing.Size(143, 116);
            this.gbControlArea.TabIndex = 6;
            this.gbControlArea.TabStop = false;
            this.gbControlArea.Text = "Control Area";
            // 
            // btnControlAreaSend
            // 
            this.btnControlAreaSend.Location = new System.Drawing.Point(57, 79);
            this.btnControlAreaSend.Name = "btnControlAreaSend";
            this.btnControlAreaSend.Size = new System.Drawing.Size(75, 23);
            this.btnControlAreaSend.TabIndex = 4;
            this.btnControlAreaSend.Text = "Send";
            this.btnControlAreaSend.UseVisualStyleBackColor = true;
            this.btnControlAreaSend.Click += new System.EventHandler(this.btnControlAreaSend_Click);
            // 
            // cbControlAreaState
            // 
            this.cbControlAreaState.FormattingEnabled = true;
            this.cbControlAreaState.Items.AddRange(new object[] {
            "Arm",
            "Disarm"});
            this.cbControlAreaState.Location = new System.Drawing.Point(57, 52);
            this.cbControlAreaState.MaxDropDownItems = 2;
            this.cbControlAreaState.Name = "cbControlAreaState";
            this.cbControlAreaState.Size = new System.Drawing.Size(74, 21);
            this.cbControlAreaState.TabIndex = 3;
            // 
            // tbControlAreaAreaID
            // 
            this.tbControlAreaAreaID.Location = new System.Drawing.Point(57, 26);
            this.tbControlAreaAreaID.Name = "tbControlAreaAreaID";
            this.tbControlAreaAreaID.Size = new System.Drawing.Size(74, 20);
            this.tbControlAreaAreaID.TabIndex = 2;
            // 
            // lblControlAreaAreaID
            // 
            this.lblControlAreaAreaID.AutoSize = true;
            this.lblControlAreaAreaID.Location = new System.Drawing.Point(6, 29);
            this.lblControlAreaAreaID.Name = "lblControlAreaAreaID";
            this.lblControlAreaAreaID.Size = new System.Drawing.Size(43, 13);
            this.lblControlAreaAreaID.TabIndex = 1;
            this.lblControlAreaAreaID.Text = "Area ID";
            // 
            // cbXmlSamples
            // 
            this.cbXmlSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXmlSamples.FormattingEnabled = true;
            this.cbXmlSamples.Location = new System.Drawing.Point(12, 300);
            this.cbXmlSamples.Name = "cbXmlSamples";
            this.cbXmlSamples.Size = new System.Drawing.Size(137, 21);
            this.cbXmlSamples.TabIndex = 7;
            this.cbXmlSamples.Text = "Samples";
            this.cbXmlSamples.SelectedIndexChanged += new System.EventHandler(this.cbXmlSamples_SelectedIndexChanged);
            // 
            // gbControlAux
            // 
            this.gbControlAux.Controls.Add(this.btnControlAuxSend);
            this.gbControlAux.Controls.Add(this.cbControlAuxState);
            this.gbControlAux.Controls.Add(this.tbControlAuxAuxID);
            this.gbControlAux.Controls.Add(this.lblControlAuxAuxID);
            this.gbControlAux.Location = new System.Drawing.Point(491, 12);
            this.gbControlAux.Name = "gbControlAux";
            this.gbControlAux.Size = new System.Drawing.Size(143, 116);
            this.gbControlAux.TabIndex = 8;
            this.gbControlAux.TabStop = false;
            this.gbControlAux.Text = "Control Aux";
            // 
            // btnControlAuxSend
            // 
            this.btnControlAuxSend.Location = new System.Drawing.Point(57, 79);
            this.btnControlAuxSend.Name = "btnControlAuxSend";
            this.btnControlAuxSend.Size = new System.Drawing.Size(75, 23);
            this.btnControlAuxSend.TabIndex = 4;
            this.btnControlAuxSend.Text = "Send";
            this.btnControlAuxSend.UseVisualStyleBackColor = true;
            this.btnControlAuxSend.Click += new System.EventHandler(this.btnControlAuxSend_Click);
            // 
            // cbControlAuxState
            // 
            this.cbControlAuxState.FormattingEnabled = true;
            this.cbControlAuxState.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbControlAuxState.Location = new System.Drawing.Point(57, 52);
            this.cbControlAuxState.MaxDropDownItems = 2;
            this.cbControlAuxState.Name = "cbControlAuxState";
            this.cbControlAuxState.Size = new System.Drawing.Size(74, 21);
            this.cbControlAuxState.TabIndex = 3;
            // 
            // tbControlAuxAuxID
            // 
            this.tbControlAuxAuxID.Location = new System.Drawing.Point(57, 26);
            this.tbControlAuxAuxID.Name = "tbControlAuxAuxID";
            this.tbControlAuxAuxID.Size = new System.Drawing.Size(74, 20);
            this.tbControlAuxAuxID.TabIndex = 2;
            // 
            // lblControlAuxAuxID
            // 
            this.lblControlAuxAuxID.AutoSize = true;
            this.lblControlAuxAuxID.Location = new System.Drawing.Point(6, 29);
            this.lblControlAuxAuxID.Name = "lblControlAuxAuxID";
            this.lblControlAuxAuxID.Size = new System.Drawing.Size(39, 13);
            this.lblControlAuxAuxID.TabIndex = 1;
            this.lblControlAuxAuxID.Text = "Aux ID";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 498);
            this.Controls.Add(this.gbControlAux);
            this.Controls.Add(this.cbXmlSamples);
            this.Controls.Add(this.gbControlArea);
            this.Controls.Add(this.gbTriggerInput);
            this.Controls.Add(this.tbXmlResult);
            this.Controls.Add(this.btnPostXml);
            this.Controls.Add(this.tbControllerID);
            this.Controls.Add(this.lblControllerID);
            this.Controls.Add(this.btnXmlFromFile);
            this.Controls.Add(this.tbXml);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.tbUrl);
            this.Name = "frmMain";
            this.Text = "Integriti REST";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbTriggerInput.ResumeLayout(false);
            this.gbTriggerInput.PerformLayout();
            this.gbControlArea.ResumeLayout(false);
            this.gbControlArea.PerformLayout();
            this.gbControlAux.ResumeLayout(false);
            this.gbControlAux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbXml;
        private System.Windows.Forms.Button btnXmlFromFile;
        private System.Windows.Forms.Button btnPostXml;
        private System.Windows.Forms.TextBox tbXmlResult;
        private System.Windows.Forms.GroupBox gbTriggerInput;
        private System.Windows.Forms.Label tbTriggerInputInputID;
        private System.Windows.Forms.Label lblControllerID;
        private System.Windows.Forms.TextBox tbControllerID;
        private System.Windows.Forms.TextBox tbControlInputInputID;
        private System.Windows.Forms.ComboBox cbControlInputState;
        private System.Windows.Forms.Button btnControlInputSend;
        private System.Windows.Forms.GroupBox gbControlArea;
        private System.Windows.Forms.Button btnControlAreaSend;
        private System.Windows.Forms.ComboBox cbControlAreaState;
        private System.Windows.Forms.TextBox tbControlAreaAreaID;
        private System.Windows.Forms.Label lblControlAreaAreaID;
        private System.Windows.Forms.ComboBox cbXmlSamples;
        private System.Windows.Forms.GroupBox gbControlAux;
        private System.Windows.Forms.Button btnControlAuxSend;
        private System.Windows.Forms.ComboBox cbControlAuxState;
        private System.Windows.Forms.TextBox tbControlAuxAuxID;
        private System.Windows.Forms.Label lblControlAuxAuxID;
    }
}

