using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ЧМ_Краевая_задача
{
    public partial class основная : Form
    {
        void metod(double h, int N, double[] y)
        {
            double[] A = new double[N - 2];
            double[] B = new double[N - 2];
            double[] C = new double[N - 1];
            double[] F = new double[N - 1];
            double[] xi = new double[N+1];
            double u0 = 1, un = 2;
            //коэфициенты
            double[] ai = new double[N];
            double[] di = new double[N-1];
            double[] phi_i = new double[N-1];
            for (int i = 0; i < xi.Length; i++)
            {
                xi[i] = i * h;
            }
            koeffi(ai, di, phi_i, xi, h, N);
            ///////////////////////////////заполнение матрицы
            for (int i = 0; i < N - 1; i++)
            {//диагональ
                C[i] = -((ai[i] + ai[i + 1]) / h / h + di[i]);
            }

            for (int i = 0; i < N - 2; i++)
            {
                A[i] = ai[i+1] / h / h;
                B[i] = ai[i+1] / h / h;
            }
            F[0] = -phi_i[0] - (ai[0] / h / h) * u0;
            F[F.Length - 1] = -phi_i[phi_i.Length - 1] - (ai[ai.Length-1] / h / h) * un;
            for (int i = 1; i < F.Length - 1; i++)//середина
            {
                F[i] = -phi_i[i];
            }
            ///////////////////////////////заполнение матрицы
            progonka(A, C, B, F, y);
        }
    
        void koeffi(double[] ai, double[] di, double[] phi_i, double[] xi, double h, int N)
        {
            double x2, x1, ksi = 1.0 / 3;
            //xi+1/2 //xi-1/2
            for (int i = 1; i < N+1; i++)
            {
                x1 = xi[i] - h / 2;
                x2 = xi[i] + h / 2;

                if (xi[i - 1] < ksi && xi[i] > ksi)
                {                                               //k1=x+1                                               //k2=1
                    ai[i - 1] = Math.Pow(   (   (ksi - xi[i - 1]) / (h*( (ksi + xi[i - 1]) / 2 + 1) )   ) +  ((xi[i] - ksi) / h), -1);
                    ///k1((ksi+xi[i-1])/2)=(ksi+xi[i-1])/2   +   1
                    //k2((xi+ksi)/2) = (xi[i] + ksi)/2  +   1
                }
                else if (ksi >= xi[i])
                {
                    ai[i-1] = (x1 + 1);
                    //k1(xi-1/2) ksi >= xi
                }
                else if (xi[i-1] >= ksi)
                {
                    ai[i-1] = 1;
                    //k2(xi-1/2)
                }
            }
                ////////////////////////////
            for (int i = 1; i < N; i++)
            {
                x1 = xi[i] - h / 2;
                x2 = xi[i] + h / 2;

                if (x1 < ksi && x2 > ksi)
                {                                    //q1                            //                //q2
                    di[i-1] = (1 / h) * ((ksi - x1) * (Math.Pow(((x1 + ksi) / 2), 2) + 1) + (x2 - ksi) * (x2 + ksi));
                                                      //f1                 //f2       //  //f2       //                
                    phi_i[i-1] = (1 / h) * (    (ksi - x1) * (1) + (x2 - ksi) * ((x2 * x2 - 1 + ksi * ksi - 1) / 2)     );
                }
                else if (x2 <= ksi)
                {
                    di[i-1] = xi[i] * xi[i] + 1;
                    //q1 = xi^2+1
                    phi_i[i-1] = 1;//phi1
                }
                else if (x1 >= ksi)
                {//q2
                    di[i-1] = 2 * xi[i];                //f1=1                  //f2=x^2-1                     //
                    phi_i[i-1] = (x2*x2-1 + x1*x1-1)/2;
                    //q2(2x)
                }///////////////////////////
            }
        }

        public void progonka(double[] A, double[] C, double[] B, double[] F, double[] y)
        {
            int n = C.Length;
            double[] alpha = new double[y.Length - 1];
            double[] betta = new double[y.Length - 1];
            alpha[0] = -B[0] / C[0];
            betta[0] = F[0] / C[0];
            for (int i = 1; i < y.Length - 1; i++)
            {
                alpha[i] = -B[i] / (alpha[i - 1] * A[i - 1] + C[i]);
                betta[i] = (F[i] - A[i - 1] * betta[i - 1]) / (A[i - 1] * alpha[i - 1] + C[i]);
            }

            y[n - 1] = (F[F.Length - 1] - A[A.Length - 1] * betta[betta.Length - 1]) / (A[A.Length - 1] * alpha[alpha.Length - 1] + C[n - 1]);
            for (int i = y.Length - 2; i >= 0; i--)
            {
                //Console.WriteLine("a");
                y[i] = alpha[i] * y[i + 1] + betta[i];
            }
        }

        public основная()
        {
            InitializeComponent();
        }

        private void основная1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            тестовая_1 основная_1 = new тестовая_1();
            основная_1.ShowDialog();
        }

        private void основная2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            тестовая_2 основная_2 = new тестовая_2();
            основная_2.ShowDialog();
        }

        int N;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                N = int.Parse(n_osnov.Text);
            }
            catch { MessageBox.Show("Некорректные данные"); }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            graf_chart1.Series.Clear();
            graf_chart2.Series.Clear();

            Series SeriesOfPoints_Selective = new Series("Численное v(x)");
            SeriesOfPoints_Selective.ChartType = SeriesChartType.Line;
            SeriesOfPoints_Selective.Color = Color.Red;
            SeriesOfPoints_Selective.BorderWidth = 1;
            Series SeriesOfPoints_Selective_2 = new Series("Численное v2(x)");
            SeriesOfPoints_Selective_2.ChartType = SeriesChartType.Line;
            SeriesOfPoints_Selective_2.Color = Color.Green;
            SeriesOfPoints_Selective_2.BorderWidth = 1;
            Series SeriesOfPoints_Selective_Raznost = new Series("v(x)-v2(x)");
            SeriesOfPoints_Selective_Raznost.ChartType = SeriesChartType.Line;
            SeriesOfPoints_Selective_Raznost.Color = Color.Black;
            SeriesOfPoints_Selective_Raznost.BorderWidth = 1;

            dataGridView1.RowCount = N+1;
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].HeaderText = "№ узла";
            dataGridView1.Columns[1].HeaderText = "xi";
            dataGridView1.Columns[2].HeaderText = "v(xi)";
            dataGridView1.Columns[3].HeaderText = "v2(xi)";
            dataGridView1.Columns[4].HeaderText = "v(xi)-v2(xi)";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 80;
            for (int i = 2; i < 5; i++)
                dataGridView1.Columns[i].Width = 160;
            ///////////////////////////////////////////////////////////////////// 
            double h = 1.0 / N;
            double[] y = new double[N - 1];
            double[] y2 = new double[2*N - 1];
            metod(h, N, y);
            metod(h/2, 2*N, y2);
            double x_max = 0;
            double max_epsilon = Math.Abs(y2[1] - y[0]);
            ///////////////////////////////////////////////////////////////////////
            double u0 = 1, un=2; 
            SeriesOfPoints_Selective.Points.AddXY(0, u0);
            SeriesOfPoints_Selective_2.Points.AddXY(0, u0);//ui=Math.Exp(task.x) * u0[0];
            SeriesOfPoints_Selective_Raznost.Points.AddXY(0, 0);
            for (int i = 0; i < N+1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = i * h;//xi
                if (i == 0)
                {
                    dataGridView1.Rows[i].Cells[2].Value = u0;//v2i
                    dataGridView1.Rows[i].Cells[3].Value = u0;//vi
                    dataGridView1.Rows[i].Cells[4].Value = 0;//vn-v2n=0
                }
                else if (i == N)
                {
                    dataGridView1.Rows[i].Cells[2].Value = un;//v2i
                    dataGridView1.Rows[i].Cells[3].Value = un;//vi
                    dataGridView1.Rows[i].Cells[4].Value = 0;//vn-v2n=0
                }
                else if (i != 0)
                {
                    dataGridView1.Rows[i].Cells[2].Value = y[i - 1];//v
                    dataGridView1.Rows[i].Cells[3].Value = y2[1 + 2 * (i - 1)];//vi
                    dataGridView1.Rows[i].Cells[4].Value = y[i - 1] - y2[1 + 2 * (i - 1)];//vn-v2n=0
                    SeriesOfPoints_Selective.Points.AddXY(i * h, y[i - 1]);
                    SeriesOfPoints_Selective_2.Points.AddXY(i * h, y2[1 + 2 * (i - 1)]);//ui=Math.Exp(task.x) * u0[0];
                    SeriesOfPoints_Selective_Raznost.Points.AddXY(i * h, y[i-1] - y2[1 + 2 * (i - 1)]);
                    double max = Math.Abs(y2[1 + 2 * (i - 1)] - y[i - 1]);
                    if (max_epsilon <= max)
                    {
                        max_epsilon = max;
                        x_max = i * h;
                    }
                }
            }
            SeriesOfPoints_Selective.Points.AddXY(1, un);
            SeriesOfPoints_Selective_2.Points.AddXY(1, un);//ui=Math.Exp(task.x) * u0[0];
            SeriesOfPoints_Selective_Raznost.Points.AddXY(1, 0);

            graf_chart1.Series.Add(SeriesOfPoints_Selective_2);
            graf_chart1.Series.Add(SeriesOfPoints_Selective);
            graf_chart2.Series.Add(SeriesOfPoints_Selective_Raznost);
            x_osnov.Text = x_max.ToString();
            epsilon2_osnov.Text = max_epsilon.ToString();
        }
    }
}
