using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace notepad
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            filename = "";
            UpdateTextWithTitle();
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            richTextBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            SaveUnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Вы закрыли открытье файлов");
                }
            }
            UpdateTextWithTitle();
        }

        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Вы закрыли сохранение");
            }
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

        private void OntextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "* " + this.Text;
            }
            toolStripStatusLabel2.Text = $"Строка: {richTextBox1.Lines.Length}";
            toolStripStatusLabel3.Text = $"Столбец: {richTextBox1.TextLength}";
        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
                this.Text = filename + " - Maypad";
            else
                this.Text = "Безымянный - Maypad";
        }

        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            
            {
                DialogResult result = MessageBox.Show("Сохраните срочно файл! Так-как если вы не сохранитесь сейчас, то важные данные пропадут с блокнота. Нажмите ''Да'' чтобы сохраниться.", "Важно!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

            private void On(object sender, FormClosedEventArgs e)
        {

        }


        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
            contextMenuStrip1.BackColor = Color.Black;
            contextMenuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.Black;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = Color.White;
            toolStripStatusLabel2.ForeColor = Color.Black;
            toolStripStatusLabel3.ForeColor = Color.Black;
            toolStripStatusLabel2.BackColor = Color.Transparent;
            toolStripStatusLabel3.BackColor = Color.Transparent;
        }

        private void темнаяHackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.LimeGreen;
            richTextBox1.BackColor = Color.Black;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.LightSkyBlue;
            contextMenuStrip1.BackColor = Color.Black;
            contextMenuStrip1.ForeColor = Color.LimeGreen;
            statusStrip1.BackColor = Color.Black;
            toolStripStatusLabel2.ForeColor = Color.LimeGreen;
            toolStripStatusLabel3.ForeColor = Color.LimeGreen;
        }

        private void темаMSMaydilsielStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DarkSlateGray;
            menuStrip1.BackColor = Color.DarkViolet;
            menuStrip1.ForeColor = Color.White;
            contextMenuStrip1.BackColor = Color.DarkViolet;
            contextMenuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.DarkViolet;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
        }

        private void темаErtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.DarkOrange;
            menuStrip1.BackColor = Color.SlateGray;
            menuStrip1.ForeColor = Color.Yellow;
            contextMenuStrip1.BackColor = Color.SlateGray;
            contextMenuStrip1.ForeColor = Color.Yellow;
            statusStrip1.BackColor = Color.SlateGray;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
        }

        private void сераяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Gold;
            richTextBox1.BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ForeColor = Color.Gold;
            contextMenuStrip1.BackColor = Color.DimGray;
            contextMenuStrip1.ForeColor = Color.Gold;
            statusStrip1.BackColor = Color.DimGray;
            toolStripStatusLabel2.ForeColor = Color.Yellow;
            toolStripStatusLabel3.ForeColor = Color.Yellow;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            if (myFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = myFont.Font;
            }
        }

        private void вставитьДатуИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void найтиИЗаменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemEventArgs e)
        {

        }

        private void statusStrip1_TextChanged(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void strokiLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void strokiLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Внимание! Внесённые вами данные не сохранены, хотите сейчас сохранить? ", "Сохранение файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void маштабToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mstandart()
        {
            
        }

        private void m150()
        {
            
        }

        private void mstandart(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f;
        }

        private void m150(object sender, EventArgs e)
        {
           richTextBox1.ZoomFactor = 1.5f;
        }

        private void m200(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2.0f;
        }

        private void m250(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2.5f;
        }

        private void m300(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 3.0f;
        }

        private void minus80(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.8f;
        }

        private void minus60(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.6f;
        }

        private void minus40(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.4f;
        }

        private void minus20(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.2f;
        }
    }
}

