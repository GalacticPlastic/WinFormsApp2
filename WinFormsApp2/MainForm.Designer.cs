
namespace WinFormsApp2
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputMajor = new System.Windows.Forms.TextBox();
            this.labelMajor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(46, 51);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            this.labelId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(46, 91);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(46, 130);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(130, 48);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(222, 23);
            this.inputId.TabIndex = 3;
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(130, 88);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(222, 23);
            this.inputFirstName.TabIndex = 4;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(130, 127);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(222, 23);
            this.inputLastName.TabIndex = 5;
            // 
            // inputMajor
            // 
            this.inputMajor.Location = new System.Drawing.Point(130, 166);
            this.inputMajor.Name = "inputMajor";
            this.inputMajor.Size = new System.Drawing.Size(222, 23);
            this.inputMajor.TabIndex = 7;
            this.inputMajor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(46, 169);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(41, 15);
            this.labelMajor.TabIndex = 6;
            this.labelMajor.Text = "Major:";
            this.labelMajor.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Undergrad Year";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(46, 209);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 15);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year:";
            this.labelYear.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputYear
            // 
            this.inputYear.AcceptsReturn = true;
            this.inputYear.Location = new System.Drawing.Point(130, 206);
            this.inputYear.Name = "inputYear";
            this.inputYear.ReadOnly = true;
            this.inputYear.Size = new System.Drawing.Size(222, 23);
            this.inputYear.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 328);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputMajor);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelId);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputMajor;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox inputYear;
    }
}

