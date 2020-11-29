using System;

namespace ChessLib
{

    [Serializable]
    public class ChessEventArgs
    {
        public int NewX { get; private set; }
        public int NewY { get; private set; }


        public int OldX { get; private set; }
        public int OldY { get; private set; }
        public ChessEventArgs(int newX, int newY, int oldX, int oldY)
        {
            NewX = newX;
            NewY = newY;
            OldX = oldX;
            OldY = oldY;

        }

    }
    public delegate void ChessEventHandler(object sender, ChessEventArgs e);

}
