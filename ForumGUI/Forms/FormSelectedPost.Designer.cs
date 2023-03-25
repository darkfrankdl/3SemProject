namespace ForumGUI.Forms
{
    partial class FormSelectedPost
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
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.lblSelectedPost = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.textBoxTopicSelected = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.btnShowPosts = new System.Windows.Forms.Button();
            this.btnShowComments = new System.Windows.Forms.Button();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.textBoxPost);
            this.panelHomeMenuBar.Controls.Add(this.lblSelectedPost);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(800, 80);
            this.panelHomeMenuBar.TabIndex = 4;
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPost.Location = new System.Drawing.Point(265, 23);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.Size = new System.Drawing.Size(328, 39);
            this.textBoxPost.TabIndex = 2;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // lblSelectedPost
            // 
            this.lblSelectedPost.AutoSize = true;
            this.lblSelectedPost.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedPost.Location = new System.Drawing.Point(73, 23);
            this.lblSelectedPost.Name = "lblSelectedPost";
            this.lblSelectedPost.Size = new System.Drawing.Size(180, 37);
            this.lblSelectedPost.TabIndex = 0;
            this.lblSelectedPost.Text = "Selected Post:";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPost.Location = new System.Drawing.Point(12, 103);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(60, 25);
            this.lblPost.TabIndex = 9;
            this.lblPost.Text = "Topic:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatedBy.Location = new System.Drawing.Point(294, 103);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(107, 25);
            this.lblCreatedBy.TabIndex = 10;
            this.lblCreatedBy.Text = "Created by:";
            // 
            // textBoxTopicSelected
            // 
            this.textBoxTopicSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTopicSelected.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTopicSelected.Location = new System.Drawing.Point(74, 99);
            this.textBoxTopicSelected.Name = "textBoxTopicSelected";
            this.textBoxTopicSelected.ReadOnly = true;
            this.textBoxTopicSelected.Size = new System.Drawing.Size(214, 28);
            this.textBoxTopicSelected.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(403, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(214, 28);
            this.textBox1.TabIndex = 12;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 15;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 159);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(776, 154);
            this.listBoxPosts.TabIndex = 13;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 15;
            this.listBoxComments.Location = new System.Drawing.Point(12, 319);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(776, 124);
            this.listBoxComments.TabIndex = 14;
            this.listBoxComments.SelectedIndexChanged += new System.EventHandler(this.listBoxComments_SelectedIndexChanged);
            // 
            // btnShowPosts
            // 
            this.btnShowPosts.Location = new System.Drawing.Point(649, 458);
            this.btnShowPosts.Name = "btnShowPosts";
            this.btnShowPosts.Size = new System.Drawing.Size(139, 37);
            this.btnShowPosts.TabIndex = 15;
            this.btnShowPosts.Text = "Show post";
            this.btnShowPosts.UseVisualStyleBackColor = true;
            // 
            // btnShowComments
            // 
            this.btnShowComments.Location = new System.Drawing.Point(12, 458);
            this.btnShowComments.Name = "btnShowComments";
            this.btnShowComments.Size = new System.Drawing.Size(128, 37);
            this.btnShowComments.TabIndex = 16;
            this.btnShowComments.Text = "Show comments";
            this.btnShowComments.UseVisualStyleBackColor = true;
            this.btnShowComments.Click += new System.EventHandler(this.btnShowComments_Click);
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.Location = new System.Drawing.Point(326, 458);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(136, 37);
            this.btnDeleteComment.TabIndex = 17;
            this.btnDeleteComment.Text = "Delete comment";
            this.btnDeleteComment.UseVisualStyleBackColor = true;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Location = new System.Drawing.Point(488, 458);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(129, 37);
            this.btnEditPost.TabIndex = 18;
            this.btnEditPost.Text = "Edit Post";
            this.btnEditPost.UseVisualStyleBackColor = true;
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(169, 458);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 37);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create comment";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormSelectedPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEditPost);
            this.Controls.Add(this.btnDeleteComment);
            this.Controls.Add(this.btnShowComments);
            this.Controls.Add(this.btnShowPosts);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTopicSelected);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormSelectedPost";
            this.Text = "FormSelectedPost";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private TextBox textBoxPost;
        private Label lblSelectedPost;
        private Label label1;
        private Label label3;
        private Label lblPost;
        private Label lblCreatedBy;
        private TextBox textBoxTopicSelected;
        private TextBox textBox1;
        private ListBox listBoxPosts;
        private ListBox listBoxComments;
        private Button btnShowPosts;
        private Button btnShowComments;
        private Button btnDeleteComment;
        private Button btnEditPost;
        private Button btnCreate;
    }
}