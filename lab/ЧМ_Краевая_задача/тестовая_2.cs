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
    public partial class тестовая_2 : Form
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
            double[] di = new double[N - 1];
            double[] phi_i = new double[N - 1];
            for (int i = 0; i < xi.Length; i++)
            {
                xi[i] = i * h;
            }
            koeffi(ai, di, phi_i, xi, h);
            ///////////////////////////////заполнение матрицы
            for (int i = 0; i < N - 1; i++)
            {//диагональ
                C[i] = -((ai[i] + ai[i + 1]) / h / h + di[i]);
            }

            for (int i = 0; i < N - 2; i++)
            {
                A[i] = ai[i+1] / h / h;//a2/h^2
                B[i] = ai[i+1] / h / h;
            }
            F[0] = -phi_i[0] - (ai[0] / h / h) * u0;
            F[F.Length - 1] = -phi_i[phi_i.Length - 1] - (ai[ai.Length - 1] / h / h) * un;
            for (int i = 1; i < F.Length - 1; i++)//середина
            {
                F[i] = -phi_i[i];
            }
            ///////////////////////////////заполнение матрицы
            progonka(A, C, B, F, y);
        }

        void koeffi(double[] ai, double[] di, double[] phi_i, double[] xi, double h)
        {
            double x2, x1, ksi = 1.0 / 3, k1 = 4.0/3, k2 = 1;
            //xi+1/2 //xi-1/2
            for (int i = 1; i < N+1; i++)
            {
                //x1 = xi[i] - h / 2;
                //x2 = xi[i] + h / 2;
                if (xi[i - 1] < ksi && xi[i] > ksi)
                {
                    ai[i - 1] = Math.Pow(   ( (ksi - xi[i - 1]) / (h*k1) +  (xi[i] - ksi) / (h*k2)  ), -1);
                    ///k1((ksi+xi[i-1])/2)=(ksi+xi[i-1])/2   +   1
                    //k2((xi+ksi)/2) = (xi[i] + ksi)/2  +   1
                } 
                else if (xi[i-1] >= ksi)
                {
                    ai[i-1] = k2;
                    //k2(xi-1/2)
                }                     
                else if (ksi >= xi[i])///////////////////
                {
                    ai[i-1] = k1;
                    //k1(xi-1/2) ksi >= xi
                }
            }
            ////////////////////////////
            double q1 = 10.0 / 9, q2 = 2.0 / 3, f1 = 1, f2 = -8.0 / 9;
            for (int i = 1; i < N; i++)
            {
                x1 = xi[i] - h / 2;
                x2 = xi[i] + h / 2;

                if (x1 < ksi && x2 > ksi)
                {                                    //q1                            //                //q2
                    di[i-1] = (1 / h) * ((ksi - x1) * q1 + (x2 - ksi) * q2);
                                                         //f1                 //f2       //  //f2       //                
                    phi_i[i-1] = (1 / h) * (   (ksi - x1) * (1) + (x2 - ksi) * ((f2+f2) / 2)  );
                }
                else if (x2 <= ksi)
                {
                    di[i-1] = q1;
                    //q1 = xi^2+1
                    phi_i[i] = 1;//(f1+f1)/2
                }
                else if (x1 >= ksi)
                {//q2
                    di[i-1] = q2;                //f1=1                  //f2=x^2-1                     //
                    phi_i[i-1] = (f2+f2) / 2;
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
                y[i] = alpha[i] * y[i + 1] + betta[i];
            }
        }

        public тестовая_2()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile("3.png");
        }

        private void тестоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            основная тестовая = new основная();
            тестовая.ShowDialog();
        }

        private void основная1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            тестовая_1 основная_1 = new тестовая_1();
            основная_1.ShowDialog();
        }

        int N;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                N = int.Parse(N_test2.Text);//N_max_test_textBox12.Text);//N_max_base_1_textBox2.Text);
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
            Series SeriesOfPoints_Selective_Tochnoe = new Series("Точное u(x)");
            SeriesOfPoints_Selective_Tochnoe.ChartType = SeriesChartType.Line;
            SeriesOfPoints_Selective_Tochnoe.Color = Color.Green;
            SeriesOfPoints_Selective_Tochnoe.BorderWidth = 1;
            Series SeriesOfPoints_Selective_Raznost = new Series("u(x)-v(x)");
            SeriesOfPoints_Selective_Raznost.ChartType = SeriesChartType.Line;
            SeriesOfPoints_Selective_Raznost.Color = Color.Black;
            SeriesOfPoints_Selective_Raznost.BorderWidth = 1;

            dataGridView1.RowCount = N+1;
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].HeaderText = "№ узла";
            dataGridView1.Columns[1].HeaderText = "xi";
            dataGridView1.Columns[2].HeaderText = "u(xi)";
            dataGridView1.Columns[3].HeaderText = "v(xi)";
            dataGridView1.Columns[4].HeaderText = "u(xi)-v(xi)";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 80;
            for (int i = 2; i < 5; i++)
                dataGridView1.Columns[i].Width = 160;
            ///////////////////////////////////////////////////////////////////// 
            double h = 1.0 / N;
            double[] y = new double[N - 1];
            //double[] y2 = new double[N - 1];
            metod(h, N, y);
            //metod(h / 2, N, y2);
            ///////////////////////////////////////////////////////////////////////
            double C1 = 0.29603284941523, C2 = -0.19603284941523, C3 = 1.2583238549506, C4 = 1.1002849690423;
            //double C1 = 0.29603284, C2 = -0.19603284, C3 = 1.2583238, C4 = 1.1002849;
            double[] U = new double[N + 1];//точное решение
            double ksi = 1.0 / 3;
            double x_max = 0;
            double lambd1 = Math.Sqrt((10.0 / 9) / (4.0 / 3)), lambd2 = -lambd1, lambd3 = Math.Sqrt(2.0 / 3), lamdb4 = -lambd3;
            double max_epsilon  = -100000000;
            double u0 = 1, un = 2; 
            SeriesOfPoints_Selective.Points.AddXY(0, u0);
            SeriesOfPoints_Selective_Tochnoe.Points.AddXY(0, C1 + C2 + (9.0 / 10));//ui=Math.Exp(task.x) * u0[0];
            SeriesOfPoints_Selective_Raznost.Points.AddXY(0, C1  + C2  + (9.0 / 10) - u0);
            for (int i = 0; i < N + 1; i++)
            {
                if (i * h <= ksi)
                {
                    U[i] = C1 * Math.Exp(lambd1 * i * h) + C2 * Math.Exp(lambd2 * i * h)+ (9.0/10);
                }
                if ( ksi < i * h )
                {
                    U[i] = C3 * Math.Exp(lambd3 * i * h) + C4 * Math.Exp(lamdb4 * i * h) + ((-8.0 / 9) / (2.0 / 3));
                }
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = i * h;//xi
                dataGridView1.Rows[i].Cells[2].Value = U[i];//ui

                if (i == 0)
                {
                    dataGridView1.Rows[i].Cells[3].Value = u0;//неточн
                    dataGridView1.Rows[i].Cells[4].Value = U[i]-u0;//
                }
                else if (i == N)
                {
                    dataGridView1.Rows[i].Cells[3].Value = un;//неточн
                    dataGridView1.Rows[i].Cells[4].Value = U[i] - u0;//
                }
                else if (i != 0)
                {
                    dataGridView1.Rows[i].Cells[3].Value = y[i-1];//vi
                    dataGridView1.Rows[i].Cells[4].Value = U[i] - y[i-1];//
                    SeriesOfPoints_Selective.Points.AddXY(i * h, y[i-1]);
                    SeriesOfPoints_Selective_Tochnoe.Points.AddXY(i * h, U[i]);//ui=Math.Exp(task.x) * u0[0];
                    SeriesOfPoints_Selective_Raznost.Points.AddXY(i * h, U[i] - y[i-1]);
                    double max = Math.Abs(U[i] - y[i-1]);
                    if (max_epsilon <= max)
                    {
                        max_epsilon = max;
                        x_max = i * h;
                    }
                }
            }
            SeriesOfPoints_Selective.Points.AddXY(1, un);
            SeriesOfPoints_Selective_Tochnoe.Points.AddXY(1, U[U.Length-1]);//ui=Math.Exp(task.x) * u0[0];
            SeriesOfPoints_Selective_Raznost.Points.AddXY(1, U[U.Length - 1] - un);

            graf_chart1.Series.Add(SeriesOfPoints_Selective_Tochnoe);
            graf_chart1.Series.Add(SeriesOfPoints_Selective);
            graf_chart2.Series.Add(SeriesOfPoints_Selective_Raznost);
            x_test2.Text = x_max.ToString();
            epsilon1_test2.Text = max_epsilon.ToString();
            ////////////////////////////////////////////////////////
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////////////
    }     
}
