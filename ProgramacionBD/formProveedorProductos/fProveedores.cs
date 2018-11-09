using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;

namespace formProveedorProductos
{
    public partial class formProveedores : Form
    {
        logicaNegocioProveedores lN = new logicaNegocioProveedores();
        
        public formProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (button1.Text == "Guardar") //Para agregar un nuevo registro
                {
                    proveedores objProveedor = new proveedores();//Entidades ---proveedores
                    objProveedor.nombre = txtnombre.Text;
                    objProveedor.direccion = txtdireccion.Text;
                    objProveedor.telefono = txttelefono.Text;

                    if (lN.insertarProveedores(objProveedor) > 0)
                    {
                        MessageBox.Show("Agregado con éxito!");
                        dgvProveedores.DataSource = lN.ListarProveedores(); //Cargar DataGridView para mostrar nuevo registro
                        txtdireccion.Text = "";
                        txtnombre.Text = "";
                        txttelefono.Text = "";
                        tabProveedor.SelectedTab = tabPage2; //Pasar a la tab2

                    }

                    else { MessageBox.Show("Error al agregar proveedor"); }
                }
                if (button1.Text == "Actualizar") //Para actualizar un registro existente
                {

                    proveedores objProveedor = new proveedores();//Entidades ---proveedores
                    objProveedor.idcodigoP = Convert.ToInt32(txtcodigo.Text);
                    objProveedor.nombre = txtnombre.Text;
                    objProveedor.direccion = txtdireccion.Text;
                    objProveedor.telefono = txttelefono.Text;

                    if (lN.EditarProveedor(objProveedor) > 0) 
                    {
                        MessageBox.Show("Actualizado con éxito!");
                        dgvProveedores.DataSource = lN.ListarProveedores(); //Actualizando datos
                        txtdireccion.Text = "";
                        txtnombre.Text = "";
                        txttelefono.Text = "";
                        txtcodigo.Text = "";
                        tabProveedor.SelectedTab = tabPage2; // Pasar al Tab2 para mostrar datos

                    }

                    else { MessageBox.Show("Error al actualizar proveedor"); }

                    button1.Text = "Guardar";
                    
                    
                }
                }
            catch
            {
                MessageBox.Show("Errorrrrr");
            }
        }

        private void formProveedores_Load(object sender, EventArgs e) //Evento Load del formulario
        {
            txtcodigo.Visible = false; //Ocultar cuadro de texto del codigo proveedores
            lbid.Visible = false; //Ocultar etiqueta de codigo proveedores
            dgvProveedores.DataSource= lN.ListarProveedores(); //Cargar datos al DataGridView
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<proveedores> lista = lN.BuscaProveedorDatos(txtbuscar.Text); //Ejecutar método buscar proveedor x nombre o dirección
            dgvProveedores.DataSource = lista; //Carga el dataGridView con los datos encontrados
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtcodigo.Visible = true; //Mostrar cuadro de texto de codigo proveedores
            txtcodigo.Enabled = false;// Mostrar deshabilitado el cuadro texto codigo
            lbid.Visible = true; //Mostrar etiqueta de codigo proveedores

            //Asignando datos a los cuadros de texto para modificar
            //Datos extraidos del datagridview, fila seleccionada
            txtnombre.Text = dgvProveedores.CurrentRow.Cells["nombre"].Value.ToString();
            txtdireccion.Text = dgvProveedores.CurrentRow.Cells["direccion"].Value.ToString();
            txttelefono.Text = dgvProveedores.CurrentRow.Cells["telefono"].Value.ToString();
            txtcodigo.Text = dgvProveedores.CurrentRow.Cells["idcodigoP"].Value.ToString();

            //Cargar Tab1 del formulario, y cambiar el texto del botón guardar por actualizar
            tabProveedor.SelectedTab = tabPage1;
            button1.Text = "Actualizar";
        }

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            int codigop =Convert.ToInt32( dgvProveedores.CurrentRow.Cells["idcodigoP"].Value.ToString());
           
            try
           {
                if(lN.EliminarProveedor(codigop) > 0)
            
                {
                    MessageBox.Show("¡Eliminado con éxito!");
                    dgvProveedores.DataSource = lN.ListarProveedores(); //Cargar datos al DataGridView
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar el proveedor");
            }
        }
    }
}
