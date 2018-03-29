namespace CopyFile
{
    partial class CopyingFileForm
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.copyingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(30, 25);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(80, 25);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "Откуда";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(30, 94);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(55, 25);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "Куда";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(130, 25);
            this.fromTextBox.Multiline = true;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(327, 35);
            this.fromTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(130, 94);
            this.toTextBox.Multiline = true;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(327, 35);
            this.toTextBox.TabIndex = 3;
            // 
            // fromButton
            // 
            this.fromButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromButton.Location = new System.Drawing.Point(494, 25);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(99, 35);
            this.fromButton.TabIndex = 4;
            this.fromButton.Text = "Файл";
            this.fromButton.UseVisualStyleBackColor = true;
            // 
            // toButton
            // 
            this.toButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toButton.Location = new System.Drawing.Point(494, 94);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(99, 35);
            this.toButton.TabIndex = 5;
            this.toButton.Text = "Файл";
            this.toButton.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(422, 33);
            this.progressBar.TabIndex = 6;
            // 
            // copyingButton
            // 
            this.copyingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyingButton.Location = new System.Drawing.Point(463, 169);
            this.copyingButton.Name = "copyingButton";
            this.copyingButton.Size = new System.Drawing.Size(143, 33);
            this.copyingButton.TabIndex = 7;
            this.copyingButton.Text = "Копирование";
            this.copyingButton.UseVisualStyleBackColor = true;
            // 
            // CopyingFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 228);
            this.Controls.Add(this.copyingButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.fromButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CopyingFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyingFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button copyingButton;
    }
}

