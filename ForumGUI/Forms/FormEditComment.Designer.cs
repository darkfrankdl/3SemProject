namespace ForumGUI.Forms
{
    partial class FormEditComment
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
            this.txtBoxSelectedTopic = new System.Windows.Forms.TextBox();
            this.lblSelectedPost = new System.Windows.Forms.Label();
            this.btnEditTopicOK = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.txtBoxSelectedTopic);
            this.panelHomeMenuBar.Controls.Add(this.lblSelectedPost);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(800, 65);
            this.panelHomeMenuBar.TabIndex = 6;
            // 
            // txtBoxSelectedTopic
            // 
            this.txtBoxSelectedTopic.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxSelectedTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSelectedTopic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSelectedTopic.Location = new System.Drawing.Point(202, 20);
            this.txtBoxSelectedTopic.Name = "txtBoxSelectedTopic";
            this.txtBoxSelectedTopic.ReadOnly = true;
            this.txtBoxSelectedTopic.Size = new System.Drawing.Size(468, 39);
            this.txtBoxSelectedTopic.TabIndex = 2;
            // 
            // lblSelectedPost
            // 
            this.lblSelectedPost.AutoSize = true;
            this.lblSelectedPost.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedPost.Location = new System.Drawing.Point(12, 22);
            this.lblSelectedPost.Name = "lblSelectedPost";
            this.lblSelectedPost.Size = new System.Drawing.Size(134, 37);
            this.lblSelectedPost.TabIndex = 0;
            this.lblSelectedPost.Text = "Comment";
            // 
            // btnEditTopicOK
            // 
            this.btnEditTopicOK.Location = new System.Drawing.Point(653, 404);
            this.btnEditTopicOK.Name = "btnEditTopicOK";
            this.btnEditTopicOK.Size = new System.Drawing.Size(135, 34);
            this.btnEditTopicOK.TabIndex = 13;
            this.btnEditTopicOK.Text = "OK";
            this.btnEditTopicOK.UseVisualStyleBackColor = true;
            // 
            // FormEditComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditTopicOK);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormEditComment";
            this.Text = "FormEditComment";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHomeMenuBar;
        private TextBox txtBoxSelectedTopic;
        private Label lblSelectedPost;
        private Button btnEditTopicOK;
    }
}