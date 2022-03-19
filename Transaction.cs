using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    public class Transaction
    {
        private int year;
        private int month;
        private int day;
        private int week;
        private string dayOfWeek;

        private double summ;

        private List<string> tags = new List<string>();
        private string name;

        bool isComplete;

        public Transaction(double summIn, List<string> tagsIn, int dayIn, int monthIn,
            int yearIn, int weekIn, string dayOfWeekIn, string nameIn, bool isCompleteIn)
        {
            summ = summIn;
            tags = tagsIn;
            day = dayIn;
            month = monthIn;
            year = yearIn;
            week = weekIn;
            dayOfWeek = dayOfWeekIn;
            name = nameIn;
            isComplete = isCompleteIn;
        }

        public Transaction(Transaction trans1) : this (trans1.summ, trans1.tags, 
            trans1.day, trans1.month, trans1.year, trans1.week, trans1.dayOfWeek,
            trans1.name, trans1.isComplete)
        {
            
        }
        
        public string makeText()
        {
            string s = $"{summ} - {day}.{month}.{year}, {dayOfWeek}, {week} неделя. Тэги:";
            if (tags.Count != 0) s += $" {tags[0]}";
            for (int i = 1; i < tags.Count; ++i)
            {
                s += $", {tags[i]}";
            }
            s += ".";
            return s;
        }

        public string getFileText()
        {
            string s = "";
            s += $"{summ}; {day}.{month}.{year}, {dayOfWeek}, {week}; ";
            if (tags != null && tags.Count != 0) {
                s += $"{tags[0]}";
                for (int i = 1; i < tags.Count; ++i)
                {
                    s += $", {tags[i]}";
                }
            }
            s += ";";
            if (isComplete) s += " Completed";
            else s += " notCompleted";
            return s;
        }

        public double getSumm()
        {
            return summ;
        }

    }
}
