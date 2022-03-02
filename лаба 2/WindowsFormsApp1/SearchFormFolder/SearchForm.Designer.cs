
namespace WindowsFormsApp1.SearchFormFolder
{
    partial class SearchForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.SFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SFtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SFcapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SFloadCapacity = new System.Windows.Forms.CheckedListBox();
            this.SearchFormResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Поиск по:";
            // 
            // SFname
            // 
            this.SFname.Location = new System.Drawing.Point(135, 42);
            this.SFname.Name = "SFname";
            this.SFname.Size = new System.Drawing.Size(148, 20);
            this.SFname.TabIndex = 21;
            this.SFname.TextChanged += new System.EventHandler(this.SFname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Названию —";
            // 
            // SFtype
            // 
            this.SFtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SFtype.FormattingEnabled = true;
            this.SFtype.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой",
            "Военный"});
            this.SFtype.Location = new System.Drawing.Point(135, 68);
            this.SFtype.Name = "SFtype";
            this.SFtype.Size = new System.Drawing.Size(148, 21);
            this.SFtype.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Типу —";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Количеству мест —";
            // 
            // SFcapacity
            // 
            this.SFcapacity.Location = new System.Drawing.Point(135, 95);
            this.SFcapacity.Name = "SFcapacity";
            this.SFcapacity.Size = new System.Drawing.Size(148, 20);
            this.SFcapacity.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Грузоподъемности —";
            // 
            // SFloadCapacity
            // 
            this.SFloadCapacity.FormattingEnabled = true;
            this.SFloadCapacity.Items.AddRange(new object[] {
            "1т",
            "2т",
            "10т"});
            this.SFloadCapacity.Location = new System.Drawing.Point(135, 122);
            this.SFloadCapacity.Name = "SFloadCapacity";
            this.SFloadCapacity.Size = new System.Drawing.Size(148, 49);
            this.SFloadCapacity.TabIndex = 46;
            // 
            // SearchFormResult
            // 
            this.SearchFormResult.Location = new System.Drawing.Point(15, 217);
            this.SearchFormResult.Multiline = true;
            this.SearchFormResult.Name = "SearchFormResult";
            this.SearchFormResult.Size = new System.Drawing.Size(276, 341);
            this.SearchFormResult.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Результат:";
            // 
            // SearchFormButton
            // 
            this.SearchFormButton.Location = new System.Drawing.Point(135, 9);
            this.SearchFormButton.Name = "SearchFormButton";
            this.SearchFormButton.Size = new System.Drawing.Size(148, 20);
            this.SearchFormButton.TabIndex = 51;
            this.SearchFormButton.Text = "Показать результат";
            this.SearchFormButton.UseVisualStyleBackColor = true;
            this.SearchFormButton.Click += new System.EventHandler(this.SearchFormButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 570);
            this.Controls.Add(this.SearchFormButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchFormResult);
            this.Controls.Add(this.SFloadCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SFcapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SFtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SFname);
            this.Controls.Add(this.label9);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SFtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SFcapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox SFloadCapacity;
        private System.Windows.Forms.TextBox SearchFormResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchFormButton;
    }
}