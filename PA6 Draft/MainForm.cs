using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6_Draft
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LightColor = Color.FromName("AntiqueWhite");
            DarkColor = Color.FromArgb(200, 100, 20);
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ChessGame game = new ChessGame((int)Minute.Value, (int)Seconds.Value, player1.Text, player2.Text, Rules.STANDARD);
            Chessboard board = new Chessboard(LightColor, DarkColor, game);


            UnitTests UT = new UnitTests();

            #region tests
            bool sidesAreSame = UT.TestSidesAreSame(game);
            board.Test1PF.Text = (sidesAreSame) ? "PASSED" : "FAILED";
            board.Test1PF.ForeColor = (sidesAreSame) ? Color.Green : Color.Red;

            bool pawnsInPlace = UT.TestPawnsInPlace(game);
            board.Test2PF.Text = (pawnsInPlace) ? "PASSED" : "FAILED";
            board.Test2PF.ForeColor = (pawnsInPlace) ? Color.Green : Color.Red;

            bool correctRules = UT.TestCorrectRules(game, Rules.STANDARD);
            board.Test3PF.Text = (correctRules) ? "PASSED" : "FAILED";
            board.Test3PF.ForeColor = (correctRules) ? Color.Green : Color.Red;

            bool kingBetweenRooks = UT.TestKingBetweenRooks(game);
            board.Test4PF.Text = (kingBetweenRooks) ? "PASSED" : "FAILED";
            board.Test4PF.ForeColor = (kingBetweenRooks) ? Color.Green : Color.Red;
            #endregion
            board.ShowDialog();

        }

        private void DarkColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                DarkColor = colorDialog1.Color;
        }

        private void LightColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                LightColor = colorDialog1.Color;
        }

        private void Seconds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChessGame game = new ChessGame((int)Minute.Value, (int)Seconds.Value, player1.Text, player2.Text, Rules.NINESIXTY);
            Chessboard board = new Chessboard(LightColor, DarkColor, game);


            UnitTests UT = new UnitTests();
            #region tests
            bool sidesAreSame = UT.TestSidesAreSame(game);
            board.Test1PF.Text = (sidesAreSame) ? "PASSED" : "FAILED";
            board.Test1PF.ForeColor = (sidesAreSame) ? Color.Green : Color.Red;
            
            bool pawnsInPlace = UT.TestPawnsInPlace(game);
            board.Test2PF.Text = (pawnsInPlace) ? "PASSED" : "FAILED";
            board.Test2PF.ForeColor = (pawnsInPlace) ? Color.Green : Color.Red;

            bool correctRules = UT.TestCorrectRules(game, Rules.NINESIXTY);
            board.Test3PF.Text = (correctRules) ? "PASSED" : "FAILED";
            board.Test3PF.ForeColor = (correctRules) ? Color.Green : Color.Red;

            bool kingBetweenRooks = UT.TestKingBetweenRooks(game);
            board.Test4PF.Text = (kingBetweenRooks) ? "PASSED" : "FAILED";
            board.Test4PF.ForeColor = (kingBetweenRooks) ? Color.Green : Color.Red;
            #endregion
            board.ShowDialog();



        }
    }
}
