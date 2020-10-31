namespace Windows_Form_Flash_Cards
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
            this.subjectSelector = new System.Windows.Forms.ComboBox();
            this.reviseBt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectSelector
            // 
            this.subjectSelector.FormattingEnabled = true;
            this.subjectSelector.Items.AddRange(new object[] {
            "Computer Science",
            "English Literature",
            "Product Design",
            "Chemistry",
            "Biology",
            "Physics",
            "German",
            "History",
            "Maths"});
            this.subjectSelector.Location = new System.Drawing.Point(7, 23);
            this.subjectSelector.Name = "subjectSelector";
            this.subjectSelector.Size = new System.Drawing.Size(116, 21);
            this.subjectSelector.TabIndex = 0;
            // 
            // reviseBt1
            // 
            this.reviseBt1.Location = new System.Drawing.Point(129, 23);
            this.reviseBt1.Name = "reviseBt1";
            this.reviseBt1.Size = new System.Drawing.Size(75, 23);
            this.reviseBt1.TabIndex = 1;
            this.reviseBt1.Text = "Revise";
            this.reviseBt1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Subject:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 49);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviseBt1);
            this.Controls.Add(this.subjectSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashcards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectSelector;
        private System.Windows.Forms.Button reviseBt1;
        private System.Windows.Forms.Label label1;
    }
}

