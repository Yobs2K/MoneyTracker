using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoneyTracker
{

    public partial class Form2 : Form
    {
        Form1 main;

        FileHandler fh;
        DateTime DT;
        string groupName;
        public Form2(string name, FileHandler fhIn)
        {
            fh = fhIn;
            InitializeComponent();
            groupName = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            DT = DateTime.Today;
        }

        



        private void buttonAddContinue_Click(object sender, EventArgs e)
        {
           
            double summ;
            int day, month, year, week;
            string dayOfWeek;
            List<string> tags = new List<string>();
            bool isSummRight = double.TryParse(tB_summ.Text, out summ);
            bool isWeekRight = (int.TryParse(tB_week.Text, out week));

            day = DT.Day;
            month = DT.Month;
            year = DT.Year;
            
            dayOfWeek = Misc.get_DOW_drom_date(DT.DayOfWeek.ToString());

            bool isAllRight = (isSummRight & isWeekRight);
            if (isAllRight)
            {
                string[] tags_lines = rTB_tags.Lines;
                foreach (string s in tags_lines)
                {
                    tags.Add(s);
                }
                Transaction trans = new Transaction(summ, tags, day, month, year, week, dayOfWeek, null, true);
                fh.addTransaction(groupName, trans);
                errorText.Text = "Успешно добавлено.";
                tB_summ.Text = "";
                main.update_lB_transactions();
            }
            else
            {
                errorText.Text = "Неправильно или неполностью введены данные. Введите заново.";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddClose_Click(object sender, EventArgs e)
        {
            buttonAddContinue_Click(sender, e);
            buttonClose_Click(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
