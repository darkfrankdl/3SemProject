namespace ForumGUI.Forms
{
    partial class FormCreateComment
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
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
            this.panelHomeMenuBar.Size = new System.Drawing.Size(800, 60);
            this.panelHomeMenuBar.TabIndex = 4;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.Location = new System.Drawing.Point(165, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(218, 37);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create Comment";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(68, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 30);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(212, 115);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(311, 23);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(124, 189);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(55, 30);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "Text:";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(212, 189);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(399, 132);
            this.textBoxText.TabIndex = 10;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(550, 392);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(135, 34);
            this.btnCreatePost.TabIndex = 11;
            this.btnCreatePost.Text = "Create";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // FormCreateComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormCreateComment";
            this.Text = "FormCreateComment";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private Label lblCreate;
        private Label lblUsername;
        private TextBox textBoxUsername;
        private Label lblText;
        private TextBox textBoxText;
        private Button btnCreatePost;
    }
}