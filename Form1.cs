using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProcess();
        }

        public void ListAllProcess()
        {
            Process []AllProcess = Process.GetProcesses();
            foreach(Process p in AllProcess)
            {
                try
                {
               
                    dataGridView1.Rows.Add(p.Id, p.ProcessName, p.StartTime.ToShortTimeString());
                   
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //  private void button1_Click(object sender, EventArgs e)
        // {
        //   try
        //   {
        //       Process p1 = Process.GetProcessById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
        //       p1.Kill();
        //   }
        //    catch(Exception ex)
        //    {

        //  }
        //}
    }
}
