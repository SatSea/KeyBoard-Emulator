using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tesseract;

namespace KeyBoard_Emulator
{
    public partial class Form1 : Form
    {
        private int minTimeType;
        private int maxTimeType;

        private Text WritingText = new Text();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            SpeedList.SelectedIndex = 1;
            EncodingList.SelectedIndex = 1;
            toolTip_Lstm.SetToolTip(LstmOnly, "Lstm обработка занимает больше времени на обработку изображения точнее\nраспознавая текст на Английском, но иногда теряет знаки препинания");
            MessageBox.Show("Хоткеи:\nctrl+alt+r - начать эмуляцию набора текста;\nctrl+alt+d - экстренное завершение программы", "Хоткеи");
        }

        private void EmulateButton_Click(object sender, EventArgs e)
        {
            if (TextBox_ForTextPreview.Text.Length == 0)
            {
                MessageBox.Show("Нет текста для эмуляции", "Нет текста", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HotkeyManager.Current.AddOrReplace("Start Emulation", Keys.Control | Keys.Alt | Keys.R, OnHotkeyEmulation);
            HotkeyManager.Current.AddOrReplace("Stop Emulation", Keys.Control | Keys.Alt | Keys.D, emergency_exit);
            label1.Text = "Эмуляция: хоткеи заармированы";
        }

        private void OnHotkeyEmulation(object sender, HotkeyEventArgs e)
        {
            HotkeyManager.Current.Remove("Start Emulation");
            e.Handled = true;
            StartEmulation();
        }

        private void StartEmulation()
        {
            label1.Text = "Эмуляция: запущена";
            Thread.Sleep(150);
            Emulation();
        }

        protected override void OnClosed(EventArgs e)
        {
            this.Hide();
            HotkeyManager.Current.Remove("Start Emulation");
            HotkeyManager.Current.Remove("Stop Emulation");
            MessageBox.Show("Change Da World… My Final Message. Goodbye", "Goodbye");
            Application.Exit();
        }

        private void emergency_exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private string escapeSpecialCharacters()
        {
            string escapedText = "";
            foreach (char letter in WritingText.TextToWrite)
            {
                switch (letter)
                {
                    case '\r':
                        break; // Нам не нужен возрат коретки
                    case '+':
                    case '^':
                    case '%':
                    case '~':
                    case '(':
                    case ')':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                        escapedText += '{' + letter + '}';
                        break;

                    default:
                        escapedText += letter;
                        break;
                }
            }
            return escapedText;
        }

        private void Emulation()
        {
            try
            {
                string escaped_text = escapeSpecialCharacters();
                if (letter_by_letterRB.Checked)
                {
                    letter_by_letter_emulation(escaped_text);
                }
                else
                {
                    if (word_by_wordRB.Checked)
                    {
                        word_by_word_emulation(escaped_text);
                    }
                    else
                    {
                        all_text_emulation(escaped_text);
                    }
                }
            }
            catch
            {
                label1.Text = "Эмуляция: завершена с ошибкой";
                MessageBox.Show("Произошла ошибка и текст был проэмулирован не полностью или не проэмулирован вовсе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                label1.Text = "Эмуляция: завершена";
                MessageBox.Show("Текст проэмулирован.", "Эмуляция завершена");
            }
        }

        private void all_text_emulation(string words)
        {
            SendKeys.SendWait(words);
        }

        private void word_by_word_emulation(string words)
        {
            foreach (string word in words.Split(' '))
            {
                string word_with_space = word + ' ';
                SendKeys.SendWait(word_with_space);
                Thread.Sleep(random.Next(minTimeType, maxTimeType));
            }
        }

        private void letter_by_letter_emulation(string words)
        {
            foreach (char letter in words)
            {
                SendKeys.SendWait(letter.ToString());
                Thread.Sleep(random.Next(minTimeType, maxTimeType));
            }
        }

        private void LoadTextFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT files|*.txt";
            DialogResult dialogResult = openFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            if (dialogResult != DialogResult.OK)
            {
                MessageBox.Show("Не смог получить файл, попробуй еще раз.", "Чет пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WritingText.TextToWrite = File.ReadAllText(openFileDialog.FileName);
            TextBox_ForTextPreview.Text = WritingText.TextToWrite;
            MessageBox.Show("Файл загружен и программа готова к эмуляции.", "Файл загружен");
        }

        private void SpeedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SpeedList.SelectedIndex)
            {
                case 0:
                    minTimeType = 31;
                    maxTimeType = 38;
                    break;

                case 1:
                    minTimeType = 19;
                    maxTimeType = 24;
                    break;

                case 2:
                    minTimeType = 10;
                    maxTimeType = 14;
                    break;

                case 3:
                    minTimeType = 5;
                    maxTimeType = 8;
                    break;

                case 4:
                    minTimeType = 1;
                    maxTimeType = 1;
                    break;
            }
        }

        private void EncodingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            WritingText.Encoding_type = EncodingList.Text;
        }

        private void OCR_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (OverlayForm overlayForm = new OverlayForm())
            {
                if (overlayForm.ShowDialog() == DialogResult.OK)
                {
                    Rectangle selection = overlayForm.Selection;
                    using (Bitmap bitmap = new Bitmap(selection.Width, selection.Height))
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen(selection.Location, Point.Empty, selection.Size);
                        }
                        if (bitmap.Width == 0 || bitmap.Height == 0)
                        {
                            return;
                        }
                        Clipboard.SetImage(bitmap);
                        TesseractEngine ocr = new TesseractEngine("tessdata", "rus+eng", LstmOnly.Checked ? EngineMode.LstmOnly : EngineMode.TesseractAndLstm);
                        var OCRed_img = ocr.Process(bitmap);
                        string recognizedText = OCRed_img.GetText();
                        TextBox_ForTextPreview.Text = recognizedText;
                    }
                }
            }
            this.Show();
        }

        private void TextBox_ForTextPreview_TextChanged(object sender, EventArgs e)
        {
            WritingText.TextToWrite = TextBox_ForTextPreview.Text;
        }
    }

    internal class Text
    {
        private string _TextToWrite;
        private string _Encoding_type;

        public string TextToWrite
        {
            get => EncodingText(_TextToWrite, _Encoding_type);
            set { _TextToWrite = value; }
        }

        public string Encoding_type
        {
            get => _Encoding_type;
            set
            {
                _Encoding_type = value;
            }
        }

        private string EncodingText(string TextToEncode, string Encoding_str)
        {
            return TextToEncode != null ? Encoding.GetEncoding(Encoding_str).GetString(Encoding.Default.GetBytes(TextToEncode)) : null;
        }
    }
}