using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    public class FileHandler
    {
        string path;
        private List<TransactionsGroup> Groups = new List<TransactionsGroup>();
        List<string> groupNames = new List<string>();
        List<bool> groupFull = new List<bool>();

        public FileHandler(string pathIn)
        {
            path = pathIn;
            using (StreamReader sr = new StreamReader(path + "Groups.txt"))
            {
                string fileText = sr.ReadToEnd();
                string[] Lines = fileText.Split('\n');
                for (int i = 0; i < Lines.Length; ++i)
                {
                    groupNames.Add(Lines[i]);
                }
            }
            
            foreach (string groupPath in groupNames)
            {
               
                TransactionsGroup transGroup = new TransactionsGroup(groupPath);
                string groupFile;
                
                
                using (StreamReader sr = new StreamReader(path + groupPath +
                    @"\Transactions.txt"))
                {
                    groupFile = sr.ReadToEnd();
                }
                if (groupFile != "")
                {
                    groupFull.Add(true);
                    string[] Lines = groupFile.Split('\n');
                    foreach (string line in Lines)
                    {

                        string[] lineData = line.Split("; ");

                        double summ = Convert.ToDouble(lineData[0]);

                        string[] dateFull = lineData[1].Split(", ");
                        string[] date = dateFull[0].Split(".");
                        int day = Convert.ToInt32(date[0]);
                        int month = Convert.ToInt32(date[1]);
                        int year = Convert.ToInt32(date[2]);
                        string dayOfWeek = dateFull[1];
                        int week = Convert.ToInt32(dateFull[2]);

                        string[] tags = lineData[2].Split(", ");
                        List<string> tagsList = new List<string>();
                        tagsList.AddRange(tags);

                        bool isCompleted = (lineData[3] == "Completed");

                        Transaction trans = new Transaction(summ, tagsList, day, month,
                            year, week, dayOfWeek, null, isCompleted);
                        transGroup.addTransaction(trans);
                    }
                    
                }
                else
                {
                    groupFull.Add(false);
                }
                Groups.Add(transGroup);
            }
        }

        public FileHandler() : this (@"Data\")
        {
            
        }

        public List<string> getNames()
        {
            return groupNames;
        }

        public void addGroup(string name)
        {
            groupNames.Add(name);
            groupFull.Add(false);
            TransactionsGroup transGroup = new TransactionsGroup(name);
            Groups.Add(transGroup);

        }

        private void addGroupToFileSystem(string name)
        {
            Directory.CreateDirectory(path + name);
            using (StreamWriter sw = new StreamWriter(path + @"Groups.txt", true))
            {
                sw.Write("\n" + name);
            }

            using (System.IO.FileStream fs = System.IO.File.Create(path + name + @"\Transactions.txt"))
            {

            }
        }

        public int addGroupByForm (string name)
        {
            foreach (string s in groupNames)
            {
                if (s == name)
                {
                    return -1;
                }
            }
            addGroup(name);
            addGroupToFileSystem(name);
            return 0;
        }

        public void deleteGroup (string name)
        {
            File.Delete(path + name + @"\Transactions.txt");
            Directory.Delete(path + name);
                string result = "";
            string[] Lines = File.ReadAllLines(path + @"Groups.txt");
            if (Lines[0] == name)
            {
                result = Lines[1];
                for (int i = 2; i < Lines.Length; ++i)
                {
                    result += "\n" + Lines[i];
                }
            }
            else
            {
                result = Lines[0];
                for (int i = 1; i < Lines.Length; ++i)
                {
                    if (Lines[i] != name)
                    {
                        result += "\n" + Lines[i];
                    }
                }
            }
            File.WriteAllText(path + @"Groups.txt", result);

            groupFull.RemoveAt(groupNames.IndexOf(name));
            Groups.RemoveAt(groupNames.IndexOf(name));
            groupNames.Remove(name);
        }

        public TransactionsGroup getGroup(int index)
        {
            return Groups[index];
        }

        public TransactionsGroup getGroup(string name)
        {
            return Groups[groupNames.IndexOf(name)];
        }

        private void addTransactionToFileSystem (Transaction trans, string groupName)
        {
            using (StreamWriter sw = new StreamWriter(path + groupName + @"\Transactions.txt", true))
            {
                if (groupFull[groupNames.IndexOf(groupName)]) {
                    sw.Write("\n" + trans.getFileText());
                }
                else
                {
                    groupFull[groupNames.IndexOf(groupName)] = true;
                    sw.Write(trans.getFileText());
                }
                
            }
        }

        public void addTransaction (string groupName, double summ, int day, int month, int year,
            string dayOfWeek, int week, List<string> tags)
        {
            Transaction trans = new Transaction(summ, tags, day, month, year, week, dayOfWeek, null, true);
            Groups[groupNames.IndexOf(groupName)].addTransaction(trans);
            addTransactionToFileSystem(trans, groupName);
        }

        public void deleteTransaction(string groupName, int transIndex)
        {
            TransactionsGroup transGroup = Groups[groupNames.IndexOf(groupName)];
            transGroup.deleteTransaction(transIndex);
            using (StreamWriter sw = new StreamWriter(path + groupName + @"\Transactions.txt", false))
            {
                int index = 0;
                if (transGroup.getList().Count != 0)
                {
                    foreach (Transaction trans in transGroup.getList())
                    {
                        if (index != 0) { sw.Write("\n"); }
                        sw.Write(trans.getFileText());
                    }
                }
                else
                {
                    groupFull[groupNames.IndexOf(groupName)] = false;
                }
            }

        }

        public void addTransaction(string groupName, Transaction trans)
        {
            Groups[groupNames.IndexOf(groupName)].addTransaction(trans);
            addTransactionToFileSystem(trans, groupName);
        }
    }
}
