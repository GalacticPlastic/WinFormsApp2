
namespace WinFormsApp2
{
    partial class UnderGraduateForm
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
            this.dropdownYear = new System.Windows.Forms.ListBox();
            this.buttonYear = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropdownYear
            // 
            this.dropdownYear.FormattingEnabled = true;
            this.dropdownYear.ItemHeight = 15;
            this.dropdownYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.dropdownYear.Location = new System.Drawing.Point(177, 71);
            this.dropdownYear.Name = "dropdownYear";
            this.dropdownYear.Size = new System.Drawing.Size(120, 94);
            this.dropdownYear.TabIndex = 6;
            // 
            // buttonYear
            // 
            this.buttonYear.Location = new System.Drawing.Point(177, 189);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(75, 23);
            this.buttonYear.TabIndex = 5;
            this.buttonYear.Text = "Submit";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(51, 71);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(106, 15);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Select Current Year";
            // 
            // UnderGraduateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 271);
            this.Controls.Add(this.dropdownYear);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.labelYear);
            this.Name = "UnderGraduateForm";
            this.Text = "UnderGraduateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dropdownYear;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Label labelYear;
    }
}