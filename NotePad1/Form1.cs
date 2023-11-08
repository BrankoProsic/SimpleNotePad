namespace NotePad1
{
    public partial class Form1 : Form
    {
        public IRepository repoColorSave= new SaveFontColor();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want a new file","New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            TextBoxMain.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxMain.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            else if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Error opening file!");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text file|*.txt|Markdown file|*.md|RTF|*.rtf";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, TextBoxMain.Text);
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text flile|*.txt|Markdown file|*.md";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, TextBoxMain.Text);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxMain.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (TextBoxMain.CanUndo == true)
            //{
            //    TextBoxMain.Undo();
            //    TextBoxMain.ClearUndo();
            //}
            //else if (TextBoxMain.Text.Length > 0)
            {
                TextBoxMain.Text = TextBoxMain.Text.Remove(TextBoxMain.Text.Length - 1);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxMain.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxMain.BackColor = colorDialog1.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoColorSave.Save(TextBoxMain, colorDialog1);

            //ColorDialog cd = new ColorDialog(); // instancirao sam da vidim cisto
            //---------------------------------------------------------------------
            //if (colorDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    if (!string.IsNullOrEmpty(TextBoxMain.SelectedText)) // dodao sam menjanje boje selektovanog teksta
            //    {
            //        TextBoxMain.SelectionColor = colorDialog1.Color;
            //    }
            //    else TextBoxMain.ForeColor = colorDialog1.Color;
            //}
        }
    }
}