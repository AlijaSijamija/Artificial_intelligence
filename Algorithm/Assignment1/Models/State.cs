using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class State
    {
        public int[][] matrix;
        public int h;
        public State(int dim)
        {
            matrix = new int[dim][];
        }
    }
}
