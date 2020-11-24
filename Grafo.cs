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
        bool grafocreado = false;
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        public Form1()
        {
            InitializeComponent();
            opc_noponderado.Checked = true;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            
                if (contador != 0)
                {
                    if (opc_noponderado.Checked == false && opc_ponderado.Checked == false)
                    {
                        MessageBox.Show("Seleccione el tipo de grafo");
                    }

                    else
                    {
                        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                        GraphLayout.Controls.Clear();
                        //create a viewer object 
                        
                        viewer.EdgeInsertButtonVisible = false;
                        viewer.LayoutAlgorithmSettingsButtonVisible = false;
                        viewer.SaveButtonVisible = false;
                        viewer.SaveGraphButtonVisible = false;
                        viewer.UndoRedoButtonsVisible = false;

                        viewer.NavigationVisible = false;
                        //create a graph object 

                        //create the graph content 
                        for (int i = 0; i < contador; i++)
                        {
                            graph.AddNode(az[i].ToString());
                        }

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
                        grafocreado = true;

                    }
                }

                else
                {

                    MessageBox.Show("No se añadio ningun vertice o no se selecciono tipo de grafo", "Error");
                }
            

                if(grafocreado == true)
                {
                opc_noponderado.Enabled = false;
                opc_ponderado.Enabled = false;
                agregar_Vertice.Enabled = false;
                eliminar_Vertice.Enabled = false;
                Graficar.Enabled = false;
               
                }
        }

        private void agregar_Vertice_Click(object sender, EventArgs e)
        {

            string name = Convert.ToString(az[contador]);
            matriz.Columns.Add(name, name);
            matriz.Rows.Add();
            matriz.Columns[name].DefaultCellStyle.NullValue = "0";

            contador++;


        }



        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void eliminar_Vertice_Click(object sender, EventArgs e)

        {
            
            if (contador > 1)
            {
                contador--;
                graph.RemoveNode(graph.FindNode(az[contador].ToString()));
                matriz.Columns.RemoveAt(contador);
                matriz.Rows.RemoveAt(contador);
                
                
            }


            else {

                MessageBox.Show("Se debe contar con al menos un Vertice", "Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void matriz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.matriz.Rows[e.RowIndex].HeaderCell.Value = (az[e.RowIndex]).ToString();
        }

        private void matriz_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            
            string newvalue = (string)matriz[e.ColumnIndex, e.RowIndex].Value;
            string pesostr = newvalue;

            if (matriz[e.ColumnIndex, e.RowIndex].Value != null)
            {
                if (opc_noponderado.Checked == true)
                {

                    matriz[e.ColumnIndex, e.RowIndex].Value = "1";
                        
                    graph.AddEdge(az[e.RowIndex].ToString(), az[e.ColumnIndex].ToString());
                }

                if (opc_ponderado.Checked == true)
                {
                    graph.AddEdge(az[e.RowIndex].ToString(), pesostr, az[e.ColumnIndex].ToString());
                }
            }

        }

        private void matriz_DefaultValuesNeeded_1(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["a"].Value = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            instrucciones instrucciones = new instrucciones();
            instrucciones.ShowDialog();


        }

        int posX;
        int posY;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
               
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;



            }

            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);

            }
        }
    }
}
