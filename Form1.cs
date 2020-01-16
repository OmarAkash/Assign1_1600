//*********************************************************************
//Program: ICA1
//Author: Md Omar Faruq Akash
//Class: CMPE 1600
//Instructor: kevin Moore
//*********************************************************************




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1600_ICA_1
{
    public partial class ICA1 : Form
    {
        //Initializing the variables

        double value = 0;
        double sum = 0;
        double average = 0;
        int num_entries = 0;
        public ICA1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Avg_button_Click(object sender, EventArgs e)
        {
            // Checking if the entry is a number
            if(!double.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("This is not a number", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Operations to be carried out if the entry is valid
             
            else
            {
                sum += value;
                num_entries += 1;
                average = sum / num_entries;
                CurAvg_val.Text = average.ToString("#.#");
                NumVal_val.Text = num_entries.ToString();


            }
        }

        // Resetting the program by initializing everything to become 0
        private void Reset_buttton_Click(object sender, EventArgs e)
        {
            value = 0;
            sum = 0;
            num_entries = 0;
            textBox1.Clear();
            CurAvg_val.Text = "0";
            NumVal_val.Text = num_entries.ToString();
        }

        private void ICA1_Load(object sender, EventArgs e)
        {

        }
    }
}
