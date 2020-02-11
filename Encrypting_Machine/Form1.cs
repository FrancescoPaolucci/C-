using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encrypting_Machine
{
    public partial class DecryptoKING : Form
    {
        //Declaring variables
        string userInput; 
        string otherKey;
        string finalString; 

        // Declaring variables for decrypting
        string record; 
        string word;
        int rangeKey = 10;
        string decryptedWord;
        int decryptkey;
        public DecryptoKING()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Getting the user password
           userInput = textBox1.Text;
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            //Getting the user key
            otherKey = keyBox.Text;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //Transforming the input into a char array
            char[] userToChar = userInput.ToCharArray();
            char[] encArr = new char[userToChar.Length];

            //Converting the key to variable
            int keyValue = Convert.ToInt32(otherKey);

            //Looping in order to encnrypt the password
            for (int i = 0; i < userToChar.Length; i++)
            {
                encArr[i] = (userToChar[i]);
                for (int j = 0; j < keyValue; j++)
                {
                    encArr[i]++;
                }

            }

            //Making the char array obtained from the for a string
            finalString = new string(encArr);
            encryptedPass.Text = finalString;

            //Disabling to modify the user input
            textBox1.ReadOnly = true;
            keyBox.ReadOnly = true;
        }

        private void EncryptedPass_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void TryAgain_Click(object sender, EventArgs e)
        {
            //Enabling the form again after pressing the botton
            textBox1.ReadOnly = false;
            keyBox.ReadOnly = false;

            //Clearing the text boxes from old stuff
            textBox1.Clear();
            keyBox.Clear();
            encryptedPass.Clear();
            
        }
        // function that hide the encryption page and open the decryption
        private void Hideencrypt()
        {
            EnterPass.Hide();
            textBox1.Hide();
            Key.Hide();
            keyBox.Hide();
            Start.Hide();
            labelOut.Hide();
            encryptedPass.Hide();
            tryAgain.Hide();
            Cryptoking.Hide();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hideencrypt();
            ShowDecrypt();

        }
        //function that reshow all the elements again.
        private void Showencrypt()
        {
            EnterPass.Show();
            textBox1.Show();
            Key.Show();
            keyBox.Show();
            Start.Show();
            labelOut.Show();
            encryptedPass.Show();
            tryAgain.Show();
            Cryptoking.Show();
        }
        //Open encrypt page button
        private void button1_Click(object sender, EventArgs e)
        {
            HideDecrypt();
            Showencrypt();
        }
        //Hyde Decrypt function
        private void HideDecrypt()
        {
            DecryptLable.Hide();
            DecrypText.Hide();
            DecryptLablekey.Hide();
            DecryptKey.Hide();
            DecryptButton.Hide();
            Decrypttextbox.Hide();
            Decryptresoultbox.Hide();
            Decryptnew.Hide();
            Decryptking.Hide();
           
        }
        // Show Decrypt function
        private void ShowDecrypt()
        {
            DecryptLable.Show();
            DecrypText.Show();
            DecryptLablekey.Show();
            DecryptKey.Show();
            DecryptButton.Show();
            Decrypttextbox.Show();
            Decryptresoultbox.Show();
            Decryptnew.Show();
            Decryptking.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideDecrypt(); 
        }

        private void DecrypText_TextChanged(object sender, EventArgs e)
        {
            word = DecrypText.Text.ToLower();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            FileStream inFile = new FileStream(@"D:\UNI\Programmazione\Encrypting_Machine\Dizionario.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            record = reader.ReadToEnd();
            char[] letts = new char[word.Length];
            for (int i = 0; i < rangeKey; i++)
            {
                string value = inString(incOne(let(word), i));

                while (record != value)
                {
                    if (record.Contains(value))
                    {
                        decryptedWord = value;

                        decryptkey = i ;
                        break;
                    }
                    else
                    {
                        break;
                        
                    }
                    
                }
            }
            Decryptresoultbox.Text = decryptedWord;
            DecryptKey.Text = Convert.ToString(decryptkey);

            DecrypText.ReadOnly = true;

        }
        // General Functions for Dencrypting
        static char[] let(string userStr) // Function that convert string to array userStr= string parameter
        {
            char[] letts = userStr.ToCharArray();

            for (int i = 0; i < userStr.Length; i++)
            {
                letts[i] = userStr[i];
            }

            return letts;
        }

        static char[] incOne(char[] convToS, int key) // Decrypt function that decrese by 1 every char of the array 
        {
            for (int j = 0; j < convToS.Length; j++)
            {
                for (int i = 0; i < key; i++)
                {
                    convToS[j]--;

                }
            }

            return convToS;
        }

        static string inString(char[] fromChar) // function that retourn the array in string
        {
            string converted = new string(fromChar);
            return converted;
        }

        private void Decryptresoultbox_TextChanged(object sender, EventArgs e)
        {
            //Decryptresoultbox.Text = decryptedWord; 
        }

        private void DecryptKey_TextChanged(object sender, EventArgs e)
        {
            //DecryptKey.Text = Convert.ToString(decryptkey);
        }

        private void Decryptnew_Click(object sender, EventArgs e)
        {
            DecrypText.Clear();
            DecryptKey.Clear();
            Decryptresoultbox.Clear();
            DecrypText.ReadOnly = false;
        }

        private void Decryptnew_Click_1(object sender, EventArgs e)
        {
            DecrypText.Clear();
            DecryptKey.Clear();
            Decryptresoultbox.Clear();
            DecrypText.ReadOnly = false;
            decryptedWord = "   ! Word not found ! ";
            decryptkey = 0;
        }
    }
}



