using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificarClima {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void txbTemp_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {

                if (txbTemp.Text == "") {
                    MessageBox.Show("Erro a temperatura esta vazia!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    double temperatura = double.Parse(txbTemp.Text);

                    if (temperatura > 30) {
                        pibStatus.Image = Properties.Resources.hot;
                    }
                    else if (temperatura >= 15 && temperatura <= 30) {
                        pibStatus.Image = Properties.Resources.temperature;
                    }
                    else {
                        pibStatus.Image = Properties.Resources.freeze;
                    }

                    lblDiaHoje.Text = $"Dia de hoje: {DateTime.Now.Day.ToString()}/{DateTime.Now.Month}"; 

                }


            }
        }

        private void txbTemp_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)  {
                e.Handled = true;
            }

        }
    }
}
