using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KeyBoard_Emulator
{
    public partial class Form1 : Form
    {
        private int minTimeType;
        private int maxTimeType;

        private string TextFromTextFile;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            MessageBox.Show("Хоткеи:\nctrl+alt+r - начать эмуляцию набора текста;\nctrl+alt+d - экстренное завершение программы", "Хоткеи");
        }

        private void EmulateButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Нет текста для эмуляции", "Нет текста");
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
            HotkeyManager.Current.Remove("Start Emulation");
            HotkeyManager.Current.Remove("Stop Emulation");
            MessageBox.Show("Change Da World… My Final Message. Goodbye");
        }

        private void emergency_exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Emulation()
        {
            try
            {
                Random random = new Random();
                foreach (char letter in TextFromTextFile)
                {
                    SendKeys.SendWait(letter.ToString());
                    Thread.Sleep(random.Next(minTimeType, maxTimeType));
                }
            }
            catch
            {
                label1.Text = "Эмуляция: завершена с ошибкой";
                MessageBox.Show("Прозошла ошибка и текст был проэмулирован неполностью или не проэмулирован вовсе.", "Ошибка");
                Application.Exit();
            }
            finally
            {
                label1.Text = "Эмуляция: завершена";
                MessageBox.Show("Текст проэмулирован.", "Эмуляция завершена");
            }
        }

        private void LoadTextFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT files|*.txt";
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Не смог получить файл, попробуй еще раз.", "Чет пошло не так");
                return;
            }
            TextFromTextFile = File.ReadAllText(openFileDialog.FileName);
            MessageBox.Show("Файл загружен и программа готова к эмуляции.", "Файл загружен");
            richTextBox1.Text = TextFromTextFile;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
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
            }
        }
    }
}