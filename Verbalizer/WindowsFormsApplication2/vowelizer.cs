using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelizerApp
{
    public partial class Vowelizer : Form
    {
        public Vowelizer()
        {
            InitializeComponent();
        }

        private void Verbalizer_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();

        }
        private void btnBoldVowels_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            var make = new FormatVowelsBold();
            richTextBox1.Rtf = make.TurnVowelBold(input);
        }
    }
}