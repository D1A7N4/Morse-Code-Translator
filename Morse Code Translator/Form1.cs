using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Morse_Code_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_To_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int i = 0; i < TBX_InputTo.Text.Length; i++)
            {
                output = output + toMorseCode(TBX_InputTo.Text[i]);
            }
            TBX_OutputTo.Text = output;
        }
        private void BTN_From_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int i = 0; i < TBX_InputFrom.Text.Length; i++)
            {
                output = output + fromMorseCode(TBX_InputFrom.Text[i]);
            }
            TBX_OutputFrom.Text = output;
        }
        string toMorseCode(char character)
        {

        }
        string fromMorseCode(char character)
        {

        }
    }
}
