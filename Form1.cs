using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> RusWords = new Dictionary<string, string>();

        Dictionary<string, string> EngWords = new Dictionary<string, string>();
        Dictionary<string, string> UkrWords = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            RusWords.Add("Новичок", "Новичок");
            RusWords.Add("Любитель", "Любитель");
            RusWords.Add("Профи", "Профи");
            EngWords.Add("Новичок", "Newbie");
            EngWords.Add("Любитель", "Amateur");
            EngWords.Add("Профи", "Pro");
            RusWords.Add("Выберите язык", "Выберите язык");
            RusWords.Add("выберите язык", "выберите язык");
            RusWords.Add("Выберите сложность", "Выберите сложность");
            EngWords.Add("Выберите сложность", "Select difficulty");
            EngWords.Add("Выберите язык", "Select language");
            EngWords.Add("выберите язык", "Select tongue");
            UkrWords.Add("Новичок", "Холоп");
            UkrWords.Add("Любитель", "Любитель");
            UkrWords.Add("Профи", "Профі");
            UkrWords.Add("Выберите язык", "Виберіть мову");
            UkrWords.Add("выберите язык", "Виберіть язик");
            UkrWords.Add("Выберите сложность", "Виберіть складність");

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
        
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1.Text = EngWords["Новичок"];
            button2.Text = EngWords["Любитель"];
            button3.Text = EngWords["Профи"];
            label1.Text = EngWords["Выберите язык"];
            label2.Text = EngWords["выберите язык"];
            label3.Text = EngWords["Выберите сложность"];

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Text = RusWords["Новичок"];
            button2.Text = RusWords["Любитель"];
            button3.Text = RusWords["Профи"];
            label1.Text = RusWords["Выберите язык"];
            label2.Text = RusWords["выберите язык"];
            label3.Text = RusWords["Выберите сложность"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Text = UkrWords["Новичок"];
            button2.Text = UkrWords["Любитель"];
            button3.Text = UkrWords["Профи"];
            label1.Text = UkrWords["Выберите язык"];
            label2.Text = UkrWords["выберите язык"];
            label3.Text = UkrWords["Выберите сложность"];
        }
    }
}
