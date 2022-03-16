
namespace WindowsFormsApp1
{
    partial class TypeSearchForm
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
            this.SearchSF = new System.Windows.Forms.Button();
            this.RB1_SF = new System.Windows.Forms.RadioButton();
            this.RB2_SF = new System.Windows.Forms.RadioButton();
            this.RB3_SF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputBoxSF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchSF
            // 
            this.SearchSF.Location = new System.Drawing.Point(13, 108);
            this.SearchSF.Margin = new System.Windows.Forms.Padding(2);
            this.SearchSF.Name = "SearchSF";
            this.SearchSF.Size = new System.Drawing.Size(93, 28);
            this.SearchSF.TabIndex = 10;
            this.SearchSF.Text = "Поиск";
            this.SearchSF.UseVisualStyleBackColor = true;
            this.SearchSF.Click += new System.EventHandler(this.SearchSF_Click);
            // 
            // RB1_SF
            // 
            this.RB1_SF.AutoSize = true;
            this.RB1_SF.Location = new System.Drawing.Point(13, 80);
            this.RB1_SF.Margin = new System.Windows.Forms.Padding(2);
            this.RB1_SF.Name = "RB1_SF";
            this.RB1_SF.Size = new System.Drawing.Size(72, 17);
            this.RB1_SF.TabIndex = 9;
            this.RB1_SF.TabStop = true;
            this.RB1_SF.Text = "Грузовой";
            this.RB1_SF.UseVisualStyleBackColor = true;
            // 
            // RB2_SF
            // 
            this.RB2_SF.AutoSize = true;
            this.RB2_SF.Location = new System.Drawing.Point(13, 58);
            this.RB2_SF.Margin = new System.Windows.Forms.Padding(2);
            this.RB2_SF.Name = "RB2_SF";
            this.RB2_SF.Size = new System.Drawing.Size(101, 17);
            this.RB2_SF.TabIndex = 8;
            this.RB2_SF.TabStop = true;
            this.RB2_SF.Text = "Пассажирский";
            this.RB2_SF.UseVisualStyleBackColor = true;
            // 
            // RB3_SF
            // 
            this.RB3_SF.AutoSize = true;
            this.RB3_SF.Location = new System.Drawing.Point(13, 36);
            this.RB3_SF.Margin = new System.Windows.Forms.Padding(2);
            this.RB3_SF.Name = "RB3_SF";
            this.RB3_SF.Size = new System.Drawing.Size(70, 17);
            this.RB3_SF.TabIndex = 7;
            this.RB3_SF.TabStop = true;
            this.RB3_SF.Text = "Военный";
            this.RB3_SF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите тип для поиска:";
            // 
            // OutputBoxSF
            // 
            this.OutputBoxSF.Location = new System.Drawing.Point(14, 141);
            this.OutputBoxSF.Multiline = true;
            this.OutputBoxSF.Name = "OutputBoxSF";
            this.OutputBoxSF.Size = new System.Drawing.Size(241, 125);
            this.OutputBoxSF.TabIndex = 41;
            // 
            // TypeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 278);
            this.Controls.Add(this.OutputBoxSF);
            this.Controls.Add(this.SearchSF);
            this.Controls.Add(this.RB1_SF);
            this.Controls.Add(this.RB2_SF);
            this.Controls.Add(this.RB3_SF);
            this.Controls.Add(this.label1);
            this.Name = "TypeSearchForm";
            this.Text = "TypeSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchSF;
        private System.Windows.Forms.RadioButton RB1_SF;
        private System.Windows.Forms.RadioButton RB2_SF;
        private System.Windows.Forms.RadioButton RB3_SF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputBoxSF;
    }
}