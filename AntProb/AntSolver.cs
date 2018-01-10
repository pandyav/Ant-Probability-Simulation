using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AntProb
{
    public partial class AntSolver : Form
    {
       // Button[,] bt = new Button[5, 5];
        
        Node[,] nd;// = new Node[Rows,5];
        int rows, cols;
        Node nest;
        List<Node> foodcls = new List<Node>();
        int iter; 
        public AntSolver()
        {
            InitializeComponent();
          //  AllocConsole();

            //Button[,] bt = new Button[5,5];
            
        }
        private void AntSolver_Load(object sender, EventArgs e)
        {
           // Thread gridThread = new Thread(serverThread);
            //gridThread.Start();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void removeAllButtons()
        {
            foreach(Button b in this.Controls.OfType<Button>())
            {
                //this.Controls.Remove(b);
                if (panel1.InvokeRequired)
                {
                    panel1.Invoke(new MethodInvoker(delegate { panel1.Controls.Clear(); }));
                }
                else
                    panel1.Controls.Clear();
            }
        }
        bool tdSt = false;
        private void serverThread()
        {
           // Panel p2 = new Panel();
            //this.Controls.Add(p2);
            Node nt1;
            while(true)
            {
                if(tdSt)
                {
                    removeAllButtons();
                    rows = int.Parse(RowsTextbox.Text);
                    cols = int.Parse(ColsTextbox.Text);
                    float percentAdd = 100.0f / (rows * cols);
                    float perc = 0;
                    nd = new Node[rows, cols];
                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < cols; y++)
                        {
                            // Button bt1 = new Button();
                            nt1 = new Node();

                            nt1.Height = 40;
                            nt1.Width = 40;
                            nt1.Location = new Point(x * 40, y * 40);
                            nt1.FlatStyle = FlatStyle.Flat;
                            nt1.Click += new EventHandler(buttAll_Click);
                            nt1.x = x;
                            nt1.y = y;
                            //if ((y>=BoundYMin)&&(y<(BoundYMin+15)))
                            //    nt1.Visible = true;
                            //else
                            //    nt1.Visible = false;
                            //    nt1.btn.Click += buttclk();
                            // bt1.Text = "btn" + x+","+y;
                            nd[x, y] = nt1;
                            //this.Controls.Add(nd[x, y].btn);
                            if (panel1.InvokeRequired)
                            {
                                panel1.Invoke(new MethodInvoker(delegate { panel1.Controls.Add(nd[x, y]); }));
                            }
                            else 
                                panel1.Controls.Add(nd[x, y]);

                            perc += percentAdd;
                            if (progressBar1.InvokeRequired)
                            {
                                progressBar1.Invoke(new MethodInvoker(delegate
                                {
                                    if (((int)perc + 1) <= 100) 
                                        progressBar1.Value = (int)perc + 1;
                                    progressBar1.Value = (int)perc;

                                    PercentLabel.Text = (int)perc + " %";
                                }));
                            }
                            else
                            {
                                progressBar1.Value = (int)perc + 1;
                                progressBar1.Value = (int)perc;
                                PercentLabel.Text = (int)perc + " %";
                            }
                        }

                    }
                    int nestX = int.Parse(NestTextboxX.Text), nestY = int.Parse(NestTextboxY.Text);
                    nd[nestX, nestY].FlatAppearance.BorderColor = Color.Red;
                    nd[nestX, nestY].FlatAppearance.BorderSize = 4;
                    nd[nestX, nestY].nestCell = true;
                    nest = nd[nestX, nestY];
                    nd[nestX, nestY].inFoodPath = true;

                    tdSt = false;
                }
            }
        }
        int countFoodLoc;
        private void button1_Click(object sender, EventArgs e)
        {
            //Button bt = (Button)sender;
           // MessageBox.Show("Hello "+bt.Text);

            removeAllButtons();
           // rows = int.Parse(RowsTextbox.Text);
            //cols = int.Parse(ColsTextbox.Text);
            rows = int.Parse(ColsTextbox.Text);
            cols = int.Parse(RowsTextbox.Text);

            nd = new Node[rows, cols];

           // tdSt = true;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    // Button bt1 = new Button();
                    Node nt1 = new Node();

                    nt1.Height = 40;
                    nt1.Width = 40;
                    nt1.Location = new Point(x * 40, y * 40);
                    nt1.FlatStyle = FlatStyle.Flat;
                    nt1.Click += new EventHandler(buttAll_Click);
                    nt1.x = x;
                    nt1.y = y;
                    //    nt1.btn.Click += buttclk();
                    // bt1.Text = "btn" + x+","+y;
                    nd[x, y] = nt1;
                    //this.Controls.Add(nd[x, y].btn);
                    panel1.Controls.Add(nd[x, y]);
                }

            }
          //  int nestX = int.Parse(NestTextboxX.Text), nestY = int.Parse(NestTextboxY.Text);
            int nestX = int.Parse(NestTextboxY.Text), nestY = int.Parse(NestTextboxX.Text);
            nd[nestX, nestY].FlatAppearance.BorderColor = Color.Red;
            nd[nestX, nestY].FlatAppearance.BorderSize = 4;
            nd[nestX, nestY].nestCell = true;
            nest = nd[nestX, nestY];
            nd[nestX, nestY].inFoodPath = true;



           // nd[5, 0].steps = 3;
           // nd[2, 3].FlatAppearance.BorderColor = Color.LimeGreen;
          //  nd[2, 3].foodCell = true;
          //  foodcls.Add(nd[2, 3]);
           // nd[2, 3].newProbFood = 1;
           // nd[2, 3].oldProbFood = 1;
            //nd[3, 2].inFoodPatth = true;
            //nd[3, 2].steps = 1;
            //nd[4, 1].inFoodPath = true;
          //  nd[4, 1].steps = 2;
            string[] flist = FoodsCellsList.Text.Split(';');

            countFoodLoc = flist.Length;
            setFoodPath(flist);
            iter = int.Parse(IterTextbox.Text);

            i = 0;


            setSuc();
           
           // IterTextbox.Text = i+"";
          //  panel1.Controls.Add(TimeStepLabel);
            TimeStepLabel.Text = i + "";
            updateColor();
            i++;
           if (iter > 0)
              timer1.Start();
           //while (iter > 0)
           //{


           //    // b.BackColor = Color.FromArgb(50, 50, 50);
           //    setProbs();
           //    // normalize();
           //    updateColor();





           //    iter--;

           //}
           // normalize();
            //updateColor();
        }
        private void updateColor()
        {
            int backColor = 255;
            float pert;
            int greyMult;
            if (countFoodLoc <= 1)
                greyMult = 70;
            else if (countFoodLoc == 2)
                greyMult = 60;
            else
                greyMult = 55;
            foreach(Node n in nd)
            {
                pert = n.totalProb * greyMult;
                n.BackColor = Color.FromArgb((int)(backColor - pert), (int)(backColor - pert), (int)(backColor - pert));
            }
        }
        private float sumProb()
        {
            float sum = 0;
            foreach (Node n in nd)
            {
                sum += n.totalProb;
            }
            return sum;
        }
        private void normalize()
        {
            float s = sumProb();
            foreach(Node n in nd)
            {
                n.totalProb = n.totalProb / s;
            }
        }
        private void setProbs()
        {
           //int backColor=3;
            foreach(Node n in nd)
            {
               // n.updated = false;
                n.oldProb = n.newProb;
                n.newProb = 0;
                n.oldProbFood = n.newProbFood;
                n.newProbFood = 0;
                foreach(Node n1 in n.succs)
                {
                    //n1.oldProb = n1.newProb;
                    if (n.inFoodPath)
                    {
                        if (n1.foodCell)
                        {
                            n1.oldProbFood = n1.oldProb;
                            n1.newProbFood = n1.newProb;

                        }
                        if (n1.foodCell || (n1.inFoodPath&&n1.foodPathFoodCell.Equals(n.foodPathFoodCell))||n.nestCell)
                        {
                           // Node t;
                            int tempN1=0, tempN=0;

                            if (n1.st.Count == 1)
                                tempN1 = n1.st.ElementAt(0).steps;
                            if (n.st.Count == 1)
                                tempN = n.st.ElementAt(0).steps;

                                foreach(StepType s in n1.st)
                                {
                                    foreach (StepType s1 in n.st)
                                    {
                                    if (s.foodCell.Equals(s1.foodCell))
                                    {
                                        tempN1 = s.steps;
                                        tempN = s1.steps;
                                    }
                                    }
                                }
                               
                                    
                               
                          
                            
                                //if (n1.steps < n.steps)
                                if (tempN1 < tempN)
                                {
                                   // if (n.steps <= int.Parse(IterTextbox.Text))
                                    //{
                                        // n.newProb += n1.oldProb;
                                       
                                          
                                            if(n1.updated)
                                                n.newProbFood = n1.oldProbFood;
                                            else
                                                n.newProbFood = n1.newProbFood;

                                            if (n.nestCell)
                                            {
                                                n.newProb += n.newProbFood;
                                                n.newProbFood = 0; ;
                                            }
                                   // }
                                }
                            
                        }
                        
                    }

                    if (!n1.foodCell)
                    {
                        if(n1.updated)
                            n.newProb += (n1.oldProb / n1.succs.Count);
                        else
                            n.newProb += (n1.newProb / n1.succs.Count);

                    }
                  
                }

                //n.BackColor = Color.FromArgb((int)(255-n.newProb * backColor), (int)(255-n.newProb *backColor), (int)(255-n.newProb * backColor));

                n.setTotalProb();
                n.updated = true;
            }
            resetUpdated();
        }

        private void resetUpdated()
        {
            foreach (Node n in nd)
            {
                n.updated = false;
            }
        }
        private void setSuc()
        {
            foreach(Node n in nd)
            {
                n.setSuccs(nd, rows, cols);
            }
        }
        private void buttclk(object sender,Node n)
        {

        }
        private void buttAll_Click(object sender, EventArgs e)
        {
            Node bt = (Node)sender;
           //List<Node> result = new List<Node>(8);

           //for (int dx = (bt.x > 0 ? -1 : 0); dx <= (bt.x < (rows-1) ? 1 : 0); ++dx)
           //{
           //    for (int dy = (bt.y > 0 ? -1 : 0); dy <= (bt.y < (cols-1) ? 1 : 0); ++dy)
           //    {
           //        if (dx != 0 || dy != 0)
           //        {
           //            result.Add(nd[bt.x + dx,bt.y + dy]);
           //        }
           //    }
           //}
               
           
            MessageBox.Show(bt.totalProb+"");
          
       

                
            
          // int distance = Math.Abs(2 - 5) + Math.Abs(3 - 0);
           // MessageBox.Show(String.Join("|",ls.ToArray()));
        //   MessageBox.Show(distance+"");
        }
        List<string> ls;
        public void setFoodPath(string[] f)
        {
           // ls = new List<string>();
          //  Console.WriteLine("-----------");
            foreach (string foodcell in f)
            {

                string[] splitXY = foodcell.Split(',');
                int s = 1;
               // int x = int.Parse(splitXY[0]), y = int.Parse(splitXY[1]);
                int x = int.Parse(splitXY[1]), y = int.Parse(splitXY[0]);
                nd[x, y].FlatAppearance.BorderColor = Color.LimeGreen;
                nd[x, y].FlatAppearance.BorderSize = 4;
                nd[x, y].foodCell = true;

                Node temp = nd[x, y];
                //  foodcls.Add(nd[2, 3]);
                nd[x, y].newProbFood = 1;
                nd[x, y].oldProbFood = 1;
                while ((x < nest.x) || (x > nest.x) || (y < nest.y) || (y > nest.y))
                {
                    if (x < nest.x)
                    {
                        x++;
                    }
                    else if (x > nest.x)
                    {
                        x--;
                    }

                    if (y < nest.y)
                    {
                        y++;
                    }
                    else if (y > nest.y)
                    {
                        y--;
                    }

                    // ls.Add(x + "," + y);
                    nd[x, y].inFoodPath = true;
                   // nd[x, y].steps = s;
                    nd[x, y].st.Add(new StepType(temp, s));
                    nd[x, y].foodPathFoodCell = temp;

                 //  Console.WriteLine(x + "," + y);
                    s++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (iter > 0)
            {

                setProbs();
             //  normalize();
             //   IterTextbox.Text = i + "";
                TimeStepLabel.Text = i + "";
                updateColor();

            }
            else timer1.Stop();




            i++;
            iter--;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tdSt = true;
        }
        int BoundYMin = 0;
        private void AntSolver_FormClosing(object sender, FormClosingEventArgs e)
        {
           // List<Control> ctrls = new List<Control>(panel1.Controls);
            panel1.Controls.Clear();
            foreach (Control c in panel1.Controls)
                c.Dispose();

            this.Controls.Clear();
            foreach (Control c in this.Controls)
                c.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AntSolver_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                foreach (System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
                    if (myProc.ProcessName == "process name")
                        myProc.Kill();
            }
            catch (Exception ex) { }

            Application.ExitThread();
           // Environment.Exit();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

       
    }
}
