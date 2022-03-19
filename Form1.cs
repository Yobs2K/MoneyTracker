using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class Form1 : Form
    {

        FileHandler fh;
        string addGroupName;
        public Form1(FileHandler fhOut)
        {
            InitializeComponent();
            fh = fhOut;
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            List<string> groupNames = fh.getNames();
            foreach (string name in groupNames) {
                lB_groups.Items.Add(name);
                lB_groupsAdd.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void update_lB_transactions ()
        {
            if (lB_groups.SelectedIndex != -1)
            {
                lB_transactions.Items.Clear();
                string name = lB_groups.SelectedItem.ToString();
                TransactionsGroup transGroup = fh.getGroup(name);
                tB_Summ.Text = $"Сумма расходов в этой группе: {transGroup.getSumm().ToString("C")}";
                foreach (Transaction trans in transGroup.getList())
                {
                    lB_transactions.Items.Add(trans.makeText());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_lB_transactions();
        }

        private void lB_groupsAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lB_groupsAdd.SelectedIndex != -1)
            {
                addGroupName = lB_groupsAdd.SelectedItem.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e) //Кнопка добавить
        {
            if (lB_groupsAdd.SelectedIndex != -1)
            {
                Form2 frm2 = new Form2(addGroupName, fh);
                frm2.Owner = this;
                frm2.Show();
                
                
                errorText.Text = "";
                update_lB_transactions();
            }
            else 
            {
                errorText.Text = "Выберите группу";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_trans_Click(object sender, EventArgs e)
        {
            int index = lB_transactions.SelectedIndex;
            if (index != -1) {
                fh.deleteTransaction(lB_groups.SelectedItem.ToString(), lB_transactions.SelectedIndex);
                update_lB_transactions();
            }
            else
            {
                ErrorText_DeletingTrans.Text = "Выделите расход, который хотите удалить";
            }
        }

        private void buttonDelGroup_Click(object sender, EventArgs e)
        {
            //Достать индекс выделенного элемента из listбокса.
            //Если индекс -1, вывести текст ошибки о том, что нужно выделить группу
            //Иначе вызвать метод из FileHandler, который будет полностью удалять группу с таким названием
            int index = lB_groups.SelectedIndex;
            if (index == -1)
            {
                errorTextDeletingGroup.Text = "Выделите группу, которую хотите удалить";
            }
            else
            {
                errorTextDeletingGroup.Text = "";
                fh.deleteGroup(lB_groups.SelectedItem.ToString());
                lB_groupsAdd.Items.Remove(lB_groups.SelectedItem);
                lB_groups.Items.RemoveAt(lB_groups.SelectedIndex);
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            
            string name = tB_groupAdd.Text;
            if (name != "")
            {
                errorTextDeletingGroup.Text = "";
                fh.addGroupByForm(name);
                lB_groups.Items.Add(name);
                lB_groupsAdd.Items.Add(name);
            }
            else { errorTextDeletingGroup.Text = "Напишите название группы чтобы добавитть её."; }
        }

        private void lB_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
