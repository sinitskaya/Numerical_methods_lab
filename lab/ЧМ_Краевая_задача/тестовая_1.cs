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
    public partial class тестовая_1 : Form
    {
        void max_epsilon()
        {
 
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

        public тестовая_1()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile("2.png");
        }

        private void тестоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            основная тестовая = new основная();
            тестовая.ShowDialog();
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
                N = int.Parse(n_test1.Text);
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

            dataGridView1.RowCount = N;
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
            /////////////////////////////////////////////////////////////
            double[] A = new double[N-2];
            double[] B = new double[N-2];
            double[] C = new double[N-1];
            double[] F = new double[N-1];
            double[] y = new double[N-1];	
            int razmer = N-1;
            double h = 1.0 / N;
            double[] xi = new double[N - 1];
            double u0 = 1, un = 2;//ГУ
            double[] U = new double[N-1];//точное решение
            for (int i = 1; i <= xi.Length; i++)
            {
                xi[i - 1] = i * h;
            }

            for (int i = 0; i < N - 1; i++)
            {
                C[i] = 1 - 2 / h / h;
            }

            for (int i = 0; i < N - 2; i++)
            {
                A[i] = 1 / h / h;
                B[i] = 1 / h / h;
            }
            F[0] = xi[0] * xi[0] + 3 - 1 / h / h * u0;
            F[F.Length - 1] = xi[xi.Length - 1] * xi[xi.Length - 1] + 3 - 1 / h / h * un;
            for (int i = 1; i < F.Length - 1; i++)//середина
            {
                F[i] = xi[i] * xi[i] + 3;
            }
            //////////////////////////////////////
            //int k = 0;
            progonka(A, C, B, F, y);
            double max_epsilon = Math.Abs(xi[0] * xi[0] + 1 - y[0]);
            double x_max=0;
            for (int i = 0; i < N-1; i++)
            {
                U[i] = xi[i] * xi[i] + 1;
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = xi[i];//xi
                dataGridView1.Rows[i].Cells[2].Value = U[i];//ui
                dataGridView1.Rows[i].Cells[3].Value = y[i];//vi
                dataGridView1.Rows[i].Cells[4].Value = U[i] - y[i];//vn-v2n=0
                SeriesOfPoints_Selective.Points.AddXY(xi[i], y[i]);
                SeriesOfPoints_Selective_Tochnoe.Points.AddXY(xi[i], U[i]);//ui=Math.Exp(task.x) * u0[0];
                SeriesOfPoints_Selective_Raznost.Points.AddXY(xi[i], U[i] - y[i]);
                double max = Math.Abs(U[i] - y[i]);
                if (max_epsilon < max)
                {
                    max_epsilon = max;
                    x_max = xi[i];
                }
            }

            graf_chart1.Series.Add(SeriesOfPoints_Selective_Tochnoe);
            graf_chart1.Series.Add(SeriesOfPoints_Selective);
            graf_chart2.Series.Add(SeriesOfPoints_Selective_Raznost);
            x_test1.Text = x_max.ToString();
            epsilon1_test1.Text = max_epsilon.ToString();
            //graf_chart1.ChartAreas[0].AxisX.Maximum = xi[xi.Length-1] + h; //Задаешь максимальные значения координат
            //graf_chart1.ChartAreas[0].AxisY.Maximum = task.U[0] + 0.5; //Задаешь максимальные значения координат
            //graf_chart1.ChartAreas[0].AxisX.Minimum = 0; //Задаешь максимальные значения координат
            //chart1.ChartAreas[0].AxisX.Interval = 1; // и можешь интервалы настроить по своему усмотрению
            ///////////////////////////////////////////////////////
            //n_base_1_textBox14.Text = (s - 1).ToString();//n_test_textBox1.Text = (s - 1).ToString();
            //max//maxuivi_test_textBox4.Text = maxuivi.ToString();нет точного решения
            //x_maxuivi_test_textBox9.Text = x1.ToString();
            //maxOLP_base_1_textBox4.Text = maxmodolp.ToString();//maxmod_olp_test_textBox8.Text = maxmodolp.ToString();
            //bxn_test_textBox3.Text = (b_h - task.x).ToString();//double xn = task.x - h;
            ////////////////////////////////////////////////////////
        }
    }
}