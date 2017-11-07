using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace more_strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quote = "The university is made up of electrons, protons, neutrons, and morons.";    // credit: keziah

            int aInt = 65;
            char aChar = (char)aInt;
            Console.WriteLine(aChar);

            char bChar = 'B';
            int bInt = (int)bChar;
            Console.WriteLine(bInt);

            bool test = ('B' > 'A');
            Console.WriteLine(test);


            string str = "Hello";
            string result = "";
            for(int i = 0; i < str.Length; i++)
            {
                // put an if
                char letter = str[i];
                int intLetter = (int)letter;
                int upperCaseIntLetter = intLetter - 32;
                char upperCaseLetter = (char)upperCaseIntLetter;
                result += upperCaseLetter;
            }
            Console.WriteLine(result);
        }
    }
}
