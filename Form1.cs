namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent(); // Класс формы инициализируется компонентами
        }

        private void TextChange(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Нажали")
                (sender as Button).Text = "Нажми";
            else
                (sender as Button).Text = "Нажали";
            // tbTest.Text += (sender as Button).Name + Environment.NewLine;            
            if (chBTest.Checked)
                tbTest.Text += (sender as Button).Name + Environment.NewLine;
            else
                tbTest.Text += (sender as Button).Text + Environment.NewLine;
        }

        private void chBTest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        string fileName;

        private void bntOpenFail_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName= openFileDialog1.FileName; 
            }
            tbTest.Text = fileName + Environment.NewLine;
            StreamReader sr = new StreamReader(fileName);
            while(!sr.EndOfStream)
            {
                tbTest.Text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
        }
    }
}
