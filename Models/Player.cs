using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Chess.Models
{
    enum Destination
    {
        FORWARD,
        BACKWARD
    }

    internal class Player
    {
        public List<Pawn> pawns = new List<Pawn>();
        public Destination destination;
        string color;

        public Player(string color, Destination destination)
        {
            this.color = color;
            this.destination = destination;
        }

        public Player addPawn(Pawn pawn)
        {
            pawns.Add(pawn);
            return this;
        }

        public void render(Canvas canvas)
        {
            pawns.ForEach(pawn =>
            {
                pawn.RenderPawn(canvas);
            });
        }
    }
}
