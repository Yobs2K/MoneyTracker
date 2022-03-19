
namespace MoneyTracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_summ = new System.Windows.Forms.TextBox();
            this.tB_week = new System.Windows.Forms.TextBox();
            this.rTB_tags = new System.Windows.Forms.RichTextBox();
            this.buttonAddContinue = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddClose = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата (дд/мм/гггг, день недели, неделя)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тэги";
            // 
            // tB_summ
            // 
            this.tB_summ.Location = new System.Drawing.Point(18, 137);
            this.tB_summ.Name = "tB_summ";
            this.tB_summ.Size = new System.Drawing.Size(78, 27);
            this.tB_summ.TabIndex = 3;
            // 
            // tB_week
            // 
            this.tB_week.Location = new System.Drawing.Point(362, 137);
            this.tB_week.Name = "tB_week";
            this.tB_week.Size = new System.Drawing.Size(45, 27);
            this.tB_week.TabIndex = 8;
            // 
            // rTB_tags
            // 
            this.rTB_tags.Location = new System.Drawing.Point(508, 94);
            this.rTB_tags.Name = "rTB_tags";
            this.rTB_tags.Size = new System.Drawing.Size(235, 273);
            this.rTB_tags.TabIndex = 9;
            this.rTB_tags.Text = "";
            // 
            // buttonAddContinue
            // 
            this.buttonAddContinue.Location = new System.Drawing.Point(18, 338);
            this.buttonAddContinue.Name = "buttonAddContinue";
            this.buttonAddContinue.Size = new System.Drawing.Size(94, 29);
            this.buttonAddContinue.TabIndex = 10;
            this.buttonAddContinue.Text = "Добавить";
            this.buttonAddContinue.UseVisualStyleBackColor = true;
            this.buttonAddContinue.Click += new System.EventHandler(this.buttonAddContinue_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(343, 338);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddClose
            // 
            this.buttonAddClose.Location = new System.Drawing.Point(144, 338);
            this.buttonAddClose.Name = "buttonAddClose";
            this.buttonAddClose.Size = new System.Drawing.Size(161, 29);
            this.buttonAddClose.TabIndex = 12;
            this.buttonAddClose.Text = "Добавить и закрыть";
            this.buttonAddClose.UseVisualStyleBackColor = true;
            this.buttonAddClose.Click += new System.EventHandler(this.buttonAddClose_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(10, 192);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 20);
            this.errorText.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.buttonAddClose);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddContinue);
            this.Controls.Add(this.rTB_tags);
            this.Controls.Add(this.tB_week);
            this.Controls.Add(this.tB_summ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_summ;
        private System.Windows.Forms.TextBox tB_week;
        private System.Windows.Forms.RichTextBox rTB_tags;
        private System.Windows.Forms.Button buttonAddContinue;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddClose;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}