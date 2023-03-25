namespace ForumGUI.Forms
{
    partial class FormEditProfile
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
            this.panelHomeMenuBar = new System.Windows.Forms.Panel();
            this.txtBoxSelectedProfile = new System.Windows.Forms.TextBox();
            this.lblSelectedProfile = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnEditTopicOK = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.txtBoxSelectedProfile);
            this.panelHomeMenuBar.Controls.Add(this.lblSelectedProfile);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(475, 65);
            this.panelHomeMenuBar.TabIndex = 5;
            // 
            // txtBoxSelectedProfile
            // 
            this.txtBoxSelectedProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxSelectedProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSelectedProfile.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSelectedProfile.Location = new System.Drawing.Point(202, 20);
            this.txtBoxSelectedProfile.Name = "txtBoxSelectedProfile";
            this.txtBoxSelectedProfile.ReadOnly = true;
            this.txtBoxSelectedProfile.Size = new System.Drawing.Size(242, 39);
            this.txtBoxSelectedProfile.TabIndex = 2;
            // 
            // lblSelectedProfile
            // 
            this.lblSelectedProfile.AutoSize = true;
            this.lblSelectedProfile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedProfile.Location = new System.Drawing.Point(3, 20);
            this.lblSelectedProfile.Name = "lblSelectedProfile";
            this.lblSelectedProfile.Size = new System.Drawing.Size(200, 37);
            this.lblSelectedProfile.TabIndex = 0;
            this.lblSelectedProfile.Text = "Selected Profile";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(12, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 30);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(130, 97);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(324, 23);
            this.txtBoxPassword.TabIndex = 11;
            // 
            // btnEditTopicOK
            // 
            this.btnEditTopicOK.Location = new System.Drawing.Point(319, 130);
            this.btnEditTopicOK.Name = "btnEditTopicOK";
            this.btnEditTopicOK.Size = new System.Drawing.Size(135, 34);
            this.btnEditTopicOK.TabIndex = 12;
            this.btnEditTopicOK.Text = "OK";
            this.btnEditTopicOK.UseVisualStyleBackColor = true;
            this.btnEditTopicOK.Click += new System.EventHandler(this.btnEditTopicOK_Click);
            // 
            // FormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 176);
            this.Controls.Add(this.btnEditTopicOK);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormEditProfile";
            this.Text = "FormEditProfile";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private TextBox txtBoxSelectedProfile;
        private Label lblSelectedProfile;
        private Label lblPassword;
        private TextBox txtBoxPassword;
        private Button btnEditTopicOK;
    }
}