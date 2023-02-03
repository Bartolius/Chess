using Chess.Models;
using Chess.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Chess.ViewModels
{
    class GameViewModel
    {
        private GameView _gameView = new GameView();

        public GameView View { get { return _gameView; } }

        private double _time = 0;

        public double Timer
        {
            get { return _time; }
            set { _time = value; }
        }

        public void Init()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Rectangle rectangle = new Rectangle()
                    {
                        Width = 80,
                        Height = 80,
                        Fill = ((x+y)%2==0)?Brushes.LightYellow:Brushes.LightGreen,
                        Stroke = Brushes.Gray,
                        StrokeThickness = 1
                    };

                    Canvas.SetLeft(rectangle, x * 80);
                    Canvas.SetTop(rectangle, y * 80);

                    ((Canvas)_gameView.FindName("Game")).Children.Add(rectangle);
                }
            }

            List<PawnMovePatterns> pawnpatterns = new List<PawnMovePatterns>
            {
                new PawnMovePatterns(PawnType.ROOK)
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHTLEFT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHTRIGHT })))

                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT }))),

                new PawnMovePatterns(PawnType.KNIGHT)
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT }), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD }), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT }), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT }), true))

                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT }), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD }), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT }), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT }), true)),

                new PawnMovePatterns(PawnType.ROOK)
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT, Move.STRAIGHTLEFT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT, Move.STRAIGHTRIGHT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT, Move.STRAIGHTRIGHT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT, Move.BACKWARDRIGHT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD, Move.BACKWARDRIGHT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD, Move.BACKWARDLEFT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT, Move.BACKWARDLEFT })))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT, Move.STRAIGHTLEFT })))

                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT, Move.STRAIGHTLEFT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.STRAIGHT, Move.STRAIGHTRIGHT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT, Move.STRAIGHTRIGHT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.LEFT, Move.BACKWARDRIGHT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD, Move.BACKWARDRIGHT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.BACKWARD, Move.BACKWARDLEFT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT, Move.BACKWARDLEFT })))
                .AddMove(new MovePattern(new Queue<Move>(new Move[] { Move.RIGHT, Move.STRAIGHTLEFT }))),

                new PawnMovePatterns(PawnType.BISHOP)
                .AddAtack(new MovePattern(new Queue<Move>(new Move[]{Move.STRAIGHTLEFT}), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[]{Move.STRAIGHTRIGHT}), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[]{Move.BACKWARDLEFT}), true))
                .AddAtack(new MovePattern(new Queue<Move>(new Move[]{Move.BACKWARDRIGHT}), true))

                .AddMove(new MovePattern(new Queue<Move>(new Move[]{Move.STRAIGHTLEFT}), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[]{Move.STRAIGHTRIGHT}), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[]{Move.BACKWARDLEFT}), true))
                .AddMove(new MovePattern(new Queue<Move>(new Move[]{Move.BACKWARDRIGHT}), true))

            };




            Player white = new Player("White", Destination.BACKWARD);

            white.addPawn(new Pawn(PawnType.PAWN, new Position(0, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(1, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(2, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(3, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(4, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(5, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(6, 1), "White"));
            white.addPawn(new Pawn(PawnType.PAWN, new Position(7, 1), "White"));
            white.addPawn(new Pawn(PawnType.KNIGHT, new Position(0, 0), "White"));
            white.addPawn(new Pawn(PawnType.ROOK, new Position(1, 0), "White"));
            white.addPawn(new Pawn(PawnType.BISHOP, new Position(2, 0), "White"));
            white.addPawn(new Pawn(PawnType.KING, new Position(3, 0), "White"));
            white.addPawn(new Pawn(PawnType.QUEEN, new Position(4, 0), "White"));
            white.addPawn(new Pawn(PawnType.BISHOP, new Position(5, 0), "White"));
            white.addPawn(new Pawn(PawnType.ROOK, new Position(6, 0), "White"));
            white.addPawn(new Pawn(PawnType.KNIGHT, new Position(7, 0), "White"));

            Player black = new Player("White", Destination.FORWARD);

            black.addPawn(new Pawn(PawnType.PAWN, new Position(0, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(1, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(2, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(3, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(4, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(5, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(6, 6), "Black"));
            black.addPawn(new Pawn(PawnType.PAWN, new Position(7, 6), "Black"));
            black.addPawn(new Pawn(PawnType.KNIGHT, new Position(0, 7), "Black"));
            black.addPawn(new Pawn(PawnType.ROOK, new Position(1, 7), "Black"));
            black.addPawn(new Pawn(PawnType.BISHOP, new Position(2, 7), "Black"));
            black.addPawn(new Pawn(PawnType.KING, new Position(3, 7), "Black"));
            black.addPawn(new Pawn(PawnType.QUEEN, new Position(4, 7), "Black"));
            black.addPawn(new Pawn(PawnType.BISHOP, new Position(5, 7), "Black"));
            black.addPawn(new Pawn(PawnType.ROOK, new Position(6, 7), "Black"));
            black.addPawn(new Pawn(PawnType.KNIGHT, new Position(7, 7), "Black"));

            white.render(((Canvas)_gameView.FindName("Game")));

            black.render(((Canvas)_gameView.FindName("Game")));



        }



    }
}
