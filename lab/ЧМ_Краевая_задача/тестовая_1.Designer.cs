namespace ЧМ_Краевая_задача
{
    partial class тестовая_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(тестовая_1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основная2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.n_test1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.graf_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_test1 = new System.Windows.Forms.TextBox();
            this.epsilon1_test1 = new System.Windows.Forms.TextBox();
            this.graf_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестоваяToolStripMenuItem,
            this.основная2ToolStripMenuItem});
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
            // основная2ToolStripMenuItem
            // 
            this.основная2ToolStripMenuItem.Name = "основная2ToolStripMenuItem";
            this.основная2ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.основная2ToolStripMenuItem.Text = "тестовая_2";
            this.основная2ToolStripMenuItem.Click += new System.EventHandler(this.основная2ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 228);
            this.dataGridView1.TabIndex = 6;
            // 
            // n_test1
            // 
            this.n_test1.Location = new System.Drawing.Point(417, 363);
            this.n_test1.Name = "n_test1";
            this.n_test1.Size = new System.Drawing.Size(70, 20);
            this.n_test1.TabIndex = 65;
            this.n_test1.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 20);
            this.button1.TabIndex = 67;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graf_chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.graf_chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graf_chart1.Legends.Add(legend1);
            this.graf_chart1.Location = new System.Drawing.Point(696, 27);
            this.graf_chart1.Name = "graf_chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graf_chart1.Series.Add(series1);
            this.graf_chart1.Size = new System.Drawing.Size(615, 315);
            this.graf_chart1.TabIndex = 74;
            this.graf_chart1.Text = "graf_chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(752, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "u";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(1194, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-2, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(413, 13);
            this.label17.TabIndex = 77;
            this.label17.Text = "Для решения тестовой задачи использована сетка с числом разбиений по x n=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-3, 405);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 26);
            this.label18.TabIndex = 78;
            this.label18.Text = "Tестовая задача решена с точностью epsilon1 =\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 26);
            this.label1.TabIndex = 80;
            this.label1.Text = "Максимальное отклонение точного и приближенного решений наблюдаются в точке x = \r" +
    "\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 26);
            this.label2.TabIndex = 81;
            this.label2.Text = "Требуемая точность решения тестовой задачи   epsilon = 0.5*10^(-6).\r\n\r\n";
            // 
            // x_test1
            // 
            this.x_test1.Location = new System.Drawing.Point(461, 428);
            this.x_test1.Name = "x_test1";
            this.x_test1.Size = new System.Drawing.Size(70, 20);
            this.x_test1.TabIndex = 82;
            // 
            // epsilon1_test1
            // 
            this.epsilon1_test1.Location = new System.Drawing.Point(253, 402);
            this.epsilon1_test1.Name = "epsilon1_test1";
            this.epsilon1_test1.Size = new System.Drawing.Size(158, 20);
            this.epsilon1_test1.TabIndex = 83;
            // 
            // graf_chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.graf_chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graf_chart2.Legends.Add(legend2);
            this.graf_chart2.Location = new System.Drawing.Point(696, 348);
            this.graf_chart2.Name = "graf_chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graf_chart2.Series.Add(series2);
            this.graf_chart2.Size = new System.Drawing.Size(615, 315);
            this.graf_chart2.TabIndex = 84;
            this.graf_chart2.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // тестовая_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graf_chart2);
            this.Controls.Add(this.epsilon1_test1);
            this.Controls.Add(this.x_test1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.graf_chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.n_test1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "тестовая_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "тестовая_1";
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
        private System.Windows.Forms.ToolStripMenuItem основная2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox n_test1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_test1;
        private System.Windows.Forms.TextBox epsilon1_test1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}