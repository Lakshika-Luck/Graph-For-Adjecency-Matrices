﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadProject
{

    public partial class Graph : Form
    {
        int x;
        int y;
        int counterX = 0;
        int counterY = 0;

        int[,] matrix1;
        
        public Graph()
        {
            InitializeComponent();


        }
        public void Print(int x, int y)
        {
            int[,] matrix1 = new int[x, y];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Graph ob = new Graph();
            //ob.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mtrix mt = new Mtrix();
            mt.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (txtSize.Text == String.Empty)
             {
                 txtSize.Focus();
                 errorProvider1.SetError(txtSize, "Invailid Value.please enter integer Value");
                 MessageBox.Show("invalid Enter integer Value..");

             }
             else
             {
                 textBox1.Focus();

             }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {


             
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Graph_Load(object sender, EventArgs e)
        {
            txtRow.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtRow.Text);
            y = Convert.ToInt32(txtColums.Text);

            matrix1 = new int[x, y];
            MessageBox.Show("Zero Matrix Created");
            Console.WriteLine("x : "+x+" y : "+y);
            txtValue.Focus();

        }

        

        private void btnAddValues_Click(object sender, EventArgs e)
        {
            if(counterY<y)
            {
                matrix1[counterX, counterY] = Convert.ToInt32(txtValue.Text);
                Console.WriteLine(counterX+" , "+counterY);
                counterY++;
            
                
                 if(counterY>=x)
                {
                    counterY = 0;
                    counterX++;
                }
                 txtValue.Clear();
                
            }
            else
            {
                MessageBox.Show("No of rows are over Click the Ok Button");
                printMatrix();
            }
           
        }

        string ss;
        public void printMatrix()
        {
            for(int i=0;i<x;i++){
                for (int j = 0; j < y;j++ )
                {
                   ss=ss+(matrix1[i, j] + " , ").ToString();
                }
                Console.WriteLine();
                ss += "\n";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Mtrix nf = new Mtrix(x,y,matrix1);
            nf.Show();
        }

        private void txtRow_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtColums.Focus();
            }
        }

        private void txtColums_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtColums_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
                MessageBox.Show("Click the Ok Button");
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }*/
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            //txtPrint.Focus();
            printMatrix();
            txtPrint.Text = ss;

           
        }

        private void txtPrint_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
