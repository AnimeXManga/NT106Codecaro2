using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameCaro
{
    public class ChessBoardManager
    {
        //lay ham tu form
        #region Propertices
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public Point Location { get; private set; }
        #endregion

        #region
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion

        #region Methods

        public void DrawChessBoard()
        {
            //Tao mot btn chua vi tri cua btn truoc do
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };

            for (int i=0;i<Chess.chess_board_width;i++)
            {
                for (int j=0; j<=Chess.chess_board_height;j++)
                {
                    Button btntemp = new Button()
                    {
                        Width= Chess.chess_width,
                        Height=Chess.chess_height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };
                    ChessBoard.Controls.Add(btntemp);
                    oldButton = btntemp;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Chess.chess_height);
                oldButton.Width = 0;
                oldButton.Height = 0;
               
            }

        }
        #endregion
    }
}
