namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("1.1");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("1.2");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("1.3");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("2.1");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("2.2");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("2", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkASP = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(273, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(93, 69);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(132, 22);
            this.txtAdress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 16;
            this.lstCity.Items.AddRange(new object[] {
            "Warsaw",
            "Berlin",
            "London",
            "New York",
            "Geneva ",
            "Toronto",
            "Mumbai"});
            this.lstCity.Location = new System.Drawing.Point(32, 164);
            this.lstCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(159, 116);
            this.lstCity.TabIndex = 1;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(324, 82);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 21);
            this.rdFemale.TabIndex = 2;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(324, 54);
            this.rdMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 21);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(324, 154);
            this.chkC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(47, 21);
            this.chkC.TabIndex = 4;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            this.chkASP.AutoSize = true;
            this.chkASP.Location = new System.Drawing.Point(324, 185);
            this.chkASP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkASP.Name = "chkASP";
            this.chkASP.Size = new System.Drawing.Size(89, 21);
            this.chkASP.TabIndex = 5;
            this.chkASP.Text = "ASP.NET";
            this.chkASP.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(324, 242);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(493, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode22.Name = "Węzeł1";
            treeNode22.Text = "1.1";
            treeNode23.Name = "Węzeł2";
            treeNode23.Text = "1.2";
            treeNode24.Name = "Węzeł3";
            treeNode24.Text = "1.3";
            treeNode25.Name = "1";
            treeNode25.Text = "1";
            treeNode26.Name = "Węzeł5";
            treeNode26.Text = "2.1";
            treeNode27.Name = "Węzeł6";
            treeNode27.Text = "2.2";
            treeNode28.Name = "Węzeł4";
            treeNode28.Text = "2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(160, 159);
            this.treeView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkASP);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkASP;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

