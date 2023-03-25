namespace ForumGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnTopics = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHomeMenuBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxOfPostHome = new System.Windows.Forms.ListBox();
            this.listBoxOfTopicsHome = new System.Windows.Forms.ListBox();
            this.btnShowTopics = new System.Windows.Forms.Button();
            this.btnShowPosts = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnProfiles);
            this.panelMenu.Controls.Add(this.btnPosts);
            this.panelMenu.Controls.Add(this.btnTopics);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(0, 260);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfiles.Location = new System.Drawing.Point(0, 200);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(220, 60);
            this.btnProfiles.TabIndex = 3;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosts.FlatAppearance.BorderSize = 0;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPosts.Location = new System.Drawing.Point(0, 140);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(220, 60);
            this.btnPosts.TabIndex = 2;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = false;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnTopics
            // 
            this.btnTopics.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopics.FlatAppearance.BorderSize = 0;
            this.btnTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopics.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTopics.Location = new System.Drawing.Point(0, 80);
            this.btnTopics.Name = "btnTopics";
            this.btnTopics.Size = new System.Drawing.Size(220, 60);
            this.btnTopics.TabIndex = 1;
            this.btnTopics.Text = "Topics";
            this.btnTopics.UseVisualStyleBackColor = false;
            this.btnTopics.Click += new System.EventHandler(this.btnTopics_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Navy;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forum";
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.label2);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(220, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(764, 80);
            this.panelHomeMenuBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOME";
            // 
            // listBoxOfPostHome
            // 
            this.listBoxOfPostHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxOfPostHome.FormattingEnabled = true;
            this.listBoxOfPostHome.ItemHeight = 15;
            this.listBoxOfPostHome.Location = new System.Drawing.Point(220, 80);
            this.listBoxOfPostHome.Name = "listBoxOfPostHome";
            this.listBoxOfPostHome.Size = new System.Drawing.Size(764, 229);
            this.listBoxOfPostHome.TabIndex = 2;
            this.listBoxOfPostHome.SelectedIndexChanged += new System.EventHandler(this.listPostsHome);
            // 
            // listBoxOfTopicsHome
            // 
            this.listBoxOfTopicsHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxOfTopicsHome.FormattingEnabled = true;
            this.listBoxOfTopicsHome.ItemHeight = 15;
            this.listBoxOfTopicsHome.Location = new System.Drawing.Point(220, 302);
            this.listBoxOfTopicsHome.Name = "listBoxOfTopicsHome";
            this.listBoxOfTopicsHome.Size = new System.Drawing.Size(764, 259);
            this.listBoxOfTopicsHome.TabIndex = 3;
            this.listBoxOfTopicsHome.SelectedIndexChanged += new System.EventHandler(this.listTopicsHome);
            // 
            // btnShowTopics
            // 
            this.btnShowTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTopics.Location = new System.Drawing.Point(836, 518);
            this.btnShowTopics.Name = "btnShowTopics";
            this.btnShowTopics.Size = new System.Drawing.Size(136, 31);
            this.btnShowTopics.TabIndex = 5;
            this.btnShowTopics.Text = "Show topics";
            this.btnShowTopics.UseVisualStyleBackColor = true;
            this.btnShowTopics.Click += new System.EventHandler(this.btnShowTopics_Click);
            // 
            // btnShowPosts
            // 
            this.btnShowPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPosts.Location = new System.Drawing.Point(836, 260);
            this.btnShowPosts.Name = "btnShowPosts";
            this.btnShowPosts.Size = new System.Drawing.Size(136, 31);
            this.btnShowPosts.TabIndex = 6;
            this.btnShowPosts.Text = "Show posts";
            this.btnShowPosts.UseVisualStyleBackColor = true;
            this.btnShowPosts.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnShowPosts);
            this.Controls.Add(this.btnShowTopics);
            this.Controls.Add(this.listBoxOfTopicsHome);
            this.Controls.Add(this.listBoxOfPostHome);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnProfiles;
        private Button btnPosts;
        private Button btnTopics;
        private Panel panelLogo;
        private Label label1;
        private Panel panelHomeMenuBar;
        private Label label2;
        private ListBox listBoxOfPostHome;
        private ListBox listBoxOfTopicsHome;
        private Button btnHome;
        private Button btnShowTopics;
        private Button btnShowPosts;
    }
}