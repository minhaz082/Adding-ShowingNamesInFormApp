using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppMinhaz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetButton.Enabled = false;
        }

        string name ;
        List<String> employeeName = new List<string>();
        int maximumNo = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
                name = nameTextBox.Text;
                employeeName.Add(name);
                nameTextBox.Clear();
                maximumNo++;
                countNameLabel.Text = maximumNo.ToString();
  
                if (maximumNo>= 5)
                {
                    ShowListBoxInfo();
                    addButton.Enabled = false;
                    resetButton.Enabled = true;
                    showAllButton.Enabled = false;
                    countNameLabel.Text = "5";
                }               
                
            }

        private void ShowListBoxInfo()
        {
            nameInfoListBox.Items.Clear();
            for (int i = 0; i < employeeName.Count; i++)
            {
                if (employeeName[i] != null)
                {
                    nameInfoListBox.Items.Add( (i+1).ToString() + ".  " + employeeName[i]);
                }
                
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowListBoxInfo();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameInfoListBox.Items.Clear();
            nameTextBox.Clear();
            employeeName = new List<string>();
            resetButton.Enabled = false;
            countNameLabel.Text = "";
            maximumNo = 0;
            addButton.Enabled = true;
            showAllButton.Enabled = true;
        }
        
    }
}
