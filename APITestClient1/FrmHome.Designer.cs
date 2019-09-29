namespace APITestClient1
{
    partial class frmHome
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
            this.lblURL = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblRecentAction = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRandomInt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.Location = new System.Drawing.Point(35, 27);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(44, 15);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL:";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.CausesValidation = false;
            this.btnUpdate.Location = new System.Drawing.Point(246, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(84, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(237, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "127.0.0.1:3000";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(84, 52);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(237, 20);
            this.txtVersion.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(24, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(55, 17);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version:";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(165, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResponse.Location = new System.Drawing.Point(12, 238);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(320, 111);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "No response";
            // 
            // lblRecentAction
            // 
            this.lblRecentAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecentAction.Location = new System.Drawing.Point(12, 114);
            this.lblRecentAction.Name = "lblRecentAction";
            this.lblRecentAction.Size = new System.Drawing.Size(320, 111);
            this.lblRecentAction.TabIndex = 7;
            this.lblRecentAction.Text = "No recent action";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(84, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRandomInt
            // 
            this.lblRandomInt.AutoSize = true;
            this.lblRandomInt.Location = new System.Drawing.Point(12, 4);
            this.lblRandomInt.Name = "lblRandomInt";
            this.lblRandomInt.Size = new System.Drawing.Size(82, 13);
            this.lblRandomInt.TabIndex = 9;
            this.lblRandomInt.Text = "Random integer";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 359);
            this.Controls.Add(this.lblRandomInt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRecentAction);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblURL);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblRecentAction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRandomInt;
    }
}

