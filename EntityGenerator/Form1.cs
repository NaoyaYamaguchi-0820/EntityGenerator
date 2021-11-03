using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Service service = new Service();

            var textList = BeforeTextBox.Text.Replace("\r\n", "\n").Split(new[] { '\n', '\r' }); ;

            StringBuilder sb = new StringBuilder();

            foreach (var text in textList)
            {
                sb.Append(service.Convert(text));
            }

            AfterTextBox.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BeforeTextBox.Text = "コメント,定義名,属性";
        }
    }
}
