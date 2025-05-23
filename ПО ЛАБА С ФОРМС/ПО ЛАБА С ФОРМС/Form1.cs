using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ПО_ЛАБА_С_ФОРМС
{
    public partial class Form1 : Form
    {
        private List<Route> routes = new List<Route>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView(); // Добавляем таблицу при загрузке формы
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            string from = txtFrom.Text;
            string to = txtTo.Text;
            double distance, time;

            if (!double.TryParse(txtDistance.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out distance) || distance <= 0 ||
                !double.TryParse(txtTime.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out time) || time <= 0)
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения (например: 4.5, 10).");
                return;
            }

            string comment = txtComment.Text;

            routes.Add(new Route { From = from, To = to, Distance = distance, Time = time, Comment = comment });

            UpdateTable();
            pictureBox1.Invalidate();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Column1", "Откуда");
            dataGridView1.Columns.Add("Column2", "Куда");
            dataGridView1.Columns.Add("Column3", "Расстояние");
            dataGridView1.Columns.Add("Column4", "Время");
            dataGridView1.Columns.Add("Column5", "Ср.Скорость");
            dataGridView1.Columns.Add("Column6", "Комментарий");
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            foreach (var route in routes.OrderBy(r => r.From))
            {
                dataGridView1.Rows.Add(route.From, route.To, route.Distance, route.Time, route.Speed.ToString("F2"), route.Comment);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (routes.Count < 2) return;

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            int startX = 50, startY = 50, step = 100;
            Point[] points = new Point[routes.Count];

            for (int i = 0; i < routes.Count; i++)
            {
                points[i] = new Point(startX + i * step, startY + i * step);
            }

            for (int i = 0; i < points.Length - 1; i++)
            {
                g.DrawLine(pen, points[i], points[i + 1]);
                g.DrawString(routes[i].From, font, brush, points[i]);
            }

            g.DrawString(routes[^1].To, font, brush, points[^1]);

            pen.Dispose();
            brush.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клик по PictureBox!");
        }
    }

    public class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Distance { get; set; }
        public double Time { get; set; }
        public string Comment { get; set; }
        public double Speed => Distance / Time;
    }
}