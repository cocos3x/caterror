using UnityEngine;

namespace Unity.IO.Compression
{
    internal class Match
    {
        // Fields
        private MatchState state;
        private int pos;
        private int len;
        private byte symbol;
        
        // Properties
        internal MatchState State { get; set; }
        internal int Position { get; set; }
        internal int Length { get; set; }
        internal byte Symbol { get; set; }
        
        // Methods
        internal MatchState get_State()
        {
            return (MatchState)this.state;
        }
        internal void set_State(MatchState value)
        {
            this.state = value;
        }
        internal int get_Position()
        {
            return (int)this.pos;
        }
        internal void set_Position(int value)
        {
            this.pos = value;
        }
        internal int get_Length()
        {
            return (int)this.len;
        }
        internal void set_Length(int value)
        {
            this.len = value;
        }
        internal byte get_Symbol()
        {
            return (byte)this.symbol;
        }
        internal void set_Symbol(byte value)
        {
            this.symbol = value;
        }
        public Match()
        {
        
        }
    
    }

}
