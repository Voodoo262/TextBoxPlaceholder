using System.Windows.Forms;

namespace Com.RobFaust.Common.UserInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFocus_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show($"textBox1={textBox1.Text}\ntextBox2={textBox2.Text}\ntextBox3={textBox3.Text}\ntextBox4={textBox4.Text}");
        }
    }
}
