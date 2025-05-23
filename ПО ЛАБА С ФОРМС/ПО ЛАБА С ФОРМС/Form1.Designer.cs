namespace ПО_ЛАБА_С_ФОРМС
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtDistance = new TextBox();
            txtTime = new TextBox();
            txtComment = new TextBox();
            btnAddRoute = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(156, 62);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(117, 27);
            txtFrom.TabIndex = 0;
            txtFrom.TextChanged += txtFrom_TextChanged;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(279, 62);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(115, 27);
            txtTo.TabIndex = 1;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(400, 62);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(125, 27);
            txtDistance.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(531, 62);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 3;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(780, 62);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(125, 27);
            txtComment.TabIndex = 4;
            // 
            // btnAddRoute
            // 
            btnAddRoute.Location = new Point(454, 12);
            btnAddRoute.Name = "btnAddRoute";
            btnAddRoute.Size = new Size(168, 29);
            btnAddRoute.TabIndex = 5;
            btnAddRoute.Text = "Добавить маршрут";
            btnAddRoute.Click += btnAddRoute_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(103, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 318);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Откуда";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Куда";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Расстояние";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Время";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ср.Скорость";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Комментарий";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(933, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(832, 1239);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddRoute);
            Controls.Add(txtComment);
            Controls.Add(txtTime);
            Controls.Add(txtDistance);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtDistance;
        private TextBox txtTime;
        private TextBox txtComment;
        private Button btnAddRoute;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pictureBox1;
    }
}