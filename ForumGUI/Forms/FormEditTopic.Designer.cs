namespace ForumGUI.Forms
{
    partial class FormEditTopic
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
            this.lblSelectedTopic = new System.Windows.Forms.Label();
            this.txtBoxCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnEditTopicOK = new System.Windows.Forms.Button();
            this.btbCancel = new System.Windows.Forms.Button();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.txtBoxSelectedTopic);
            this.panelHomeMenuBar.Controls.Add(this.lblSelectedTopic);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(475, 65);
            this.panelHomeMenuBar.TabIndex = 4;
            // 
            // txtBoxSelectedTopic
            // 
            this.txtBoxSelectedTopic.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxSelectedTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSelectedTopic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSelectedTopic.Location = new System.Drawing.Point(202, 20);
            this.txtBoxSelectedTopic.Name = "txtBoxSelectedTopic";
            this.txtBoxSelectedTopic.ReadOnly = true;
            this.txtBoxSelectedTopic.Size = new System.Drawing.Size(242, 39);
            this.txtBoxSelectedTopic.TabIndex = 2;
            // 
            // lblSelectedTopic
            // 
            this.lblSelectedTopic.AutoSize = true;
            this.lblSelectedTopic.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedTopic.Location = new System.Drawing.Point(3, 20);
            this.lblSelectedTopic.Name = "lblSelectedTopic";
            this.lblSelectedTopic.Size = new System.Drawing.Size(186, 37);
            this.lblSelectedTopic.TabIndex = 0;
            this.lblSelectedTopic.Text = "Selected Topic";
            // 
            // txtBoxCategoryName
            // 
            this.txtBoxCategoryName.Location = new System.Drawing.Point(187, 99);
            this.txtBoxCategoryName.Name = "txtBoxCategoryName";
            this.txtBoxCategoryName.Size = new System.Drawing.Size(282, 23);
            this.txtBoxCategoryName.TabIndex = 6;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryName.Location = new System.Drawing.Point(9, 91);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(154, 30);
            this.lblCategoryName.TabIndex = 9;
            this.lblCategoryName.Text = "Category name";
            // 
            // btnEditTopicOK
            // 
            this.btnEditTopicOK.Location = new System.Drawing.Point(328, 130);
            this.btnEditTopicOK.Name = "btnEditTopicOK";
            this.btnEditTopicOK.Size = new System.Drawing.Size(135, 34);
            this.btnEditTopicOK.TabIndex = 10;
            this.btnEditTopicOK.Text = "OK";
            this.btnEditTopicOK.UseVisualStyleBackColor = true;
            this.btnEditTopicOK.Click += new System.EventHandler(this.btnEditTopicOK_Click);
            // 
            // btbCancel
            // 
            this.btbCancel.Location = new System.Drawing.Point(171, 130);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(135, 34);
            this.btbCancel.TabIndex = 10;
            this.btbCancel.Text = "Cancel";
            this.btbCancel.UseVisualStyleBackColor = true;
            // 
            // FormEditTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 176);
            this.Controls.Add(this.btbCancel);
            this.Controls.Add(this.btnEditTopicOK);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.txtBoxCategoryName);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditTopic";
            this.Text = "FormEditTopic";
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHomeMenuBar;
        private TextBox txtBoxSelectedTopic;
        private Label lblSelectedTopic;
        private TextBox txtBoxCategoryName;
        private Label lblCategoryName;
        private Button btnEditTopicOK;
        private Button btbCancel;
    }
}