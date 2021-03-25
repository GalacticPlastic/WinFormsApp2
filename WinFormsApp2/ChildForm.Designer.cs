
namespace WinFormsApp2
{
    partial class ChildForm
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
            this.inputMajor = new System.Windows.Forms.TextBox();
            this.labelMajor = new System.Windows.Forms.Label();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputMajor
            // 
            this.inputMajor.Location = new System.Drawing.Point(235, 241);
            this.inputMajor.Name = "inputMajor";
            this.inputMajor.Size = new System.Drawing.Size(222, 23);
            this.inputMajor.TabIndex = 15;
            this.inputMajor.TextChanged += new System.EventHandler(this.inputMajor_TextChanged);
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(151, 244);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(41, 15);
            this.labelMajor.TabIndex = 14;
            this.labelMajor.Text = "Major:";
            this.labelMajor.Click += new System.EventHandler(this.labelMajor_Click);
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(235, 202);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(222, 23);
            this.inputLastName.TabIndex = 13;
            this.inputLastName.TextChanged += new System.EventHandler(this.inputLastName_TextChanged);
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(235, 163);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(222, 23);
            this.inputFirstName.TabIndex = 12;
            this.inputFirstName.TextChanged += new System.EventHandler(this.inputFirstName_TextChanged);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(235, 123);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(222, 23);
            this.inputId.TabIndex = 11;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(151, 205);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(151, 166);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(151, 126);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 15);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID:";
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(235, 296);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(75, 23);
            this.buttonGrade.TabIndex = 16;
            this.buttonGrade.Text = "Get Grade";
            this.buttonGrade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(337, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Current Grade";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGrade);
            this.Controls.Add(this.inputMajor);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelId);
            this.Name = "ChildForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputMajor;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Label label1;
    }
}