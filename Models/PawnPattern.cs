using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    enum Move
    {
        STRAIGHT,
        BACKWARD,
        LEFT,
        RIGHT,

        STRAIGHTLEFT,
        BACKWARDLEFT,
        STRAIGHTRIGHT,
        BACKWARDRIGHT,
    }

    internal class MovePattern
    {
        public Queue<Move> move;
        public bool? unlimitedMove = false;

        public MovePattern(Queue<Move> move)
        {
            this.move = move;
        }
        public MovePattern(Queue<Move> move, bool? unlimitedMove) : this(move)
        {
            this.unlimitedMove = unlimitedMove;
        }

        public MovePattern AddMove(Move move)
        {
            this.move.Enqueue(move);
            return this;
        }
    }
}
