using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace text_editor
{
    public partial class Form1 : Form
    {
        public bool createStatus = false;
        public Form1()
        {         
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SaveAs()
        {
            saveFileDialog1.Filter = "Text|*.txt|All|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                try
                {
                    SaveToFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveToFile(string filePath)
        {
            try
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                this.Text = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text) || createStatus)
            {
                SaveAs();
                this.createStatus = false;
            }
            else
            {
                SaveToFile(this.Text);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    if (Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                        this.Text = filePath;
                        saveButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Непідтримуваний формат файлу. Виберіть файл з розширенням .txt", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла помилка при завантаженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            saveButton.Visible = true;
            this.Text = "New file";
            this.createStatus = true;
        }
    }
}
