namespace KeyBoard_Emulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadTextFromFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeedList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncodingList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(125, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Активировать хоткей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EmulateButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(12, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(378, 143);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст из файла";
            // 
            // loadTextFromFile
            // 
            this.loadTextFromFile.Location = new System.Drawing.Point(15, 41);
            this.loadTextFromFile.Name = "loadTextFromFile";
            this.loadTextFromFile.Size = new System.Drawing.Size(97, 23);
            this.loadTextFromFile.TabIndex = 5;
            this.loadTextFromFile.Text = "Выбор файла";
            this.loadTextFromFile.UseVisualStyleBackColor = true;
            this.loadTextFromFile.Click += new System.EventHandler(this.LoadTextFromFile);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выбор файла с текстом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Эмуляция: не запущена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость печати";
            // 
            // SpeedList
            // 
            this.SpeedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedList.FormattingEnabled = true;
            this.SpeedList.Items.AddRange(new object[] {
            "медленно",
            "средне",
            "быстро",
            "очень быстро (опасно)"});
            this.SpeedList.Location = new System.Drawing.Point(143, 43);
            this.SpeedList.Name = "SpeedList";
            this.SpeedList.Size = new System.Drawing.Size(109, 21);
            this.SpeedList.TabIndex = 8;
            this.SpeedList.SelectedIndexChanged += new System.EventHandler(this.SpeedList_SelectedIndexChanged);
            this.SpeedList.SelectedIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кодировка текста";
            // 
            // EncodingList
            // 
            this.EncodingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingList.FormattingEnabled = true;
            this.EncodingList.Items.AddRange(new object[] {
            "utf-8",
            "Windows-1251",
            "Windows-1252",
            "koi8-r",
            "ISO-8859-5"});
            this.EncodingList.Location = new System.Drawing.Point(273, 43);
            this.EncodingList.Name = "EncodingList";
            this.EncodingList.Size = new System.Drawing.Size(115, 21);
            this.EncodingList.TabIndex = 10;
            this.EncodingList.SelectedIndex = 1;
            this.EncodingList.SelectedIndexChanged += new System.EventHandler(this.EncodingList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 341);
            this.Controls.Add(this.EncodingList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpeedList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadTextFromFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bzdoom keyboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadTextFromFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SpeedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EncodingList;
    }
}

