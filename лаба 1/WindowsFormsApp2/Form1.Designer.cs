
namespace WindowsFormsApp2
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
            this.CollectionSizeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateTheCollectionButton = new System.Windows.Forms.Button();
            this.DescendingSortButton = new System.Windows.Forms.Button();
            this.AscendingSortButton = new System.Windows.Forms.Button();
            this.MinQueryButton = new System.Windows.Forms.Button();
            this.MaxQueryButton = new System.Windows.Forms.Button();
            this.RangeQueryButton = new System.Windows.Forms.Button();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CollectionSizeInput
            // 
            this.CollectionSizeInput.Location = new System.Drawing.Point(124, 12);
            this.CollectionSizeInput.Name = "CollectionSizeInput";
            this.CollectionSizeInput.Size = new System.Drawing.Size(97, 20);
            this.CollectionSizeInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер коллекции:";
            // 
            // GenerateTheCollectionButton
            // 
            this.GenerateTheCollectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateTheCollectionButton.Location = new System.Drawing.Point(227, 11);
            this.GenerateTheCollectionButton.Name = "GenerateTheCollectionButton";
            this.GenerateTheCollectionButton.Size = new System.Drawing.Size(110, 21);
            this.GenerateTheCollectionButton.TabIndex = 3;
            this.GenerateTheCollectionButton.Text = "сгенерировать!";
            this.GenerateTheCollectionButton.UseVisualStyleBackColor = true;
            this.GenerateTheCollectionButton.Click += new System.EventHandler(this.GenerateTheCollectionButton_Click);
            // 
            // DescendingSortButton
            // 
            this.DescendingSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescendingSortButton.Location = new System.Drawing.Point(12, 49);
            this.DescendingSortButton.Name = "DescendingSortButton";
            this.DescendingSortButton.Size = new System.Drawing.Size(160, 36);
            this.DescendingSortButton.TabIndex = 4;
            this.DescendingSortButton.Text = "Отсортировать по убыванию";
            this.DescendingSortButton.UseVisualStyleBackColor = true;
            // 
            // AscendingSortButton
            // 
            this.AscendingSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AscendingSortButton.Location = new System.Drawing.Point(178, 49);
            this.AscendingSortButton.Name = "AscendingSortButton";
            this.AscendingSortButton.Size = new System.Drawing.Size(159, 36);
            this.AscendingSortButton.TabIndex = 5;
            this.AscendingSortButton.Text = "Отсортировать по возрастанию";
            this.AscendingSortButton.UseVisualStyleBackColor = true;
            // 
            // MinQueryButton
            // 
            this.MinQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinQueryButton.Location = new System.Drawing.Point(12, 91);
            this.MinQueryButton.Name = "MinQueryButton";
            this.MinQueryButton.Size = new System.Drawing.Size(325, 26);
            this.MinQueryButton.TabIndex = 6;
            this.MinQueryButton.Text = "Запрос 1: Минимальный элемент";
            this.MinQueryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinQueryButton.UseVisualStyleBackColor = true;
            // 
            // MaxQueryButton
            // 
            this.MaxQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxQueryButton.Location = new System.Drawing.Point(12, 123);
            this.MaxQueryButton.Name = "MaxQueryButton";
            this.MaxQueryButton.Size = new System.Drawing.Size(325, 26);
            this.MaxQueryButton.TabIndex = 7;
            this.MaxQueryButton.Text = "Запрос 2: Максимальный элемент";
            this.MaxQueryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaxQueryButton.UseVisualStyleBackColor = true;
            // 
            // RangeQueryButton
            // 
            this.RangeQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RangeQueryButton.Location = new System.Drawing.Point(12, 155);
            this.RangeQueryButton.Name = "RangeQueryButton";
            this.RangeQueryButton.Size = new System.Drawing.Size(325, 26);
            this.RangeQueryButton.TabIndex = 8;
            this.RangeQueryButton.Text = "Запрос 3: Диапазон значений";
            this.RangeQueryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RangeQueryButton.UseVisualStyleBackColor = true;
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.Location = new System.Drawing.Point(12, 187);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(325, 238);
            this.ListBoxItems.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 440);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.RangeQueryButton);
            this.Controls.Add(this.MaxQueryButton);
            this.Controls.Add(this.MinQueryButton);
            this.Controls.Add(this.AscendingSortButton);
            this.Controls.Add(this.DescendingSortButton);
            this.Controls.Add(this.GenerateTheCollectionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CollectionSizeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CollectionSizeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateTheCollectionButton;
        private System.Windows.Forms.Button DescendingSortButton;
        private System.Windows.Forms.Button AscendingSortButton;
        private System.Windows.Forms.Button MinQueryButton;
        private System.Windows.Forms.Button MaxQueryButton;
        private System.Windows.Forms.Button RangeQueryButton;
        private System.Windows.Forms.ListBox ListBoxItems;
    }
}

