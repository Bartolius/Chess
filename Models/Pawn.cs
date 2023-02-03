using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chess.Models
{
    class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public char getXAssLetter()
        {
            return X switch
            {
                0 => 'A',
                1 => 'B',
                2 => 'C',
                3 => 'D',
                4 => 'E',
                5 => 'F',
                6 => 'G',
                7 => 'H',
                _ => throw new Exception("Error with position")
            };
        }
    }
    enum PawnType
    {
        PAWN,
        KNIGHT,
        BISHOP,
        ROOK,
        QUEEN,
        KING
    }

    internal class Pawn
    {
        public PawnType pawnType;
        public Position position;
        Rectangle pawn;

        public Pawn(PawnType pawnType, Position position, string color)
        {
            this.pawnType = pawnType;
            this.position = position;

            this.pawn = new Rectangle
            {
                Width = 80,
                Height = 80,
                Fill = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri($@"Images/{pawnType.ToString()+color}.png", UriKind.Relative))
                },
                Stroke = Brushes.Gray,
                StrokeThickness = 1,
                
            };
        }

        public void RenderPawn(Canvas canvas)
        {
            Canvas.SetLeft(pawn, position.X * 80);
            Canvas.SetTop(pawn, position.Y * 80);
            Canvas.SetZIndex(pawn, 1);

            canvas.Children.Add(pawn);
        }

    }
}
