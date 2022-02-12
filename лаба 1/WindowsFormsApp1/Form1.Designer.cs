
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.CubeRootButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.CtgButton = new System.Windows.Forms.Button();
            this.ExponentationButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(317, 40);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Num7Button
            // 
            this.Num7Button.Location = new System.Drawing.Point(10, 104);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(75, 32);
            this.Num7Button.TabIndex = 1;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.Location = new System.Drawing.Point(92, 104);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(75, 32);
            this.Num8Button.TabIndex = 2;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.Num8Button_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.Location = new System.Drawing.Point(10, 142);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(75, 32);
            this.Num4Button.TabIndex = 3;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.Num4Button_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.Location = new System.Drawing.Point(173, 104);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(75, 32);
            this.Num9Button.TabIndex = 4;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.Num9Button_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.Location = new System.Drawing.Point(173, 142);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(75, 32);
            this.Num6Button.TabIndex = 7;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.Num6Button_Click);
            // 
            // Num1Button
            // 
            this.Num1Button.Location = new System.Drawing.Point(10, 180);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(75, 32);
            this.Num1Button.TabIndex = 6;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.Location = new System.Drawing.Point(92, 142);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(75, 32);
            this.Num5Button.TabIndex = 5;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.Num5Button_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.Location = new System.Drawing.Point(173, 180);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(75, 32);
            this.Num3Button.TabIndex = 10;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.Num3Button_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.Location = new System.Drawing.Point(10, 218);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(75, 32);
            this.Num0Button.TabIndex = 9;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.Num0Button_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.Location = new System.Drawing.Point(92, 180);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(75, 32);
            this.Num2Button.TabIndex = 8;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.Num2Button_Click);
            // 
            // CosButton
            // 
            this.CosButton.Location = new System.Drawing.Point(173, 66);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(75, 32);
            this.CosButton.TabIndex = 13;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = true;
            // 
            // SinButton
            // 
            this.SinButton.Location = new System.Drawing.Point(92, 66);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(75, 32);
            this.SinButton.TabIndex = 12;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(10, 66);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 32);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // TanButton
            // 
            this.TanButton.Location = new System.Drawing.Point(254, 66);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(75, 32);
            this.TanButton.TabIndex = 17;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = true;
            // 
            // CubeRootButton
            // 
            this.CubeRootButton.Location = new System.Drawing.Point(254, 180);
            this.CubeRootButton.Name = "CubeRootButton";
            this.CubeRootButton.Size = new System.Drawing.Size(75, 32);
            this.CubeRootButton.TabIndex = 16;
            this.CubeRootButton.Text = "a^1/3";
            this.CubeRootButton.UseVisualStyleBackColor = true;
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Location = new System.Drawing.Point(254, 142);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(75, 32);
            this.SquareRootButton.TabIndex = 15;
            this.SquareRootButton.Text = "a^1/2";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            // 
            // CtgButton
            // 
            this.CtgButton.Location = new System.Drawing.Point(254, 104);
            this.CtgButton.Name = "CtgButton";
            this.CtgButton.Size = new System.Drawing.Size(75, 32);
            this.CtgButton.TabIndex = 14;
            this.CtgButton.Text = "ctg";
            this.CtgButton.UseVisualStyleBackColor = true;
            // 
            // ExponentationButton
            // 
            this.ExponentationButton.Location = new System.Drawing.Point(254, 218);
            this.ExponentationButton.Name = "ExponentationButton";
            this.ExponentationButton.Size = new System.Drawing.Size(75, 32);
            this.ExponentationButton.TabIndex = 20;
            this.ExponentationButton.Text = "a^n";
            this.ExponentationButton.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(173, 218);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 32);
            this.ResultButton.TabIndex = 19;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = true;
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(92, 218);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(75, 32);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Запомнить число";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "Выписать число";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExponentationButton);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CubeRootButton);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.CtgButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Num3Button);
            this.Controls.Add(this.Num0Button);
            this.Controls.Add(this.Num2Button);
            this.Controls.Add(this.Num6Button);
            this.Controls.Add(this.Num1Button);
            this.Controls.Add(this.Num5Button);
            this.Controls.Add(this.Num9Button);
            this.Controls.Add(this.Num4Button);
            this.Controls.Add(this.Num8Button);
            this.Controls.Add(this.Num7Button);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button CubeRootButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button CtgButton;
        private System.Windows.Forms.Button ExponentationButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

