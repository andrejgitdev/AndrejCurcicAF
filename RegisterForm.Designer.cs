namespace AndrejCurcicAF
{
    partial class RegisterForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createEmployeeLabel = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(263, 45);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(355, 36);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Välkommen till min lösning!";
            // 
            // createEmployeeLabel
            // 
            this.createEmployeeLabel.AutoSize = true;
            this.createEmployeeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmployeeLabel.Location = new System.Drawing.Point(374, 129);
            this.createEmployeeLabel.Name = "createEmployeeLabel";
            this.createEmployeeLabel.Size = new System.Drawing.Size(137, 23);
            this.createEmployeeLabel.TabIndex = 1;
            this.createEmployeeLabel.Text = "Skapa en person";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(378, 189);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(133, 20);
            this.textBoxFname.TabIndex = 2;
            // 
            // textBoxEname
            // 
            this.textBoxEname.Location = new System.Drawing.Point(378, 231);
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(133, 20);
            this.textBoxEname.TabIndex = 3;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(378, 278);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(133, 20);
            this.textBoxCompany.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(375, 171);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(56, 15);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "Förnamn";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(375, 213);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(375, 260);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(48, 15);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "Företag";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(378, 315);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(133, 35);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Skapa";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 466);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxEname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.createEmployeeLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label createEmployeeLabel;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxEname;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button createButton;
    }
}

