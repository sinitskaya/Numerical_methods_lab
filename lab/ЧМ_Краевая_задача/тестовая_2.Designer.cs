namespace ЧМ_Краевая_задача
{
    partial class тестовая_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(тестовая_2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основная1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.graf_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N_test2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.epsilon1_test2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x_test2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестоваяToolStripMenuItem,
            this.основная1ToolStripMenuItem});
            this.задачаToolStripMenuItem.Name = "задачаToolStripMenuItem";
            this.задачаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.задачаToolStripMenuItem.Text = "Задача";
            // 
            // тестоваяToolStripMenuItem
            // 
            this.тестоваяToolStripMenuItem.Name = "тестоваяToolStripMenuItem";
            this.тестоваяToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.тестоваяToolStripMenuItem.Text = "основная";
            this.тестоваяToolStripMenuItem.Click += new System.EventHandler(this.тестоваяToolStripMenuItem_Click);
            // 
            // основная1ToolStripMenuItem
            // 
            this.основная1ToolStripMenuItem.Name = "основная1ToolStripMenuItem";
            this.основная1ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.основная1ToolStripMenuItem.Text = "тестовая_1";
            this.основная1ToolStripMenuItem.Click += new System.EventHandler(this.основная1ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 228);
            this.dataGridView1.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 21);
            this.button1.TabIndex = 68;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graf_chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.graf_chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graf_chart1.Legends.Add(legend3);
            this.graf_chart1.Location = new System.Drawing.Point(704, 27);
            this.graf_chart1.Name = "graf_chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graf_chart1.Series.Add(series3);
            this.graf_chart1.Size = new System.Drawing.Size(615, 315);
            this.graf_chart1.TabIndex = 88;
            this.graf_chart1.Text = "graf_chart1";
            // 
            // graf_chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.graf_chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graf_chart2.Legends.Add(legend4);
            this.graf_chart2.Location = new System.Drawing.Point(704, 348);
            this.graf_chart2.Name = "graf_chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.graf_chart2.Series.Add(series4);
            this.graf_chart2.Size = new System.Drawing.Size(615, 315);
            this.graf_chart2.TabIndex = 89;
            this.graf_chart2.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(1214, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(1200, 618);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 93;
            this.label17.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Для решения тестовой задачи использована сетка с числом разбиений по x n=";
            // 
            // N_test2
            // 
            this.N_test2.Location = new System.Drawing.Point(416, 357);
            this.N_test2.Name = "N_test2";
            this.N_test2.Size = new System.Drawing.Size(70, 20);
            this.N_test2.TabIndex = 95;
            this.N_test2.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 26);
            this.label2.TabIndex = 96;
            this.label2.Text = "Требуемая точность решения тестовой задачи   epsilon = 0.5*10^(-6).\r\n\r\n";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-2, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 26);
            this.label18.TabIndex = 97;
            this.label18.Text = "Tестовая задача решена с точностью epsilon1 =\r\n\r\n";
            // 
            // epsilon1_test2
            // 
            this.epsilon1_test2.Location = new System.Drawing.Point(254, 405);
            this.epsilon1_test2.Name = "epsilon1_test2";
            this.epsilon1_test2.Size = new System.Drawing.Size(186, 20);
            this.epsilon1_test2.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Максимальное отклонение точного и приближенного решений наблюдаются в точке x = \r" +
    "\n\r\n";
            // 
            // x_test2
            // 
            this.x_test2.Location = new System.Drawing.Point(462, 431);
            this.x_test2.Name = "x_test2";
            this.x_test2.Size = new System.Drawing.Size(70, 20);
            this.x_test2.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // тестовая_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.x_test2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epsilon1_test2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N_test2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.graf_chart2);
            this.Controls.Add(this.graf_chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "тестовая_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "тестовая_2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестоваяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основная1ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox N_test2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox epsilon1_test2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x_test2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}