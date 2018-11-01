using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autíčko
{
    public partial class Form1 : Form
    {
        int šířkaOkna;

        //Kinematické parametry auta

        double xStart = 10;
        double x;
        int y0 = 10;
        int rychlost = 0;

        //Geometrické parametry auta
        int šířkaAuta = 110;
        int výškaAuta = 30;
        int poziceKola1 = 30;
        int poziceKola2 = 80;
        int poloměrKola = 20;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            //Výchozí bod autíčka je [x0, y0]
            int x0 = Convert.ToInt32(x);

            //Karoserie
            kp.FillRectangle(Brushes.Pink, x0, y0, šířkaAuta, výškaAuta);

            //Silnice
            int ySilnice = y0 + výškaAuta + poloměrKola;
            kp.DrawLine(Pens.LightGray, 0, ySilnice, šířkaOkna - 1, ySilnice);

            //Výpočet natočení kol
            double ujeto = x - xStart;
            double obvodKola = 2 * Math.PI * poloměrKola;
            double otáčekKola = ujeto / obvodKola;
            double desetinnáČást = otáčekKola - Math.Truncate(otáčekKola);
            double úhelNatočení = 2 * Math.PI * desetinnáČást;

                //Již v radiánech

            //1.kolo

            int xStředu = x0 + poziceKola1;
            int yStředu = y0 + výškaAuta;
            int xLH = xStředu - poloměrKola;
            int yLH = yStředu - poloměrKola;
            kp.DrawEllipse(Pens.Black, xLH, yLH, 2 * poloměrKola, 2 * poloměrKola);

            //Čárka na 1. kole
            double rozdílX = poloměrKola * Math.Cos(úhelNatočení);
            double rozdílY = poloměrKola * Math.Sin(úhelNatočení);
            int xKonce = Convert.ToInt32(xStředu + rozdílX);
            int yKonce = Convert.ToInt32(yStředu + rozdílY);
            kp.DrawLine(Pens.Black, xStředu, yStředu, xKonce, yKonce);

            //posun na druhé kolo
            int posun = poziceKola2 - poziceKola1;
            xStředu += posun;
            xLH += posun;
            xKonce += posun;

            //2 kolo a čárka na něm

            kp.DrawEllipse(Pens.Black, xLH, yLH, 2 * poloměrKola, 2 * poloměrKola);
            kp.DrawLine(Pens.Black, xStředu, yStředu, xKonce, yKonce);





        }

        private void časovač_Tick(object sender, EventArgs e)
        {
            //Převod jednotek ( z milisekund na sekundy)
            double čas = 0.001 * časovač.Interval;

            //Posun autíčka
            x += rychlost * čas;

            //pokud za okrajem, přesun na začátek
            if (x >= šířkaOkna)
            {
                double posunZpět = šířkaOkna + šířkaAuta;
                x -= posunZpět;
                xStart -= posunZpět;



            }
            //překresli
            Refresh();
        }

        private void tlZrychli_Click(object sender, EventArgs e)
        {
            rychlost += 10;
        }

        private void tlZpomal_Click(object sender, EventArgs e)
        {
            rychlost -= 10;
            if (rychlost < 0)
            {
                rychlost = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = xStart;
            šířkaOkna = ClientSize.Width;
        }
    }
}
