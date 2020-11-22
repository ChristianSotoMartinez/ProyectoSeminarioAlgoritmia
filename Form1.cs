using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminarioAlgoritmia
{
    public partial class Form1 : Form
    {
        char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        int contador = 0;
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        public Form1()
        {
            InitializeComponent();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            GraphLayout.Controls.Clear();
            //openChildForm(new grafo());
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 

            //create the graph content 
            for (int i = 0; i < contador; i++)
            {
                graph.AddNode(az[i].ToString());
            }


            //graph.AddEdge("A", "B");
            //graph.AddEdge("B", "C");
            //graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            //graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            //Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            this.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            GraphLayout.Controls.Add(viewer);
            GraphLayout.ResumeLayout();


        }

        private void agregar_Vertice_Click(object sender, EventArgs e)
        {

            string name = Convert.ToString(az[contador]);
            matriz.Columns.Add(name, name);
            matriz.Rows.Add();

            matriz.Columns[name].DefaultCellStyle.NullValue = "0";

            contador++;


        }

        private void matriz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.matriz.Rows[e.RowIndex].HeaderCell.Value = (az[e.RowIndex]).ToString();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            GraphLayout.Controls.Clear();
            contador = 0;
        }

        private void matriz_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["a"].Value = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            matriz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in matriz.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            matriz.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + textBox1.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void matriz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (matriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //MessageBox.Show(matriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "Fila: " + (e.RowIndex + 1) + "Columna" + (e.ColumnIndex + 1));
                //graph.AddEdge(az[e.RowIndex].ToString(), az[e.ColumnIndex].ToString());
            }
        }

        private void matriz_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void matriz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string pesostr = "";
            string newvalue = (string)matriz[e.ColumnIndex, e.RowIndex].Value;
            textBox1.Text = newvalue;
            textBox2.Text = (e.RowIndex+1).ToString();
            textBox3.Text = (e.ColumnIndex+1).ToString();
            if (textBox1.Text != "1")
            {
                pesostr = textBox1.Text;
            }
            

            graph.AddEdge(az[e.RowIndex].ToString(),pesostr,az[e.ColumnIndex].ToString());
        
        }

        private void valor(object sender, EventArgs e)
        {

        }
    }
}
