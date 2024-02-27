using SqlInjectionChecker;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SqlInjectionChecker.SqlInjectionChecker.IsSafeString(textBox1.Text))
            {
                MessageBox.Show("H?p l?");
            }
            else
            {
                MessageBox.Show("Không h?p l?");
            }
        }
    }
}
