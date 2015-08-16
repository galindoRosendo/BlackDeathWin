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
            bool estado = false;
	        int limiteInicial = 0;
	        int limiteFinal = 1000000;
	        int limiteSiguiente = 0;
	        while(!estado){
		        limiteInicial++;
		        if(limiteInicial==limiteFinal){
			        MessageBox.Show("Limite alcanzado se duplicara a " + (limiteFinal*2) );
			        limiteFinal = limiteFinal * 2;
		        }else{
                    if (limiteInicial == (limiteFinal - 1))
                    MessageBox.Show("Sigue, sigue y sigue...");
		        }
	        }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            star_bdw();
        }
    }
}
