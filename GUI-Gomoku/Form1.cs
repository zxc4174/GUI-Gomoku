using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Gomoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstRadioButton.Checked = true;
        }

        private void nameBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //firstPlayerName.Text = nameBox1.Text == "" ? "プレーヤー1" : nameBox1.Text;
            richTextBox1.Text = nameBox1.Text == "" ? "プレーヤー1" : nameBox1.Text;

        }
        //START BUTTON
        private void startButton_Click(object sender, EventArgs e)
        {
            bool order = firstRadioButton.Checked ? true : false;                   //Who is first button

            if (nameBox1.Text == "" || nameBox2.Text == "" )
            {
                MessageBox.Show("プレーヤーの名前に入れてください！");
            }
            else if(!firstRadioButton.Checked && !afterRadioButton.Checked)
            {
                MessageBox.Show("攻撃の順番を選択してください！ ");
            }
            else
            {
                Form2 f2 = new Form2(nameBox1.Text, nameBox2.Text, order);          //Open the Game board
                f2.Owner = this;
                f2.Visible = true;
            }            
        }

        //CLEAR BUTTON
        private void cleanButton_Click(object sender, EventArgs e)
        {
            nameBox1.Text = "";
            nameBox2.Text = "";
            firstPlayerName.Text = "プレーヤー1";
            firstRadioButton.Checked = true;
            afterRadioButton.Checked = false;
        }

        private void nameBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (nameBox1.Text=="" ) 
                {
                    if(e.KeyChar == 0x20)
                        e.Handled = true;
                }
        }

        private void nameBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameBox2.Text == "")
            {
                if (e.KeyChar == 0x20)
                    e.Handled = true;
            }
        }
    }
}
