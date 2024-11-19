using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatrices224CodeGunner
{
    public partial class Form1 : Form
    {
        Matriz m1, m2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
        }
        //CARGAR 1
        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = m1.descargar();
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.descargar();
        }

        private void cARGARMANUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //CARGAR 2

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox9.Text = m2.descargar();
        }

        private void cARGARMANUALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        //PRACTICO 1

        private void eJERCICIO1ACUMULARPRIMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1
        }

        private void eJERCICIO2FRECUENCIADELELEMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2
            m1.Ejercicio2p1(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO3CONTARELEMENTOSUNICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //3
            textBox6.Text = string.Concat(m1.Ejercici3p1());
        }

        private void eJERCICIO4TRANSPUESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //4
            m1.Ejercicio4p1();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO5VERIFICARFILASORDENADASASCENDENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //5
            textBox6.Text = string.Concat(m1.Ejercicio5p1());

        }

        private void eJERCICIO6IMPLEMENTARELEMENTODEMAYORFRECUENCIADELASFILASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //6
            textBox6.Text = string.Concat(m1.Ejercicio6p1(m2));
        }

        private void eJERCICIO7VERIFICARORDENAMIENTORIGODE1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //7
            m1.Ejercicio7p1();
            textBox9.Text = m1.descargar();

        }

        private void eJERCICIO8VERIFICARSIUNAMATRIZESTAINCLUIDAENOTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //8
            m1.Ejercicio8p1();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO9SEGMENTARENPARESEIMPARESORDENADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //9
            
            m1.Ejercicio9p1Ordenar();
   
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO10ORDENARFILASPORLACANTIDADDEPRIMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10
  
        
            m1.RotarEntornoDerecha();

          
            textBox9.Text = m1.descargar();
        }

        //PRACTICO 2

        private void eJERCICIO1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //1
            m1.Ejercicio1p2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2
            m1.ejercicio2p2();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //3
            m1.Ejercicio3p2();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //4
            m1.Ejercicio4p2();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //5
            m1.Ejercicio5p2();
            textBox9.Text = m1.descargar();
        }

        private void eJERCICIO6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //6
            m1.Ejercicio6p2();
            textBox9.Text = m1.descargar();
        }


        private void eJERCICIO7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
