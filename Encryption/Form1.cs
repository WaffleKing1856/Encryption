using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_o.Text);
            MessageBox.Show("Successfully Copied!");
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            string encrypt = txt_e.Text; //Creates Variable from textbox's string
            int ran = RandomNumber(1, 11); //generates a random number from 1-10
            DoEncryption(encrypt, ran); //Function encryption
            

        }


        public string SecretCode(int x)
        {
            string done = null;
            //simple conversion from number to 
            //random phrase

            if(x == 1)
            {
                done = "lol";
            }
            else if(x == 2)
            {
                done = "oof";
            }
            else if(x == 3)
            {
                done = "epic";
            }
            else if(x == 4)
            {
                done = "dab";
            }
            else if(x == 5)
            {
                done = "whip";
            }
            else if(x == 6)
            {
                done = "wes";
            }
            else if (x == 7)
            {
                done = "minecraft";
            }
            else if (x == 8)
            {
                done = "code";
            }
            else if (x == 9)
            {
                done = "gamer";
            }
            else if (x == 10)
            {
                done = "roblox";
            }

            return done;
        }

        private void DoEncryption(string encrypt, int ran)
        {
            string final = ""; //variable declaration
            for(int i = 0; i < encrypt.Length; i++) //For loop to check every charecter 
            {
                int x = encrypt[i]; //takes the char value of every index position
                x += ran; //Adds the random number to the char value
                Char y = (char)x; // converting back to a letter 
                string f = y.ToString(); //converting the char to a string 
                final = final + f; //adding the string together with eveything else
                
            }
            txt_codeO.Text = SecretCode(ran); //Calls the function to change the number into a secret word and add text 
            txt_o.Text = final; //adds the text to the textbox where the output is

        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            string code = txt_code.Text; //Creates Variable from the code textbox
            string toDecrypt = text_d.Text; //Creates Variable from the encrypted text
            DoDecryption(code, toDecrypt); //Calls decryption function
        }

        private void DoDecryption(string inC, string toD)
        {
            string final = ""; //Variable delaration
            int code = SecretBack(inC); //calls the oposite of the number to phrase converter
            for (int i = 0; i < toD.Length; i++) //Does these steps to every charecter
            {
                int temp = toD[i]; //creates a temporary variable of every index in the word
                                   //and converts to char value
                temp -= code; //subtract the code from the char value
                final += (char)temp; //creates a final string for the decrypted phrase
            }
            txt_o.Text = final; //sets the textbox equal to the final phrase
            
        }

        public int SecretBack(string code)
        {
            int done = 0; //simple if statements converting phrases back to numbers

            if(code == "lol")
            {
                done = 1;
            }
            else if(code == "oof")
            {
                done = 2;
            }
            else if (code == "epic")
            {
                done = 3;
            }
            else if (code == "dab")
            {
                done = 4;
            }
            else if (code == "whip")
            {
                done = 5;
            }
            else if (code == "wes")
            {
                done = 6;
            }
            else if (code == "minecraft")
            {
                done = 7;
            }
            else if (code == "code")
            {
                done = 8;
            }
            else if (code == "gamer")
            {
                done = 9;
            }
            else if (code == "roblox")
            {
                done = 10;
            }
            return done;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_codeO.ResetText(); //Clears the Bottom output box
            txt_o.ResetText(); //Clears the Top output box
        }
    }
}
