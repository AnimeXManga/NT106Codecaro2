using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Main : Form
    {
        #region Propertices
        ChessBoardManager ChessBoard;
        #endregion

        public Main()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlCheckBoard);

            ChessBoard.DrawChessBoard();
        }
    }
}
