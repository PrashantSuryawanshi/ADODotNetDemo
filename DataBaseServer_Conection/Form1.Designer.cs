namespace DataBaseServer_Conection
{
    partial class DBForm1
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
            this.Salarylabel = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.DesignLable = new System.Windows.Forms.Label();
            this.IdLable = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Salarylabel
            // 
            this.Salarylabel.AutoSize = true;
            this.Salarylabel.Location = new System.Drawing.Point(167, 280);
            this.Salarylabel.Name = "Salarylabel";
            this.Salarylabel.Size = new System.Drawing.Size(46, 16);
            this.Salarylabel.TabIndex = 0;
            this.Salarylabel.Text = "Salary";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(167, 126);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(44, 16);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Name";
            // 
            // DesignLable
            // 
            this.DesignLable.AutoSize = true;
            this.DesignLable.Location = new System.Drawing.Point(167, 201);
            this.DesignLable.Name = "DesignLable";
            this.DesignLable.Size = new System.Drawing.Size(79, 16);
            this.DesignLable.TabIndex = 2;
            this.DesignLable.Text = "Designation";
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(167, 63);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(18, 16);
            this.IdLable.TabIndex = 3;
            this.IdLable.Text = "Id";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(350, 274);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(164, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(350, 198);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(164, 22);
            this.txtDesignation.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(350, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 22);
            this.txtId.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(596, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(596, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(170, 369);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(101, 23);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(472, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DBForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.IdLable);
            this.Controls.Add(this.DesignLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.Salarylabel);
            this.Name = "DBForm1";
            this.Text = "ADO.NET Connected Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Salarylabel;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label DesignLable;
        private System.Windows.Forms.Label IdLable;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}

