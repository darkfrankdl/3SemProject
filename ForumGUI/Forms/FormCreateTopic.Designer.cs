namespace ForumGUI.Forms
{
    partial class FormCreateTopic
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnCreateTopic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelHomeMenuBar.TabIndex = 2;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.Location = new System.Drawing.Point(160, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(163, 37);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(176, 106);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(282, 23);
            this.textBoxCategoryName.TabIndex = 5;
            this.textBoxCategoryName.TextChanged += new System.EventHandler(this.textBoxCategoryName_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(176, 170);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(282, 23);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // btnCreateTopic
            // 
            this.btnCreateTopic.Location = new System.Drawing.Point(323, 215);
            this.btnCreateTopic.Name = "btnCreateTopic";
            this.btnCreateTopic.Size = new System.Drawing.Size(135, 34);
            this.btnCreateTopic.TabIndex = 7;
            this.btnCreateTopic.Text = "Create";
            this.btnCreateTopic.UseVisualStyleBackColor = true;
            this.btnCreateTopic.Click += new System.EventHandler(this.btnCreateTopic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCreateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTopic);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Name = "FormCreateTopic";
            this.Text = "FormCreateTopic";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private Label lblCreate;
        private Label label2;
        private TextBox textBoxCategoryName;
        private TextBox textBoxUsername;
        private Button btnCreateTopic;
        private Label label1;
    }
}