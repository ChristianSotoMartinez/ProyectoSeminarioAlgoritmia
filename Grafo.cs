/*
Nombre: Christian Omar Soto Martinez
Codigo: 215475277
Seccion:D01
Fecha de entrega: 29/11/2020
Materia: Seminario de solucion de problemas de algoritmia

Practica: Representacion Grafica de un  grafo

Proposito:
Implementar o crear un software que cree la representación gráfica de un grafo a partir de una matriz de adyacencia

*/



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
        //Creamos una arreglo para asignar nombre a los nodos, columnas y filas de la matriz
        char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        //Contador para verificar la cantidad de filas y nodos a agregar
        int contador = 0;
        //variable que sirve para saber si el grafo fue creado
        bool grafocreado = false;
        //Objeto tipo grafo que se crea
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        public Form1()
        {
            InitializeComponent();
            opc_noponderado.Checked = true;

        }


        //Funcion dedicada al boton "Graficar"
        private void button3_Click(object sender, EventArgs e)
        {
            
            //No se puede crear el grafo si no se han añadido vertices
                if (contador != 0)
                {
                //No se puede crear el grafo si no se marcar el tipo de grafo que es 
                    if (opc_noponderado.Checked == false && opc_ponderado.Checked == false)
                    {
                        MessageBox.Show("Seleccione el tipo de grafo");
                    }
                    // el else del if anterior
                    else
                    {
                        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                        GraphLayout.Controls.Clear();
                        
                        viewer.EdgeInsertButtonVisible = false;
                        viewer.LayoutAlgorithmSettingsButtonVisible = false;
                        viewer.SaveButtonVisible = false;
                        viewer.SaveGraphButtonVisible = false;
                        viewer.UndoRedoButtonsVisible = false;

                        viewer.NavigationVisible = false;
                        for (int i = 0; i < contador; i++)
                        {
                            graph.AddNode(az[i].ToString());
                        }
                        viewer.Graph = graph;
                        this.SuspendLayout();
                        viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                        GraphLayout.Controls.Add(viewer);
                        GraphLayout.ResumeLayout();
                        grafocreado = true;

                    }
                }
                //Mensaje de error si se intento crear el grafo con una cantidad de vertices 0
                else
                {

                    MessageBox.Show("No se añadio ningun vertice o no se selecciono tipo de grafo", "Error");
                }
            
                //Si el grafo fue creado desactivamos los botones menos el de reset
                if(grafocreado == true)
                {
                opc_noponderado.Enabled = false;
                opc_ponderado.Enabled = false;
                agregar_Vertice.Enabled = false;
                eliminar_Vertice.Enabled = false;
                Graficar.Enabled = false;
               
                }
        }

        //Al añadir un vertice  añadimos nodo,columna y fila
        private void agregar_Vertice_Click(object sender, EventArgs e)
        {

            string name = Convert.ToString(az[contador]);
            matriz.Columns.Add(name, name);
            matriz.Rows.Add();
            matriz.Columns[name].DefaultCellStyle.NullValue = "0";

            contador++;


        }


        //Al presionar reset reiniciamos la applicacion
        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Al eliminar un vertice  eliminarmos nodo,columna y fila
        private void eliminar_Vertice_Click(object sender, EventArgs e)

        {
            //Solo se elimina si el contador el mayor a 1
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
        //Boton de salida de la applicacion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton para minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Asignamos el valor a las columnas
        private void matriz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.matriz.Rows[e.RowIndex].HeaderCell.Value = (az[e.RowIndex]).ToString();
        }
        //Para tomar los valores que se ingresan a las celdas de la matriz
        private void matriz_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            
            string newvalue = (string)matriz[e.ColumnIndex, e.RowIndex].Value;
            string pesostr = newvalue;
            //Si el valor es diferente de nuvo
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
        //Se establece el valor nulo por defecto de la matriz
        private void matriz_DefaultValuesNeeded_1(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["a"].Value = "0";
        }
        //Boton que muestra las instrucciones del programa
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            instrucciones instrucciones = new instrucciones();
            instrucciones.ShowDialog();


        }

        int posX;
        int posY;
        //Funcion para arrastrar la ventana
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
