using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Competition
{
    public partial class Knowledge_Competition : Form
    {
        int questionnumber = 0, correct = 0, wrong = 0;
        private void Knowledge_Competition_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            picCorrect.Visible = false;
            picWrong.Visible = false;
            btnNextQuestion.Text = "Start!";
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            if (questionnumber == 1)
            {
                picCorrect.Visible = true;
                correct++;
                lblTrue.Text = correct.ToString();
                
            }
            if (questionnumber == 2)
            {
                picCorrect.Visible = true;
                correct++;
                lblTrue.Text = correct.ToString();
                
            }
            if (questionnumber == 3)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 4)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            if (questionnumber == 1)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 2)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 3)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 4)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            if (questionnumber == 1)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 2)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 3)
            {
                picCorrect.Visible = true;
                correct++;
                lblTrue.Text = correct.ToString();
            }
            if (questionnumber == 4)
            {
                picCorrect.Visible = true;
                correct++;
                lblTrue.Text = correct.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            if (questionnumber == 1)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 2)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 3)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            if (questionnumber == 4)
            {
                picWrong.Visible = true;
                wrong++;
                lblFalse.Text = wrong.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            picCorrect.Visible = false;
            picWrong.Visible = false;
            
            questionnumber++;
            

            if (questionnumber == 1)
            {
                richTextBox1.Text = questionnumber.ToString() + ") What is the independent day of America?";
                btnA.Text = "A) 4 of July";
                btnB.Text = "B) 4 of June";
                btnC.Text = "C) 4 of Juny";
                btnD.Text = "D) 4 of Jule";
                lblQuestionNumber.Text = questionnumber.ToString();
                btnNextQuestion.Text = "Next Question";
            }
            if (questionnumber == 2)
            {
                richTextBox1.Text = questionnumber.ToString() + ") What is the currency of America?";
                btnA.Text = "A) American Dollar";
                btnB.Text = "B) Kuveyt Lira";
                btnC.Text = "C) American Lira";
                btnD.Text = "D) Kuvette seksek";
                lblQuestionNumber.Text = questionnumber.ToString();
                btnNextQuestion.Text = "Next Question";
            }
            if (questionnumber == 3)
            {
                richTextBox1.Text = questionnumber.ToString() + ") Which state of America drink most alchol?";
                btnA.Text = "A) Texas";
                btnB.Text = "B) California";
                btnC.Text = "C) Wisconsin";
                btnD.Text = "D) Tablechusetts";
                lblQuestionNumber.Text = questionnumber.ToString();
                btnNextQuestion.Text = "Next Question";
            }
            if (questionnumber == 4)
            {
                richTextBox1.Text = questionnumber.ToString() + ") Which is the most rich state of America?";
                btnA.Text = "A) Montana";
                btnB.Text = "B) Kansas";
                btnC.Text = "C) California";
                btnD.Text = "D) Washington";
                btnNextQuestion.Text = "Results";
                lblQuestionNumber.Text = questionnumber.ToString();

            }
            if (questionnumber == 5)
            {
                questionnumber--;
                lblQuestionNumber.Text = questionnumber.ToString();
                MessageBox.Show($"Correct answer: {correct}\nWrong answer: {wrong}");
            }
        }
        public Knowledge_Competition()
        {
            InitializeComponent();
        }
    }
}
