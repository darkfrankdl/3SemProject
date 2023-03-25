namespace ForumGUI.Forms
{
    partial class FormEditPost
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
            this.txtBoxSelectedPost = new System.Windows.Forms.TextBox();
            this.lblSelectedPost = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBoxPostText = new System.Windows.Forms.TextBox();
            this.btnEditPostOK = new System.Windows.Forms.Button();
            this.btbCancel = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.txtBoxSelectedPost);
            this.panelHomeMenuBar.Controls.Add(this.lblSelectedPost);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(475, 65);
            this.panelHomeMenuBar.TabIndex = 5;
            // 
            // txtBoxSelectedPost
            // 
            this.txtBoxSelectedPost.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxSelectedPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSelectedPost.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSelectedPost.Location = new System.Drawing.Point(202, 20);
            this.txtBoxSelectedPost.Name = "txtBoxSelectedPost";
            this.txtBoxSelectedPost.ReadOnly = true;
            this.txtBoxSelectedPost.Size = new System.Drawing.Size(242, 39);
            this.txtBoxSelectedPost.TabIndex = 2;
            // 
            // lblSelectedPost
            // 
            this.lblSelectedPost.AutoSize = true;
            this.lblSelectedPost.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedPost.Location = new System.Drawing.Point(3, 20);
            this.lblSelectedPost.Name = "lblSelectedPost";
            this.lblSelectedPost.Size = new System.Drawing.Size(174, 37);
            this.lblSelectedPost.TabIndex = 0;
            this.lblSelectedPost.Text = "Selected Post";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(12, 96);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(50, 30);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Text";
            // 
            // txtBoxPostText
            // 
            this.txtBoxPostText.Location = new System.Drawing.Point(172, 105);
            this.txtBoxPostText.Multiline = true;
            this.txtBoxPostText.Name = "txtBoxPostText";
            this.txtBoxPostText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxPostText.Size = new System.Drawing.Size(272, 21);
            this.txtBoxPostText.TabIndex = 11;
            // 
            // btnEditPostOK
            // 
            this.btnEditPostOK.Location = new System.Drawing.Point(12, 215);
            this.btnEditPostOK.Name = "btnEditPostOK";
            this.btnEditPostOK.Size = new System.Drawing.Size(135, 34);
            this.btnEditPostOK.TabIndex = 12;
            this.btnEditPostOK.Text = "OK";
            this.btnEditPostOK.UseVisualStyleBackColor = true;
            this.btnEditPostOK.Click += new System.EventHandler(this.btnEditPostOK_Click);
            // 
            // btbCancel
            // 
            this.btbCancel.Location = new System.Drawing.Point(328, 215);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(135, 34);
            this.btbCancel.TabIndex = 12;
            this.btbCancel.Text = "Cancel";
            this.btbCancel.UseVisualStyleBackColor = true;
            this.btbCancel.Click += new System.EventHandler(this.btbCancel_Click);
            // 
            // FormEditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.btbCancel);
            this.Controls.Add(this.btnEditPostOK);
            this.Controls.Add(this.txtBoxPostText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormEditPost";
            this.Text = "FormEditPost";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private TextBox txtBoxSelectedPost;
        private Label lblSelectedPost;
        private Label lblText;
        private TextBox txtBoxPostText;
        private Button btnEditPostOK;
        private Button btbCancel;
    }
}