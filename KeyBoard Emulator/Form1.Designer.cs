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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_ForTextPreview = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadTextFromFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeedList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncodingList = new System.Windows.Forms.ComboBox();
            this.OCR_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LstmOnly = new System.Windows.Forms.CheckBox();
            this.toolTip_Lstm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(125, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Активировать хоткей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EmulateButton_Click);
            // 
            // TextBox_ForTextPreview
            // 
            this.TextBox_ForTextPreview.DetectUrls = false;
            this.TextBox_ForTextPreview.Location = new System.Drawing.Point(12, 162);
            this.TextBox_ForTextPreview.Name = "TextBox_ForTextPreview";
            this.TextBox_ForTextPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBox_ForTextPreview.Size = new System.Drawing.Size(378, 143);
            this.TextBox_ForTextPreview.TabIndex = 2;
            this.TextBox_ForTextPreview.Text = "";
            this.TextBox_ForTextPreview.TextChanged += new System.EventHandler(this.TextBox_ForTextPreview_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст";
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
            this.label1.Location = new System.Drawing.Point(9, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Эмуляция: не запущена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
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
            "очень быстро",
            "ноль задержки"});
            this.SpeedList.Location = new System.Drawing.Point(15, 106);
            this.SpeedList.Name = "SpeedList";
            this.SpeedList.Size = new System.Drawing.Size(109, 21);
            this.SpeedList.TabIndex = 8;
            this.SpeedList.SelectedIndexChanged += new System.EventHandler(this.SpeedList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 88);
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
            this.EncodingList.Location = new System.Drawing.Point(146, 106);
            this.EncodingList.Name = "EncodingList";
            this.EncodingList.Size = new System.Drawing.Size(115, 21);
            this.EncodingList.TabIndex = 10;
            this.EncodingList.SelectedIndexChanged += new System.EventHandler(this.EncodingList_SelectedIndexChanged);
            // 
            // OCR_btn
            // 
            this.OCR_btn.Location = new System.Drawing.Point(154, 41);
            this.OCR_btn.Name = "OCR_btn";
            this.OCR_btn.Size = new System.Drawing.Size(75, 23);
            this.OCR_btn.TabIndex = 11;
            this.OCR_btn.Text = "Чик";
            this.OCR_btn.UseVisualStyleBackColor = true;
            this.OCR_btn.Click += new System.EventHandler(this.OCR_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Попробовать текст с экрана";
            // 
            // LstmOnly
            // 
            this.LstmOnly.AutoSize = true;
            this.LstmOnly.Checked = true;
            this.LstmOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LstmOnly.Location = new System.Drawing.Point(308, 45);
            this.LstmOnly.Name = "LstmOnly";
            this.LstmOnly.Size = new System.Drawing.Size(69, 17);
            this.LstmOnly.TabIndex = 13;
            this.LstmOnly.Tag = "";
            this.LstmOnly.Text = "LstmOnly";
            this.LstmOnly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 391);
            this.Controls.Add(this.LstmOnly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OCR_btn);
            this.Controls.Add(this.EncodingList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpeedList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadTextFromFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_ForTextPreview);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bzdoom keyboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextBox_ForTextPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadTextFromFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SpeedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EncodingList;
        private System.Windows.Forms.Button OCR_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LstmOnly;
        private System.Windows.Forms.ToolTip toolTip_Lstm;
    }
}

