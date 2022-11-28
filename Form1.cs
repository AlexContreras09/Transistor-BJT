using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transistor_BJT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Rd_Click(object sender, EventArgs e)
        {
            double Vcc, Vce, Ic, Icmax, P, B, Rd;

            //Valores conocidos
            B = double.Parse(BetaTx.Text);
            Vcc = double.Parse(VccTx.Text);
            Vce = Vcc / 2;
            VceTx.Text = Vce.ToString();
            Icmax = double.Parse(IcmaxTx.Text);
            Ic = Icmax / 2;
            IcTx.Text = Ic.ToString();
            P = Icmax * Vcc;
            PotenciaTx.Text = P.ToString();
            Rd = (Vcc - Vce) / Ic;
            RdTx.Text = Rd.ToString();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            double FIb = 0, FRb, FRc, Vcc, Vce, Vbe = 0.7, Ic, Icmax, P, B; //Polarización fija
            double EIb, ERe, ERb, ERc, EIbc1;
            double RIb, RRe, RRb, RRc, Rd, EIbc2;
            
            //Valores conocidos
            B = double.Parse(BetaTx.Text);
            Vcc = double.Parse(VccTx.Text);
            Vce = Vcc / 2;
            VceTx.Text = Vce.ToString();
            Icmax = double.Parse(IcmaxTx.Text);
            Ic = Icmax / 2;
            IcTx.Text = Ic.ToString();
            P = Icmax * Vcc;
            PotenciaTx.Text = P.ToString();

            //Valores Polarización Fija
            FIb = Ic / B;
            Ib1Tx.Text = FIb.ToString();
            FRb = (Vcc - Vbe) / FIb;
            Rb1Tx.Text = FRb.ToString();
            FRc = (Vcc - Vce) / Ic;
            Rc1Tx.Text = FRc.ToString();

            //Valores Polarización Fija con Estabilizadores
            EIb = Ic / (B + 1);
            Ib2Tx.Text = EIb.ToString();
            ERe = double.Parse(Re1Tx.Text);
            ERc = double.Parse(Rc2Tx.Text);
            ERb = ((Vcc - Vbe) / EIb) - ((B + 1) * ERe);
            Rb2Tx.Text = ERb.ToString();
            EIbc1 = (Vcc - Vbe) / (ERb+((B+1)*ERe));
            IBc1.Text = EIbc1.ToString();

            //Valores Polarización por Retroalimentación
            RIb = Ic / (B + 1);
            Ib3Tx.Text = RIb.ToString();
            RRe = double.Parse(Re2Tx.Text);
            RRc = double.Parse(Rc3Tx.Text);
            Rd = RRe + RRc;
            RRb = (((Vcc - Vbe) - (Ic * Rd)) / RIb);
            Rb3Tx.Text = RRb.ToString();
            EIbc2 = (Vcc-Vbe)/((B*Rd)+RRb);
            IBc2.Text = EIbc2.ToString();
        }

        private void Divisor_Click(object sender, EventArgs e)
        {
            double PIb, PRc, PRe, PR1, PR2, PRTh, PVTh, PRd, Ic, B, Vcc, Icmax, Vce, Vbe = 0.7, EIbc3;
            //Valores Iniciales
            B = double.Parse(BetaTx.Text);
            Vcc = double.Parse(VccTx.Text);
            Vce = Vcc / 2;
            Icmax = double.Parse(IcmaxTx.Text);
            Ic = Icmax / 2;

            //Valores Polarizacíón por Divisor de Voltaje
            PRd = (Vcc - Vce) / Ic;
            RdTx.Text = PRd.ToString();
            PRe = double.Parse(Re4Tx.Text);
            PRc = double.Parse(Rc4Tx.Text);
            PR1 = double.Parse(R1Tx.Text);
            PR2 = double.Parse(R2Tx.Text);
            PRTh = 1 / ((1 / PR1) + (1 / PR2));
            RThTx.Text = PRTh.ToString();
            PVTh = (PR2 / (PR2 + PR1)) * Vcc;
            VThTx.Text = PVTh.ToString();
            PIb = (PVTh-Vbe)/(PRTh+((B+1)*PRe));
            Ib4Tx.Text = PIb.ToString();
            EIbc3 = (PVTh - Vbe) / (PRTh + ((B + 1) * PRe));
            IBc3.Text = EIbc3.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Asigne valores a Vcc, Ic máx y Beta. Luego presione 'Calcular Rd'. Asigne las Resistencias en 'Escribe' y presione Calcular");
        }
    }
}
