
namespace WinFormsApp2
{
    partial class GraduateForm
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
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonYear = new System.Windows.Forms.Button();
            this.inputYear = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(46, 61);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(106, 15);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Select Current Year";
            // 
            // buttonYear
            // 
            this.buttonYear.Location = new System.Drawing.Point(172, 179);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(75, 23);
            this.buttonYear.TabIndex = 2;
            this.buttonYear.Text = "Submit";
            this.buttonYear.UseVisualStyleBackColor = true;
            // 
            // inputYear
            // 
            this.inputYear.FormattingEnabled = true;
            this.inputYear.ItemHeight = 15;
            this.inputYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.inputYear.Location = new System.Drawing.Point(172, 61);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(120, 94);
            this.inputYear.TabIndex = 3;
            // 
            // GraduateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 242);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.labelYear);
            this.Name = "GraduateForm";
            this.Text = "GraduateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.ListBox inputYear;
    }
}