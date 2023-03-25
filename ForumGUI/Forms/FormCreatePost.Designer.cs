namespace ForumGUI.Forms
{
    partial class FormCreatePost
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
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.lblCreate);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(484, 60);
            this.panelHomeMenuBar.TabIndex = 3;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.Location = new System.Drawing.Point(165, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(151, 37);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create Post";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(14, 206);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(50, 30);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 146);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(12, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 30);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(136, 92);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(311, 23);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(136, 155);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(311, 23);
            this.textBoxTitle.TabIndex = 8;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(136, 215);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(311, 122);
            this.textBoxText.TabIndex = 9;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(312, 365);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(135, 34);
            this.btnCreatePost.TabIndex = 10;
            this.btnCreatePost.Text = "Create";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // FormCreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormCreatePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreatePost";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private Label lblCreate;
        private Label lblText;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox textBoxUsername;
        private TextBox textBoxTitle;
        private TextBox textBoxText;
        private Button btnCreatePost;
    }
}