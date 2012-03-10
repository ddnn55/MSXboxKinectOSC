using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KinectNui = Microsoft.Research.Kinect.Nui;



namespace Cally
{
    class ClickDetector
    {
        int HISTORY_LENGTH = 30;

        List<KinectNui.Vector> history;

        public ClickDetector()
        {
            history = new List<KinectNui.Vector>();
            System.Console.WriteLine("hey init ClickDetector()");
        }

        public void debugPrint()
        {
            foreach(KinectNui.Vector v in history)
            {
                System.Console.Write("(" + v.X.ToString() + ", " + v.Y.ToString() + ", " + v.Z.ToString() + "), ");
            }
            System.Console.Write("\n");
        }

        public void pushPosition(KinectNui.Vector position)
        {
            history.Add(position);
            if (history.Count() > HISTORY_LENGTH)
                history.RemoveAt(0);

            //debugPrint();
        }
    }
}
