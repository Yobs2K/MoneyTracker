
namespace MoneyTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_delete_trans = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lB_groups = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lB_groupsAdd = new System.Windows.Forms.ListBox();
            this.errorText = new System.Windows.Forms.Label();
            this.buttonDelGroup = new System.Windows.Forms.Button();
            this.tB_groupAdd = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.errorTextDeletingGroup = new System.Windows.Forms.Label();
            this.lB_transactions = new System.Windows.Forms.ListBox();
            this.tB_Summ = new System.Windows.Forms.TextBox();
            this.ErrorText_DeletingTrans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_delete_trans
            // 
            this.button_delete_trans.Location = new System.Drawing.Point(963, 32);
            this.button_delete_trans.Name = "button_delete_trans";
            this.button_delete_trans.Size = new System.Drawing.Size(164, 29);
            this.button_delete_trans.TabIndex = 3;
            this.button_delete_trans.Text = "Удалить расход";
            this.button_delete_trans.UseVisualStyleBackColor = true;
            this.button_delete_trans.Click += new System.EventHandler(this.button_delete_trans_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Показать расходы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lB_groups
            // 
            this.lB_groups.BackColor = System.Drawing.SystemColors.Window;
            this.lB_groups.FormattingEnabled = true;
            this.lB_groups.ItemHeight = 20;
            this.lB_groups.Location = new System.Drawing.Point(78, 81);
            this.lB_groups.Name = "lB_groups";
            this.lB_groups.Size = new System.Drawing.Size(204, 344);
            this.lB_groups.TabIndex = 10;
            this.lB_groups.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(963, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить расход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lB_groupsAdd
            // 
            this.lB_groupsAdd.FormattingEnabled = true;
            this.lB_groupsAdd.ItemHeight = 20;
            this.lB_groupsAdd.Location = new System.Drawing.Point(963, 271);
            this.lB_groupsAdd.Name = "lB_groupsAdd";
            this.lB_groupsAdd.Size = new System.Drawing.Size(164, 264);
            this.lB_groupsAdd.TabIndex = 13;
            this.lB_groupsAdd.SelectedIndexChanged += new System.EventHandler(this.lB_groupsAdd_SelectedIndexChanged);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(977, 242);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 20);
            this.errorText.TabIndex = 14;
            // 
            // buttonDelGroup
            // 
            this.buttonDelGroup.Location = new System.Drawing.Point(78, 444);
            this.buttonDelGroup.Name = "buttonDelGroup";
            this.buttonDelGroup.Size = new System.Drawing.Size(204, 29);
            this.buttonDelGroup.TabIndex = 15;
            this.buttonDelGroup.Text = "Удалить группу";
            this.buttonDelGroup.UseVisualStyleBackColor = true;
            this.buttonDelGroup.Click += new System.EventHandler(this.buttonDelGroup_Click);
            // 
            // tB_groupAdd
            // 
            this.tB_groupAdd.Location = new System.Drawing.Point(78, 508);
            this.tB_groupAdd.Name = "tB_groupAdd";
            this.tB_groupAdd.Size = new System.Drawing.Size(204, 27);
            this.tB_groupAdd.TabIndex = 16;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(78, 551);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(204, 29);
            this.buttonAddGroup.TabIndex = 17;
            this.buttonAddGroup.Text = "Добавить группу";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // errorTextDeletingGroup
            // 
            this.errorTextDeletingGroup.AutoSize = true;
            this.errorTextDeletingGroup.Location = new System.Drawing.Point(78, 480);
            this.errorTextDeletingGroup.Name = "errorTextDeletingGroup";
            this.errorTextDeletingGroup.Size = new System.Drawing.Size(0, 20);
            this.errorTextDeletingGroup.TabIndex = 18;
            // 
            // lB_transactions
            // 
            this.lB_transactions.FormattingEnabled = true;
            this.lB_transactions.ItemHeight = 20;
            this.lB_transactions.Location = new System.Drawing.Point(410, 66);
            this.lB_transactions.Name = "lB_transactions";
            this.lB_transactions.Size = new System.Drawing.Size(401, 484);
            this.lB_transactions.TabIndex = 19;
            this.lB_transactions.SelectedIndexChanged += new System.EventHandler(this.lB_transactions_SelectedIndexChanged);
            // 
            // tB_Summ
            // 
            this.tB_Summ.Location = new System.Drawing.Point(410, 12);
            this.tB_Summ.Name = "tB_Summ";
            this.tB_Summ.ReadOnly = true;
            this.tB_Summ.Size = new System.Drawing.Size(401, 27);
            this.tB_Summ.TabIndex = 20;
            // 
            // ErrorText_DeletingTrans
            // 
            this.ErrorText_DeletingTrans.AutoSize = true;
            this.ErrorText_DeletingTrans.Location = new System.Drawing.Point(977, 95);
            this.ErrorText_DeletingTrans.Name = "ErrorText_DeletingTrans";
            this.ErrorText_DeletingTrans.Size = new System.Drawing.Size(0, 20);
            this.ErrorText_DeletingTrans.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 732);
            this.Controls.Add(this.ErrorText_DeletingTrans);
            this.Controls.Add(this.tB_Summ);
            this.Controls.Add(this.lB_transactions);
            this.Controls.Add(this.errorTextDeletingGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.tB_groupAdd);
            this.Controls.Add(this.buttonDelGroup);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.lB_groupsAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lB_groups);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_delete_trans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_delete_trans;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lB_groups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lB_groupsAdd;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button buttonDelGroup;
        private System.Windows.Forms.TextBox tB_groupAdd;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label errorTextDeletingGroup;
        private System.Windows.Forms.ListBox lB_transactions;
        private System.Windows.Forms.TextBox tB_Summ;
        private System.Windows.Forms.Label ErrorText_DeletingTrans;
    }
}

