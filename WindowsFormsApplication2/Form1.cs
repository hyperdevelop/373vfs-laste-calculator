// LASTE Calculator for wind correction
// DCS A-10C applicable
// Coder : Kostas Skondras
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
   


    public partial class Form1 : Form
    {
    
     //Function to calculate the Magnetic heading
    public decimal calcHdg(decimal heading){
    
    decimal returnedHdg;

    if(heading>180){
    returnedHdg = heading-180;
    }
    else{
    returnedHdg = heading +180;
    }
    returnedHdg = returnedHdg-7;
    if(returnedHdg<0)
    returnedHdg = 360 + returnedHdg;

    return returnedHdg;
}

        //Function to calculate the wind speed

    public decimal calcWind(decimal inputWind)
    {
        decimal returnWind;
        
        returnWind = inputWind*2;

        return returnWind;

    }


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Var Declarations
            decimal altW1 = calcHdg(altWind1.Value);
            decimal wind1 = calcWind(altSpeed1.Value);
            decimal altW2 = calcHdg(altWind2.Value);
            decimal wind2 = calcWind(altSpeed2.Value);
            decimal altW3 = calcHdg(altWind3.Value);
            decimal wind3 = calcWind(altSpeed3.Value);

            //Temperature Calculation
            decimal temp2 = tempValue.Value - 14;
            decimal temp3 = tempValue.Value - 52;


            windResult1.Text = altW1.ToString() +"/"+ wind1.ToString();
            windResult2.Text = altW2.ToString() + "/" + wind2.ToString();
            windResult3.Text = altW3.ToString() + "/" + wind3.ToString();


            tempResult1.Text = tempValue.Value.ToString();
            tempResult2.Text = temp2.ToString();
            tempResult3.Text = temp3.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Reset All Fields
            windResult1.Text = "";
            windResult2.Text = "";
            windResult3.Text = "";
            tempResult1.Text = "";
            tempResult2.Text = "";
            tempResult3.Text = "";
            altWind1.Value = 0;
            altWind2.Value = 0;
            altWind3.Value = 0;
            altSpeed1.Value = 0;
            altSpeed2.Value = 0;
            altSpeed3.Value = 0;
            tempValue.Value = 0;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laste Wind Correction for DCS A-10C \n \nMandatory abnormal brain activity 373vFS M3tatron \n \nForced audiovisual exasperation 373vFS Crash");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
