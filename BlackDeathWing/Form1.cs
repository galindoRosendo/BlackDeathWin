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
        public void star_bdw(){
            bool state = false;
	        int initialLimit = 0;
	        int finalLimit = 1000000;
	        int nextLimit = 0;
	        while(!state){
		        initialLimit++;
		        if(initialLimit==finalLimit){
                    MessageBox.Show("Limit reached, doubling to: " + (finalLimit * 2), "Avante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			        finalLimit = finalLimit * 2;
		        }else{
                    if (initialLimit == (finalLimit - 1))
                    {
                        DialogResult res = MessageBox.Show("Come on, it's almost done!!!...", "No fear to down", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                            MessageBox.Show("Go, go and go...","Well done",MessageBoxButtons.OK);
                        else
                        {
                            MessageBox.Show("Try till you colapse","Remember: ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            break;
                        }
                    }
                    }
	        }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            star_bdw();
        }
    }
}
