namespace AndrejCurcicAF
{
    partial class CompanyForm
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
            this.components = new System.ComponentModel.Container();
            this.topLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.chooseCompanyLabel = new System.Windows.Forms.Label();
            this.AnstalldaLabel = new System.Windows.Forms.Label();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataEmployees = new System.Windows.Forms.DataGridView();
            this.createCompany = new System.Windows.Forms.Button();
            this.companyList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(12, 18);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(223, 36);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Skapa ett företag";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(469, 22);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(298, 29);
            this.secondLabel.TabIndex = 2;
            this.secondLabel.Text = "Sök på företag och Anställda";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(18, 108);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(246, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(18, 89);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(85, 15);
            this.companyNameLabel.TabIndex = 4;
            this.companyNameLabel.Text = "Företagsnamn";
            // 
            // chooseCompanyLabel
            // 
            this.chooseCompanyLabel.AutoSize = true;
            this.chooseCompanyLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCompanyLabel.Location = new System.Drawing.Point(471, 72);
            this.chooseCompanyLabel.Name = "chooseCompanyLabel";
            this.chooseCompanyLabel.Size = new System.Drawing.Size(73, 15);
            this.chooseCompanyLabel.TabIndex = 7;
            this.chooseCompanyLabel.Text = "Välj företag ";
            // 
            // AnstalldaLabel
            // 
            this.AnstalldaLabel.AutoSize = true;
            this.AnstalldaLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnstalldaLabel.Location = new System.Drawing.Point(471, 207);
            this.AnstalldaLabel.Name = "AnstalldaLabel";
            this.AnstalldaLabel.Size = new System.Drawing.Size(120, 15);
            this.AnstalldaLabel.TabIndex = 11;
            this.AnstalldaLabel.Text = "Företagets Anställda";
            // 
            // dataEmployees
            // 
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployees.Location = new System.Drawing.Point(474, 226);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.ReadOnly = true;
            this.dataEmployees.Size = new System.Drawing.Size(366, 150);
            this.dataEmployees.TabIndex = 12;
            // 
            // createCompany
            // 
            this.createCompany.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCompany.Location = new System.Drawing.Point(18, 134);
            this.createCompany.Name = "createCompany";
            this.createCompany.Size = new System.Drawing.Size(246, 30);
            this.createCompany.TabIndex = 13;
            this.createCompany.Text = "Skapa Företag";
            this.createCompany.UseVisualStyleBackColor = true;
            this.createCompany.Click += new System.EventHandler(this.createCompany_Click_1);
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(474, 91);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(293, 82);
            this.companyList.TabIndex = 14;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 466);
            this.Controls.Add(this.companyList);
            this.Controls.Add(this.createCompany);
            this.Controls.Add(this.dataEmployees);
            this.Controls.Add(this.AnstalldaLabel);
            this.Controls.Add(this.chooseCompanyLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.topLabel);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label chooseCompanyLabel;
        private System.Windows.Forms.Label AnstalldaLabel;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private System.Windows.Forms.Button createCompany;
    }
}

