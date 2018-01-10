using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntProb
{
    public class Node : Button
    {
        
        public float oldProb=1,newProb=1;
        public float oldProbFood = 0,newProbFood=0;
        public float totalProb = 0;
        public float GoingProb;

       // public int numSuc;

        public int x, y;

        //public int steps=0;
        public List<StepType> st = new List<StepType>();

        public bool foodCell = false;
        public bool nestCell = false;
        public bool inFoodPath = false;

        public Node foodPathFoodCell=null;

        public bool updated = false;

       public List<Node> succs = new List<Node>(8);

        //public Button btn = new Button();

        public void setTotalProb()
       {
           totalProb= newProbFood + newProb;
       }

       public void setSuccs(Node[,] nd,int rows, int cols)
       {
           for (int dx = (x > 0 ? -1 : 0); dx <= (x < (rows - 1) ? 1 : 0); ++dx)
           {
               for (int dy = (y > 0 ? -1 : 0); dy <= (y < (cols - 1) ? 1 : 0); ++dy)
               {
                   if (dx != 0 || dy != 0)
                   {
                       //if(foodCell)
                       //{
                       //    if(nd[x + dx, y + dy].inFoodPath)
                       //        succs.Add(nd[x + dx, y + dy]);
                       //}
                       //else
                        succs.Add(nd[x + dx, y + dy]);
                   }
               }
           }
       }

        


    }
}
