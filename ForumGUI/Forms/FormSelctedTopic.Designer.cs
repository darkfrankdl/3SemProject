namespace ForumGUI.Forms
{
    partial class FormSelctedTopic
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
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.textBoxTopicSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxCreatedByUsername = new System.Windows.Forms.TextBox();
            this.btnShowPosts = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.textBoxTopic);
            this.panelHomeMenuBar.Controls.Add(this.label2);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(800, 80);
            this.panelHomeMenuBar.TabIndex = 3;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTopic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTopic.Location = new System.Drawing.Point(265, 23);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.ReadOnly = true;
            this.textBoxTopic.Size = new System.Drawing.Size(328, 39);
            this.textBoxTopic.TabIndex = 2;
            this.textBoxTopic.TextChanged += new System.EventHandler(this.textBoxTopic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Topic";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(12, 401);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(170, 37);
            this.btnCreatePost.TabIndex = 7;
            this.btnCreatePost.Text = "Create Post";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // textBoxTopicSelected
            // 
            this.textBoxTopicSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTopicSelected.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTopicSelected.Location = new System.Drawing.Point(73, 108);
            this.textBoxTopicSelected.Name = "textBoxTopicSelected";
            this.textBoxTopicSelected.ReadOnly = true;
            this.textBoxTopicSelected.Size = new System.Drawing.Size(214, 28);
            this.textBoxTopicSelected.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Topic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(350, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Created by";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 15;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 179);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(766, 214);
            this.listBoxPosts.TabIndex = 12;
            this.listBoxPosts.DoubleClick += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxCreatedByUsername
            // 
            this.textBoxCreatedByUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCreatedByUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCreatedByUsername.Location = new System.Drawing.Point(459, 108);
            this.textBoxCreatedByUsername.Name = "textBoxCreatedByUsername";
            this.textBoxCreatedByUsername.ReadOnly = true;
            this.textBoxCreatedByUsername.Size = new System.Drawing.Size(214, 28);
            this.textBoxCreatedByUsername.TabIndex = 13;
            this.textBoxCreatedByUsername.TabStop = false;
            // 
            // btnShowPosts
            // 
            this.btnShowPosts.Location = new System.Drawing.Point(608, 399);
            this.btnShowPosts.Name = "btnShowPosts";
            this.btnShowPosts.Size = new System.Drawing.Size(170, 37);
            this.btnShowPosts.TabIndex = 14;
            this.btnShowPosts.Text = "Show posts";
            this.btnShowPosts.UseVisualStyleBackColor = true;
            this.btnShowPosts.Click += new System.EventHandler(this.btnShowPosts_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Location = new System.Drawing.Point(197, 401);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(170, 37);
            this.btnEditPost.TabIndex = 15;
            this.btnEditPost.Text = "Edit Post";
            this.btnEditPost.UseVisualStyleBackColor = true;
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(401, 399);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(170, 37);
            this.btnDeletePost.TabIndex = 16;
            this.btnDeletePost.Text = "Delete Post";
            this.btnDeletePost.UseVisualStyleBackColor = true;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // FormSelctedTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletePost);
            this.Controls.Add(this.btnEditPost);
            this.Controls.Add(this.btnShowPosts);
            this.Controls.Add(this.textBoxCreatedByUsername);
            this.Controls.Add(this.textBoxTopicSelected);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormSelctedTopic";
            this.Text = "FormSelctedTopic";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private Label label2;
        private Button btnCreatePost;
        private TextBox textBoxTopicSelected;
        private Label label1;
        private Label label3;
        private ListBox listBoxPosts;
        private TextBox textBoxTopic;
        private TextBox textBoxCreatedByUsername;
        private Button btnShowPosts;
        private Button btnEditPost;
        private Button btnDeletePost;
    }
}