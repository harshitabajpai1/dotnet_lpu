namespace SerializationDemo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnBinDeSerialize = new System.Windows.Forms.Button();
            this.btnXmlSerialize = new System.Windows.Forms.Button();
            this.btnXmlDeSerialize = new System.Windows.Forms.Button();
            this.btnSoapSerialize = new System.Windows.Forms.Button();
            this.btnSoapDeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmployeeID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEmployeeID.Location = new System.Drawing.Point(178, 54);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 30);
            this.txtEmployeeID.TabIndex = 1;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(54, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtName.Location = new System.Drawing.Point(177, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(177, 158);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 26);
            this.txtSalary.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.Location = new System.Drawing.Point(59, 255);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(127, 42);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click_1);
            // 
            // btnBinDeSerialize
            // 
            this.btnBinDeSerialize.Location = new System.Drawing.Point(59, 323);
            this.btnBinDeSerialize.Name = "btnBinDeSerialize";
            this.btnBinDeSerialize.Size = new System.Drawing.Size(127, 42);
            this.btnBinDeSerialize.TabIndex = 7;
            this.btnBinDeSerialize.Text = "Bin Deserialize";
            this.btnBinDeSerialize.UseVisualStyleBackColor = true;
            this.btnBinDeSerialize.Click += new System.EventHandler(this.btnBinDeSerialize_Click);
            // 
            // btnXmlSerialize
            // 
            this.btnXmlSerialize.Location = new System.Drawing.Point(206, 255);
            this.btnXmlSerialize.Name = "btnXmlSerialize";
            this.btnXmlSerialize.Size = new System.Drawing.Size(163, 42);
            this.btnXmlSerialize.TabIndex = 8;
            this.btnXmlSerialize.Text = "XML Serialize";
            this.btnXmlSerialize.UseVisualStyleBackColor = true;
            this.btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
            // 
            // btnXmlDeSerialize
            // 
            this.btnXmlDeSerialize.Location = new System.Drawing.Point(206, 323);
            this.btnXmlDeSerialize.Name = "btnXmlDeSerialize";
            this.btnXmlDeSerialize.Size = new System.Drawing.Size(163, 42);
            this.btnXmlDeSerialize.TabIndex = 9;
            this.btnXmlDeSerialize.Text = "XML DeSerializer";
            this.btnXmlDeSerialize.UseVisualStyleBackColor = true;
            this.btnXmlDeSerialize.Click += new System.EventHandler(this.btnXmlDeSerialize_Click);
            // 
            // btnSoapSerialize
            // 
            this.btnSoapSerialize.Location = new System.Drawing.Point(408, 255);
            this.btnSoapSerialize.Name = "btnSoapSerialize";
            this.btnSoapSerialize.Size = new System.Drawing.Size(158, 42);
            this.btnSoapSerialize.TabIndex = 10;
            this.btnSoapSerialize.Text = "SOAP Serialize";
            this.btnSoapSerialize.UseVisualStyleBackColor = true;
            this.btnSoapSerialize.Click += new System.EventHandler(this.btnSoapSerialize_Click);
            // 
            // btnSoapDeSerialize
            // 
            this.btnSoapDeSerialize.Location = new System.Drawing.Point(408, 323);
            this.btnSoapDeSerialize.Name = "btnSoapDeSerialize";
            this.btnSoapDeSerialize.Size = new System.Drawing.Size(158, 42);
            this.btnSoapDeSerialize.TabIndex = 11;
            this.btnSoapDeSerialize.Text = "SOAP DeSerialize";
            this.btnSoapDeSerialize.UseVisualStyleBackColor = true;
            this.btnSoapDeSerialize.Click += new System.EventHandler(this.btnSoapDeSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoapDeSerialize);
            this.Controls.Add(this.btnSoapSerialize);
            this.Controls.Add(this.btnXmlDeSerialize);
            this.Controls.Add(this.btnXmlSerialize);
            this.Controls.Add(this.btnBinDeSerialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnBinDeSerialize;
        private System.Windows.Forms.Button btnXmlSerialize;
        private System.Windows.Forms.Button btnXmlDeSerialize;
        private System.Windows.Forms.Button btnSoapSerialize;
        private System.Windows.Forms.Button btnSoapDeSerialize;
    }
}

