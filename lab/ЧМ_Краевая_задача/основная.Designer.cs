namespace ЧМ_Краевая_задача
{
    partial class основная
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(основная));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основная1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основная2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.graf_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.graf_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.x_osnov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n_osnov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epsilon2_osnov = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основная1ToolStripMenuItem,
            this.основная2ToolStripMenuItem});
            this.задачаToolStripMenuItem.Name = "задачаToolStripMenuItem";
            this.задачаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.задачаToolStripMenuItem.Text = "Задача";
            // 
            // основная1ToolStripMenuItem
            // 
            this.основная1ToolStripMenuItem.Name = "основная1ToolStripMenuItem";
            this.основная1ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.основная1ToolStripMenuItem.Text = "тестовая_1";
            this.основная1ToolStripMenuItem.Click += new System.EventHandler(this.основная1ToolStripMenuItem_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 168);
            this.dataGridView1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 20);
            this.button1.TabIndex = 56;
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
            this.graf_chart1.Location = new System.Drawing.Point(713, 27);
            this.graf_chart1.Name = "graf_chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graf_chart1.Series.Add(series1);
            this.graf_chart1.Size = new System.Drawing.Size(615, 315);
            this.graf_chart1.TabIndex = 62;
            this.graf_chart1.Text = "graf_chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(768, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "u";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(1209, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "x";
            // 
            // graf_chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.graf_chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graf_chart2.Legends.Add(legend2);
            this.graf_chart2.Location = new System.Drawing.Point(713, 356);
            this.graf_chart2.Name = "graf_chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graf_chart2.Series.Add(series2);
            this.graf_chart2.Size = new System.Drawing.Size(615, 315);
            this.graf_chart2.TabIndex = 65;
            this.graf_chart2.Text = "chart1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-3, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "и соответствует узлу x=\r\n";
            // 
            // x_osnov
            // 
            this.x_osnov.Location = new System.Drawing.Point(130, 353);
            this.x_osnov.Name = "x_osnov";
            this.x_osnov.Size = new System.Drawing.Size(70, 20);
            this.x_osnov.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Для решения основной задачи использована сетка с числом разбиений по x n=";
            // 
            // n_osnov
            // 
            this.n_osnov.Location = new System.Drawing.Point(416, 313);
            this.n_osnov.Name = "n_osnov";
            this.n_osnov.Size = new System.Drawing.Size(70, 20);
            this.n_osnov.TabIndex = 79;
            this.n_osnov.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "При пересчете задачи с половинным шагом максимальная разность приближенных решени" +
    "й составила epsilon2 =  \r\n";
            // 
            // epsilon2_osnov
            // 
            this.epsilon2_osnov.Location = new System.Drawing.Point(591, 335);
            this.epsilon2_osnov.Name = "epsilon2_osnov";
            this.epsilon2_osnov.Size = new System.Drawing.Size(116, 20);
            this.epsilon2_osnov.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // основная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.epsilon2_osnov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_osnov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x_osnov);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.graf_chart2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.graf_chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "основная";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "основная";
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
        private System.Windows.Forms.ToolStripMenuItem основная1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основная2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_chart2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox x_osnov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_osnov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epsilon2_osnov;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}