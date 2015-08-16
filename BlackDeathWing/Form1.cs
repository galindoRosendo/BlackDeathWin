using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackDeathWing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realease the beast. BlackDeathWing, Monster and Code.
        /// </summary>
        /// <param name="name">The name of the user, dah!!! d-_-b </param>
        public void star_bdw(string name){
            bool state = false;
	        int initialLimit = 0;
	        int finalLimit = 1000000;
	        while(!state){
		        initialLimit++;
		        if(initialLimit==finalLimit){
                    MessageBox.Show("Limit reached, doubling to: " + (finalLimit * 2), "Avante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			        finalLimit = finalLimit * 2;
		        }else{
                    if (initialLimit == (finalLimit - 1))
                    {
                        DialogResult res = MessageBox.Show("Come on "+ name +", it's almost done!!!...", "No fear to down", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                            MessageBox.Show("Go, go and go...","Well done",MessageBoxButtons.OK);
                        else
                        {
                            MessageBox.Show("Try till you colapse","Remember "+name+" ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            break;
                        }
                    }
                    }
	        }
        }

        /// <summary>
        /// Just typed all in one metod
        /// </summary>
        public void call_bdw()
        {
            string name = txtName.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("You'll be db.", "No name?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name = "db";
                star_bdw(name);
            }
            else
            {
                star_bdw(name);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            call_bdw();
        }
    }
}
