namespace ContactsBook_Gavrylchenko
{
    partial class FormMain
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
            this.lCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lContacts = new System.Windows.Forms.Label();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.lInformation = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(29, 23);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(69, 13);
            this.lCategory.TabIndex = 0;
            this.lCategory.Text = "Катергории:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(32, 49);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(244, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // lContacts
            // 
            this.lContacts.AutoSize = true;
            this.lContacts.Location = new System.Drawing.Point(29, 93);
            this.lContacts.Name = "lContacts";
            this.lContacts.Size = new System.Drawing.Size(59, 13);
            this.lContacts.TabIndex = 2;
            this.lContacts.Text = "Контакты:";
            // 
            // lbContacts
            // 
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.Location = new System.Drawing.Point(32, 122);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(244, 264);
            this.lbContacts.TabIndex = 3;
            // 
            // lInformation
            // 
            this.lInformation.AutoSize = true;
            this.lInformation.Location = new System.Drawing.Point(322, 23);
            this.lInformation.Name = "lInformation";
            this.lInformation.Size = new System.Drawing.Size(76, 13);
            this.lInformation.TabIndex = 4;
            this.lInformation.Text = "Информация:";
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(325, 50);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(278, 336);
            this.txtInformation.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(248, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 444);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.lInformation);
            this.Controls.Add(this.lbContacts);
            this.Controls.Add(this.lContacts);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lCategory);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lContacts;
        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.Label lInformation;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

