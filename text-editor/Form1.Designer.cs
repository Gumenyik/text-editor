namespace text_editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            createButton = new Button();
            exitButton = new Button();
            openButton = new Button();
            saveButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(createButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(openButton);
            panel1.Controls.Add(saveButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(63, 353);
            panel1.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Azure;
            createButton.Cursor = Cursors.Hand;
            createButton.Font = new Font("Stylus BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.ForeColor = Color.Black;
            createButton.Location = new Point(-14, 97);
            createButton.Name = "createButton";
            createButton.Size = new Size(91, 37);
            createButton.TabIndex = 3;
            createButton.Text = "CREATE";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Azure;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Dock = DockStyle.Bottom;
            exitButton.Font = new Font("Stylus BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(0, 316);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(63, 37);
            exitButton.TabIndex = 2;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // openButton
            // 
            openButton.BackColor = Color.Azure;
            openButton.Cursor = Cursors.Hand;
            openButton.Font = new Font("Stylus BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openButton.ForeColor = Color.Black;
            openButton.Location = new Point(-14, 54);
            openButton.Name = "openButton";
            openButton.Size = new Size(91, 37);
            openButton.TabIndex = 1;
            openButton.Text = "OPEN";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Azure;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Font = new Font("Stylus BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(-14, 140);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 37);
            saveButton.TabIndex = 0;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(63, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(513, 353);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 353);
            ControlBox = false;
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            Name = "Form1";
            ShowIcon = false;
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button saveButton;
        private Button openButton;
        private Button createButton;
        private Button exitButton;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
    }
}
