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
                output += toMorseCode(TBX_InputTo.Text.ToLower()[i].ToString());
            }
            TBX_OutputTo.Text = output;
        }
        private void BTN_From_Click(object sender, EventArgs e)
        {
            string output = "";
            string[] input = TBX_InputFrom.Text.ToLower().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                output += fromMorseCode(input[i]);
            }
            TBX_OutputFrom.Text = output;
        }
        string toMorseCode(string character)
        {
            string[] alphabet = new string[38];
            string[] morse = new string[38];
            alphabet[0] = "a";
            alphabet[1] = "b";
            alphabet[2] = "c";
            alphabet[3] = "d";
            alphabet[4] = "e";
            alphabet[5] = "f";
            alphabet[6] = "g";
            alphabet[7] = "h";
            alphabet[8] = "i";
            alphabet[9] = "j";
            alphabet[10] = "k";
            alphabet[11] = "l";
            alphabet[12] = "m";
            alphabet[13] = "n";
            alphabet[14] = "o";
            alphabet[15] = "p";
            alphabet[16] = "q";
            alphabet[17] = "r";
            alphabet[18] = "s";
            alphabet[19] = "t";
            alphabet[20] = "u";
            alphabet[21] = "v";
            alphabet[22] = "w";
            alphabet[23] = "x";
            alphabet[24] = "y";
            alphabet[25] = "z";
            alphabet[26] = "1";
            alphabet[27] = "2";
            alphabet[28] = "3";
            alphabet[29] = "4";
            alphabet[30] = "5";
            alphabet[31] = "6";
            alphabet[32] = "7";
            alphabet[33] = "8";
            alphabet[34] = "9";
            alphabet[35] = "0";
            alphabet[36] = " ";
            alphabet[37] = "";
            morse[0] = ".-";
            morse[1] = "-...";
            morse[2] = "-.-.";
            morse[3] = "-..";
            morse[4] = ".";
            morse[5] = "..-.";
            morse[6] = "--.";
            morse[7] = "....";
            morse[8] = "..";
            morse[9] = ".---";
            morse[10] = "-.-";
            morse[11] = ".-..";
            morse[12] = "--";
            morse[13] = "-.";
            morse[14] = "---";
            morse[15] = ".--.";
            morse[16] = "--.-";
            morse[17] = ".-.";
            morse[18] = "...";
            morse[19] = "-";
            morse[20] = ".--";
            morse[21] = "...-";
            morse[22] = ".--";
            morse[23] = "-..-";
            morse[24] = "-.--";
            morse[25] = "--..";
            morse[26] = ".----";
            morse[27] = "..---";
            morse[28] = "...--";
            morse[29] = "....-";
            morse[30] = ".....";
            morse[31] = "-....";
            morse[32] = "--...";
            morse[33] = "---..";
            morse[34] = "----.";
            morse[35] = "-----";
            morse[36] = "|";
            morse[37] = "";
            int index = Array.IndexOf(alphabet, character);
            if (index != -1)
            {
                return morse[index] + " ";
            }
            else
            {
                MessageBox.Show("Please enter a message to convert consisting of only alphanumeric characters and spaces.");
                return " ";
            }
        }
        string fromMorseCode(string character)
        {
            string[] alphabet = new string[38];
            string[] morse = new string[38];
            alphabet[0] = "a";
            alphabet[1] = "b";
            alphabet[2] = "c";
            alphabet[3] = "d";
            alphabet[4] = "e";
            alphabet[5] = "f";
            alphabet[6] = "g";
            alphabet[7] = "h";
            alphabet[8] = "i";
            alphabet[9] = "j";
            alphabet[10] = "k";
            alphabet[11] = "l";
            alphabet[12] = "m";
            alphabet[13] = "n";
            alphabet[14] = "o";
            alphabet[15] = "p";
            alphabet[16] = "q";
            alphabet[17] = "r";
            alphabet[18] = "s";
            alphabet[19] = "t";
            alphabet[20] = "u";
            alphabet[21] = "v";
            alphabet[22] = "w";
            alphabet[23] = "x";
            alphabet[24] = "y";
            alphabet[25] = "z";
            alphabet[26] = "1";
            alphabet[27] = "2";
            alphabet[28] = "3";
            alphabet[29] = "4";
            alphabet[30] = "5";
            alphabet[31] = "6";
            alphabet[32] = "7";
            alphabet[33] = "8";
            alphabet[34] = "9";
            alphabet[35] = "0";
            alphabet[36] = " ";
            alphabet[37] = "";
            morse[0] = ".-";
            morse[1] = "-...";
            morse[2] = "-.-.";
            morse[3] = "-..";
            morse[4] = ".";
            morse[5] = "..-.";
            morse[6] = "--.";
            morse[7] = "....";
            morse[8] = "..";
            morse[9] = ".---";
            morse[10] = "-.-";
            morse[11] = ".-..";
            morse[12] = "--";
            morse[13] = "-.";
            morse[14] = "---";
            morse[15] = ".--.";
            morse[16] = "--.-";
            morse[17] = ".-.";
            morse[18] = "...";
            morse[19] = "-";
            morse[20] = ".--";
            morse[21] = "...-";
            morse[22] = ".--";
            morse[23] = "-..-";
            morse[24] = "-.--";
            morse[25] = "--..";
            morse[26] = ".----";
            morse[27] = "..---";
            morse[28] = "...--";
            morse[29] = "....-";
            morse[30] = ".....";
            morse[31] = "-....";
            morse[32] = "--...";
            morse[33] = "---..";
            morse[34] = "----.";
            morse[35] = "-----";
            morse[36] = "|";
            morse[37] = "";
            int index = Array.IndexOf(morse, character);
            if (index != -1)
            {
                return alphabet[index];
            }
            else
            {
                MessageBox.Show("Please enter a message to convert consisting of only valid morse code letters or numbers using | for spaces between words..");
                return " ";
            }
        }
    }
}
