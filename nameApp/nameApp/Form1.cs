using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        string[] names = new string[10];
        int i = 0;


        private void saveButton_Click(object sender, EventArgs e)
        {

            if (i < 10)
            {
                names[i] = nameTextBox.Text;
                i++;
                countTextBox.Text = Convert.ToString(i);
                nameTextBox.Text = String.Empty;
            }
            else if (i == 10)
            {
                nameTextBox.Text = String.Empty;
                showListBox.Items.Clear();
                foreach (string name in names)
                {
                    showListBox.Items.Add(name);

                }
            
            
                MessageBox.Show("Memory is Full");
                

            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
          showListBox.Items.Clear();
           for (int k = 0; k < i; k++)
            {
                showListBox.Items.Add(names[k]);
            }
        }



    }
    }



