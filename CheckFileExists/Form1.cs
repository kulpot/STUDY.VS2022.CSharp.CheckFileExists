using System.IO;
using System.Windows.Forms;

namespace CheckFileExists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string path = @"C:\my.log";

            if (!File.Exists(path))
            {
                MessageBox.Show("File Exists!");
            }
        }
    }
}
