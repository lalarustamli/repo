using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 1; i++)
            {

                for (int j = 1; j < 2; j++)
                {
                  
                  
                    

                }
                
               
                

            }

            var b = new Sharper(30, 30, 15, 20, "Lala");
            Controls.Add(b.myB);


        

        }
        class Sharper:Form1
        {
            public static List<Button> btnList  = new List<Button>();
            public Button myB = new Button();

            public Sharper(int width, int height, int left, int top, string text)
            {
              
                myB.Width = width;
                myB.Height = height;
                myB.Left = left;
                myB.Top = top;
                myB.Text = text;
                btnList.Add(myB);
            }
            public void ButtonCreator()
            {
                base.Controls.Add(myB);
                MessageBox.Show("button");
            }
        }
        
    }
}
