﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerVisionLab1
{
    public partial class Form1 : Form
    {

        private DataTable data;
        private string selectedValue = "0";
        private int radius;
        private int hasOrNo = 0;
        public Form1()
        {
            InitializeComponent();    
            for (int i = 1; i < 101; i++)
            {
                comboBox1.Items.Add(i);
            }

            comboBox1.SelectedItem = 1;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                data = openFile(openFileDialog.FileName);
                dataGridView1.DataSource = data;

                Bitmap bmp = new Bitmap(400, 400);
                Graphics g = Graphics.FromImage(bmp);
                CreateBitmapFromData(g, bmp);
                //pictureBox1.Image = bmp;
            }

        }


        private DataTable openFile(string filePath) 
        {
            DataTable dataTable = new DataTable();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] header = "X Y Яркость".Split(' ');
                foreach (string column in header)
                {
                    dataTable.Columns.Add(column);
                }

                while (!reader.EndOfStream)
                {
                    string[] rows = reader.ReadLine().Split(' ');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        
        
        
        private void CreateBitmapFromData(Graphics g, Bitmap bitmap)
        {
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                FillNewPixel(g, data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString());
                
                    //bitmap.SetPixel((int)(k*x), (int)(k*y), color)
            }

            pictureBox1.Image = bitmap;

            // return bitmap;
        }

        private void FillNewPixel(Graphics g, string x, string y, string z)
        {
            float k = (float)400 / 1024;
            Rectangle r = new Rectangle();
            int X = int.Parse(x);
            int Y = int.Parse(y);
            int Z = int.Parse(z);
            r.Width = 3;
            r.Height = 3;
            r.X = (int)(X * k);
            r.Y = (int)(Y * k);
            Color color = Color.FromArgb(Z, Z, Z);
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, r);
        }
        
        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnGeneration_Click(object sender, EventArgs e) // добавляет в csv новые данные
        {
            Random rand = new Random();
            string x, y, z;
            int i;

            for (i = 0; i < int.Parse(selectedValue); i++)
            {
                x = rand.Next(0, 1024).ToString();
                y = rand.Next(0, 1024).ToString();
                z = rand.Next(0, 255).ToString();
                downloadPoint(x,y,z);
            }
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            downloadPoint(textBoxX.Text, textBoxY.Text, textBoxJ.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            selectedValue = comboBox.SelectedItem.ToString();
            
        }


        private void downloadPoint(string a, string b, string c)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Documents\\КириллТерещенко\\вуз\\шарпы\\ComputerVision\\data.csv", true, Encoding.ASCII);
            if (a != null && b != null && c != null)
            {
                sw.WriteLine($"{a} {b} {c}");
            }
            sw.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddClusterToDataGrid()
        {
            if (hasOrNo == 0)
            {
                data.Columns.Add("кластеризация");
                hasOrNo = 1;
            }

            foreach (DataRow row in data.Rows)
            {
                row["кластер"] = 0;
            }
            findClusters(); 
        }

        private void clusterButton_Click(object sender, EventArgs e)
        {
            AddClusterToDataGrid();
        }



        private void findClusters()
        {
            int currentX, currentY, cirrentI = 0, currentCluster = 0;
            int nullCenterX = int.Parse(data.Rows[0][0].ToString());
            int nullCenterY = int.Parse(data.Rows[0][1].ToString());
            int nextCenterX = 0, nextCenterY = 0, block = 0;
            data.Rows[0][3] = currentCluster;

            while (nullCenterX != nextCenterX && nullCenterY != nextCenterY)
            {
                block = 0;
                for (int i = cirrentI; i < data.Rows.Count; i++)
                {
                    currentX = int.Parse(data.Rows[i][0].ToString());
                    currentY = int.Parse(data.Rows[i][1].ToString());
                    if (findDistance(nullCenterX, nullCenterY, currentX, currentY) < radius)
                    {
                        data.Rows[i][3] = currentCluster;
                    }
                    else
                    {
                        if (block == 0)
                        {
                            nextCenterX = currentX;
                            nextCenterY = currentY;
                            block = 1;
                            
                        }
                    }
                }

                nullCenterX = nextCenterX;
                nullCenterY = nextCenterY;
            } 
        }
        

    int findDistance(int x1, int y1, int x2, int y2)
        {
            return (int) Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBoxRadius_TextChanged(object sender, EventArgs e)
        {
            radius = int.Parse(textBoxRadius.Text);
        }
    }
}    

