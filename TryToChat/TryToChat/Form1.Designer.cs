namespace TryToChat
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipTextField = new System.Windows.Forms.TextBox();
            this.remPortTextField = new System.Windows.Forms.TextBox();
            this.localPortTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.messageField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.ListBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipTextField);
            this.groupBox1.Controls.Add(this.remPortTextField);
            this.groupBox1.Controls.Add(this.localPortTextField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры соединения";
            // 
            // ipTextField
            // 
            this.ipTextField.Location = new System.Drawing.Point(128, 75);
            this.ipTextField.Name = "ipTextField";
            this.ipTextField.Size = new System.Drawing.Size(100, 20);
            this.ipTextField.TabIndex = 5;
            // 
            // remPortTextField
            // 
            this.remPortTextField.Location = new System.Drawing.Point(128, 49);
            this.remPortTextField.Name = "remPortTextField";
            this.remPortTextField.Size = new System.Drawing.Size(100, 20);
            this.remPortTextField.TabIndex = 4;
            // 
            // localPortTextField
            // 
            this.localPortTextField.Location = new System.Drawing.Point(128, 19);
            this.localPortTextField.Name = "localPortTextField";
            this.localPortTextField.Size = new System.Drawing.Size(100, 20);
            this.localPortTextField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Удаленный IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Удаленный порт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Локальный порт";
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(264, 72);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(89, 50);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Подключиться";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // messageField
            // 
            this.messageField.Location = new System.Drawing.Point(13, 343);
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(240, 20);
            this.messageField.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(264, 340);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(89, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // textArea
            // 
            this.textArea.FormattingEnabled = true;
            this.textArea.Location = new System.Drawing.Point(13, 130);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(340, 199);
            this.textArea.TabIndex = 4;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(264, 13);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(44, 13);
            this.labelIP.TabIndex = 5;
            this.labelIP.Text = "Ваш IP:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(264, 32);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(40, 13);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "0.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(364, 375);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageField);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(370, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ipTextField;
        private System.Windows.Forms.TextBox remPortTextField;
        private System.Windows.Forms.TextBox localPortTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox messageField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox textArea;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label ipLabel;

    }
}

