using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
            double d = Convert.ToDouble(txtValor1.Text) + Convert.ToDouble(txtValor2.Text);
            lblResult.Text = d.ToString();
                Limpiar();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Limpiar()
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
            
        }
        public void Validar()
        {
            if (txtValor1.Text == string.Empty && txtValor2.Text == string.Empty)
            {
                throw new Exception("Valor 1 y 2 vacíos");
            }            
            if (txtValor1.Text == string.Empty)
            {
                throw new Exception("Valor 1 vacío");
            }
            if (txtValor2.Text == string.Empty)
            {
                throw new Exception("Valor 2 vacío");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                ValidarDiv();
                double d = Convert.ToDouble(txtValor1.Text) / Convert.ToDouble(txtValor2.Text);
                lblResult.Text = d.ToString();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ValidarDiv()
        {
            if (txtValor2.Text == "0")
            {
                throw new Exception("No se puede dividir por cero");
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                double d = Convert.ToDouble(txtValor1.Text) - Convert.ToDouble(txtValor2.Text);
                lblResult.Text = d.ToString();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                double d = Convert.ToDouble(txtValor1.Text) * Convert.ToDouble(txtValor2.Text);
                lblResult.Text = d.ToString();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
