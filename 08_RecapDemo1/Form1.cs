using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button bir classtır formlar birer classtır.
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;
  
            for (int i = 0; i < buttons.GetUpperBound(0); i++) 
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();  //button oluştur
                    buttons[i, j].Width = 50;    //button genişlik
                    buttons[i, j].Height = 50;    //button yükseklik
                    buttons[i,j].Left = left;      //button sol değerini değişkenden al
                    buttons[i, j].Top = top;         //button üst değerini değişkenden al
                    left += 50;                     //değişken değeri artır
                    this.Controls.Add(buttons[i, j]);     //forma buttonları ekle
                    if ((i + j) % 2 == 0)
                    {                                    
                        buttons[i, j].BackColor = Color.Black; //çiftse rengi siyah yap buttonun

                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;  //tekse rengi beyaz yap buttonun
                    }
                }
                top += 50;
                left = 0; 
            
            }


        }
    }
}
