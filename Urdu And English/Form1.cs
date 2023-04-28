using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urdu_And_English
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            GetCharacter("Q", " ق ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            GetCharacter("A", " ا ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
         GetCharacter("B" ,"ب");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCharacter("C", "ث");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCharacter("D", "د");
        }

        private void GetCharacter(string englishChar,string urduChar)
        {
            EnglishTextBox.Text += englishChar;

            UrduTextBox.Text += urduChar;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            GetCharacter("E", " ع ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCharacter("F", " ف ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetCharacter("G", "  گ ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCharacter("H", " ھ ");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetCharacter("I", "ی ");  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetCharacter("J", " ج ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GetCharacter("K",  "ک  ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetCharacter("L", " ل ");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetCharacter("M", " م ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetCharacter("N", " ن ");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetCharacter("O", " ہ ");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetCharacter("P", " پ ");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetCharacter("R", " ر "); 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GetCharacter("S", "  س ");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            GetCharacter("T", " ٹ ");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            GetCharacter("U", " ء "); 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetCharacter("V", " ط  ");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            GetCharacter("W", " و ");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            GetCharacter("X", " خ ");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GetCharacter("Y", " ے ");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GetCharacter("Z", " ذ "); 
        }

        private void button27_Click(object sender, EventArgs e)
        {
            EnglishTextBox.Text = "";
            UrduTextBox.Text = "";
        }
    }
}
