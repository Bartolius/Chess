using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    internal class PawnMovePatterns
    {
        public PawnType type;
        public List<MovePattern> moves = new();
        public List<MovePattern> attacks = new();

        public PawnMovePatterns(PawnType type) {
            this.type = type;
        }

        public PawnMovePatterns AddMove(MovePattern move)
        {
            moves.Add(move);
            return this;
        }
        public PawnMovePatterns AddAtack(MovePattern attack)
        {
            attacks.Add(attack);
            return this;
        }
    }
}
