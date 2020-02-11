using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiragana_Training
{
    public partial class KanaTraining : Form
    {
        public KanaTraining()
        {

            InitializeComponent();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] Words = new string[] { "いもうと", "ゆうびんきょうく", "おはよう", "こうえん", "たいへん", "やわらかい", "わかる", "おんな", "にほん", "あぶない", "いそがしい", "ちゅうごくご", "いりぐち", "ごぜん", "だいがく", "かぞく", "はっぱ", "りょうり", "たべもの", "ざっし", "しょうじょ", "きょうだい" };
            int i = random.Next(1, Words.Length);
            OutputHira.Text = Words[i];
            string[] Romanji = new string[] { "imouto", "yuubinkyou", "ohayou", "kouen","taihen", "yawarakai", "wakaru", "onna", "nihon", "abunai", "isogashii", "chogokugo", "iriguchi", "gozen", "daigaku", "kazoku", "happa", "ryouri","tabemono","zasshi","shojo","kyoudai"};
            htoroma.Text = Romanji[i];
            string[] Traduzione = new string[] { "Sister", "Post Office", "Good Morning", "Park","Great","Soft","Understand","Woman","Japan","Dangerus","busy","Chinese Lenguage","Entrance","Morning","Universitì","Family","leaf","Dish","Food","magazine","Girl","Brothers"};
            traduzioneh.Text = Traduzione[i];

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] HWords = new string[] { "いもうと", "ゆうびんきょうく", "おはよう", "こうえん", "たいへん", "やわらかい", "わかる", "おんな", "にほん", "あぶない", "いそがしい", "ちゅうごくご", "いりぐち", "ごぜん", "だいがく", "かぞく", "はっぱ", "りょうり", "たべもの", "ざっし", "しょうじょ", "きょうだい" };
            int i = random.Next(1, HWords.Length);
            OutputHira.Text = HWords[i];
            string[] KWords = new string[] {"セーフ","ハイテク","ホット","ハウス","コーヒ","ヘアー","ハーフ","ハート", "ヒーター","ホッケ","ナイフ","ハット","ハニー", "サーカス", "シー", "ケース", "セクシー", "アクセス", "キス", "ソース" };
            OutputKata.Text = KWords[i];


        }

        private void RichTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Inputhira.Text = "";
            Outputtranshira.Text = "";
            Random random = new Random();
            string[] HWords = new string[] { "いもうと", "ゆうびんきょうく", "おはよう", "こうえん", "たいへん", "やわらかい", "わかる", "おんな", "にほん", "あぶない", "いそがしい", "ちゅうごくご", "いりぐち", "ごぜん", "だいがく", "かぞく", "はっぱ", "りょうり", "たべもの", "ざっし", "しょうじょ", "きょうだい" };
            int i = random.Next(1, HWords.Length);
            OutputHira.Text = HWords[i];

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] KWords = new string[] { "セーフ", "ハイテク", "ホット", "ハウス", "コーヒ", "ヘアー", "ハーフ", "ハート", "ヒーター", "ホッケ", "ナイフ", "ハット", "ハニー", "サーカス", "シー", "ケース", "セクシー", "アクセス", "キス", "ソース" };
            int i = random.Next(1, KWords.Length);
            OutputKata.Text = KWords[i];
            string[] RKata = new string[] { "Sefu", "haiteku", "hotto", "hausu", "kohi", "hea", "hafu", "hato", "hita","hokke","naifu","hatto","hani","sakasu","shi","kesu","sekushi","akusesu","kisu","sosu"};
            ktoroma.Text = RKata[i];
            string[] Tkata = new string[] {"safe","high tech","hot","House","Coffee","Hair","half","heart","heater","Hockey","knife","hat","honey","Circus","Sea","Case","Sexy","Access","Kiss","Sauce"};
            traduzionek.Text = Tkata[i];
        } 




        private void Button4_Click(object sender, EventArgs e)
        {
            Outputtradkata.Text = "";
            inputkata.Text = "";
            Random random = new Random();
            string[] KWords = new string[] {"セーフ","ハイテク","ホット","ハウス","コーヒ","ヘアー","ハーフ","ハート","ヒーター","ホッケ","ナイフ","ハット","ハニー","サーカス", "シー", "ケース", "セクシー", "アクセス", "キス", "ソース" };
            int i = random.Next(1, KWords.Length);
            OutputKata.Text = KWords[i];

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Inputhira.Text == htoroma.Text)
            {
                Outputtranshira.Text = traduzioneh.Text;
            }
            else
            {
                Outputtranshira.Text = "! TRY AGAIN !";
            }
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Inputkata_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckKata_Click(object sender, EventArgs e)
        {
            if (inputkata.Text == ktoroma.Text)
            {
                Outputtradkata.Text = traduzionek.Text;
            }
            else
            {
                Outputtradkata.Text = "! TRY AGAIN !";
            }
        }

        private void Outputtradkata_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ktoroma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
