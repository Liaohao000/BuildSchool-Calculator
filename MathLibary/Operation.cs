using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MathLibary
{
    public class Operation
    {
        public Math Target { get; set; }

        public int MathAdd()
        {
            return Target.X + Target.Y;
        }

        public int MathSub()
        {
            return Target.X - Target.Y;
        }
        public int MathMult()
        {
            return Target.X * Target.Y;
        }
        public double MathDiv()
        {
            return Target.X / Target.Y;
        }
        
    }
}
