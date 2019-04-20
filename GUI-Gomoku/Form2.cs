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
    public partial class Form2 : Form
    {           
        public const int MAX_AREA = 16;          // 最大の縦横数
        public int[,] area = new int[16, 16];
        public bool changeSwitch = true;         //Piece switch 
        enum PIECE { BLACK = 1, WHITE = 2 };

        public Form2(string player1,string player2,bool order)
        {
            InitializeComponent();
            if (order)
            {
                first.Text = player1;
                after.Text = player2;
            }
            else
            {
                first.Text = player2;
                after.Text = player1;
            }
        }
        //BOARD
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;       //Create Grpahic
            Pen pen = new Pen(Color.Black);
            int leap = 0;
            
            for (int i = 0; i < MAX_AREA; i++) {
                g.DrawLine(pen, 5, 5 + leap, PictureBox1.Size.Width-5, 5 + leap);        // Row 横
                g.DrawLine(pen, 5 + leap, 5, 5+ leap, PictureBox1.Size.Height-5);       // Column 縦
                leap= leap + 20;
            }
            PictureBox1.BackColor = Color.Tan;
        }
        //PUT THE PIECE
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;
            //Position X
            int rem = mouseX % 20;           // Remainder 余り
            if (rem <= 11)                   //最近の点のXになる
            {
                mouseX = mouseX - rem+5;
            }
            else if (rem > 11)
            {
                mouseX = mouseX + (20 - rem)+5;
            }

            //Position Y
            rem = mouseY % 20;
            if (rem <=11)                    //最近の点のYになる
            {
                mouseY = mouseY - rem+5;
            }
            else if (rem > 11)
            {
                mouseY = mouseY + (20 - rem)+5;
            }

            Graphics g = PictureBox1.CreateGraphics();
            SolidBrush brushB = new SolidBrush(Color.Black);
            SolidBrush brushW = new SolidBrush(Color.White);
            if (changeSwitch && area[mouseY / 20, mouseX / 20] == 0)                  //Black
            {
                g.FillEllipse(brushB, mouseX - 5, mouseY - 5, 10, 10);                //-5は円の中心になる
            }
            else if (!changeSwitch && area[mouseY / 20, mouseX / 20] == 0)            //White 
            {
                g.FillEllipse(brushW, mouseX - 5, mouseY - 5, 10, 10);                //-5は円の中心になる
            }
            else {
                MessageBox.Show("碁石が重なっている!");
                ChangeBW();
            }
            BoardArea(mouseX/20,mouseY/20);
            if (changeSwitch) {
                CheckThePiece(mouseX / 20, mouseY / 20,(int)PIECE.BLACK);
            }
            else{
                CheckThePiece(mouseX / 20, mouseY / 20,(int)PIECE.WHITE);
            }
            IsFull();
            ChangeBW();

            if (changeSwitch) { label1.Text = "今の順番は黒石"; } else { label1.Text = "今の順番は白石"; }
        }
        //BLACK & WHITE　の記録
        public void BoardArea(int mouseX,int mouseY) {
            if (changeSwitch)   //Black
            {
                area[mouseY, mouseX] = (int)PIECE.BLACK;
            }
            else               //White
            {
                area[mouseY, mouseX] = (int)PIECE.WHITE;
            }
        }

        /******/
        //結果の判定
        public void CheckThePiece(int mouseX, int mouseY,int pieceColor) {
            Stack<int> stX = new Stack<int>();
            Stack<int> stY = new Stack<int>();

            //Up&Down
            for (int i = 0; i < 5; i++)
            {
                if (mouseY - i >= 0 && area[mouseY - i, mouseX] == pieceColor)
                {
                    stY.Push(mouseY - i);
                }
                else {
                    break;
                }
            }
            for (int i = 1; i < 5; i++) //pass (mouseX,mouseY)
            {
                if (mouseY + i <MAX_AREA && area[mouseY + i, mouseX] == pieceColor)
                {
                    stY.Push(mouseY + i);
                }
                else
                {
                    break;
                }
            }

            if (GetStackSize(stY) >= 5){Winner(pieceColor);}else {stY.Clear();}
            //Left&Right    
            for (int i = 0; i < 5; i++)
            {
                if (mouseX - i >= 0 && area[mouseY, mouseX-i] == pieceColor)
                {
                    stX.Push(mouseX - i);
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++) //pass (mouseX,mouseY)
            {
                if (mouseX+i < MAX_AREA && area[mouseY, mouseX+i] == pieceColor)
                {
                    stX.Push(mouseX + i);
                }
                else
                {
                    break;
                }
            }

            if (GetStackSize(stX) >= 5) { Winner(pieceColor); }else { stX.Clear(); }
           
            //Left slash
            for (int i = 0; i < 5; i++)
            {
                if (mouseX - i >= 0 && mouseY-i>=0 && area[mouseY-i, mouseX - i] == pieceColor)
                {
                    stX.Push(mouseX - i);
                    stY.Push(mouseY - i);
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++) //pass (mouseX,mouseY)
            {
                if (mouseX + i < MAX_AREA && mouseY+i<MAX_AREA && area[mouseY+i, mouseX + i] == pieceColor)
                {
                    stX.Push(mouseX + i);
                    stY.Push(mouseY + i);
                }
                else
                {
                    break;
                }
            }

            if (GetStackSize(stX) >= 5) { Winner(pieceColor); } else { stX.Clear(); }
            
            //Right slash
            for (int i = 0; i < 5; i++)
            {
                if (mouseX + i <MAX_AREA && mouseY - i >= 0 && area[mouseY - i, mouseX + i] == pieceColor)
                {
                    stX.Push(mouseX + i);
                    stY.Push(mouseY - i);
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++) // pass (mouseX,mouseY)
            {
                if (mouseX -i >=0 && mouseY + i < MAX_AREA && area[mouseY + i, mouseX - i] == pieceColor)
                {
                    stX.Push(mouseX - i);
                    stY.Push(mouseY + i);
                }
                else
                {
                    break;
                }
            }

            if (GetStackSize(stX) >= 5) { Winner(pieceColor); }else { stX.Clear(); }

        }
       
        //STACK SIZE
        public int GetStackSize(Stack<int> st) {
            int count = 0;
            while (st.Count()!=0) {
                st.Pop();
                count++;
            }
            return count;
        }

    
        //STANDOFF
        public void IsFull() {
            bool full = true;
            for (int y = 0; y < 16; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    if (area[y, x] == 0)
                    {
                        full = false;
                    }
                }
            }
            if (full) {
                MessageBox.Show("引き分け！");    //The game ended in a standoff
                this.Close();
            }
            

        }
        //CHANGE THE BLACK AND WHITE PIECE
        public void  ChangeBW() {
            changeSwitch = changeSwitch ? false : true;     //Ternary
        }
        //CALL THE WINNER
        public void Winner(int bw) {                        //bw = black&white
            if (bw == (int)PIECE.BLACK)
            {
                MessageBox.Show("勝者は　"+first.Text+" !");
            }
            else {
                MessageBox.Show("勝者は　" + after.Text + " !");
            }
            this.Close();

        }
    }
}
