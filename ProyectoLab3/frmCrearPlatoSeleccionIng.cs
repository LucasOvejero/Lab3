using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Modelo;
using Componentes;
namespace ProyectoLab3
{
    public partial class frmCrearPlatoSeleccionIng : Form
    {
        public frmCrearPlatoSeleccionIng()
        {
            InitializeComponent();
            ingredientesParaElPlato = new List<Ingrediente>();
        }
        public frmCrearPlatoSeleccionIng(List<Ingrediente> ingredientesParaElPlato, Plato plato) {
            InitializeComponent();
            this.ingredientesParaElPlato = ingredientesParaElPlato;
            this.plato = plato;
        
        }
        frmCrearPlatoConfirmar ofrmCrearPlatoConfirmar;
        List<Ingrediente> ingredientesParaElPlato, todosIngredientes;
        List<int> ingredientesSeleccionados = new List<int>();
        int x = 20, y = 0;
        int yvar = 80;
        Plato plato;
        private void frmCrearPlatoSeleccionIng_Load(object sender, EventArgs e)
        {
            setear();
           
        }

        private void setear()
        {

            cboCategoria.DataSource = categoriasObtenerNombre(clsIngrediente.obtenerCategoriasIngredientes());
            DataTable ingredientes = clsIngrediente.seleccionarIngredientes();
            todosIngredientes = ALista(ingredientes);
            if (this.ingredientesParaElPlato.Count == 0)
            {
                lbIngredientes.DataSource = todosIngredientes;
                lbIngredientes.DisplayMember = "NombreProducto";
            }
            else {
                foreach (Ingrediente i in ingredientesParaElPlato)
                {
                    int indice = todosIngredientes.FindIndex(ing => ing.IdIngrediente == i.IdIngrediente);
                    todosIngredientes.RemoveAt(indice);
                }
                asignarALosLb();
                agregarControles(ingredientesParaElPlato);
            
            }

        }
        private List<Ingrediente> ALista(DataTable dt)
        {

            var convertedList = (from rw in dt.AsEnumerable()
                                 select new Ingrediente()
                                 {
                                     IdIngrediente = Convert.ToInt32(rw["IdIngrediente"]),
                                     NombreProducto = Convert.ToString(rw["NombreProducto"]),
                                     CostoxKg = Convert.ToDouble(rw["CostoxKg"]),
                                     Categoria = Convert.ToString(rw["Nombre"])
                                 }).ToList();

            return convertedList;
        }
        //Esta función agrega "Todos" a la lista para el filtro de categorias
        private List<string> categoriasObtenerNombre(DataTable cat)
        {
            List<string> c = new List<string>();
            c.Insert(c.Count, "Todos");
            foreach (DataRow r in cat.Rows)
            {
                c.Insert(c.Count, r["Nombre"].ToString());
            }
            return c;
        }

        private void btnAgregarIngredientes_Click(object sender, EventArgs e)
        {
            cambiarDeLista(lbIngredientes, this.ingredientesParaElPlato, this.todosIngredientes, lbIngredientesDelPlato);
            agregarControles(ingredientesParaElPlato);
        }


        private void cambiarDeLista(ListBox lbAQuitar, List<Ingrediente> ListaAdd, List<Ingrediente> ListaDel, ListBox lbAAgregar)
        {
            int longitud = lbAQuitar.SelectedIndices.Count;
            for (int i = 0; i < longitud; i++)
            {
                Ingrediente ing = (Ingrediente)lbAQuitar.SelectedItems[i];
                ListaAdd.Add(ing);
                ListaDel.Remove(ing);
            }
           /* lbAAgregar.DataSource = null;
            lbAAgregar.DataSource = ListaAdd;
            lbAAgregar.DisplayMember = "NombreProducto";

            lbAQuitar.DataSource = null;
            lbAQuitar.DataSource = ListaDel;
            lbAQuitar.DisplayMember = "NombreProducto";*/
            asignarALosLb();
            lbAQuitar.ClearSelected();
            
        }

        private void btnQuitarIngredientes_Click(object sender, EventArgs e)
        {
            cambiarDeLista(lbIngredientesDelPlato, this.todosIngredientes, this.ingredientesParaElPlato, lbIngredientes);
            quitarControles();
            agregarControles(ingredientesParaElPlato);
        }

        private void agregarControles(List<Ingrediente> lista)
        {
            var controles = pnlIngredientes.Controls;
            foreach (Ingrediente i in lista)
            {
                bool exist = false;
                foreach (Control c in controles)
                {
                    if (c.GetType()==typeof(PanelPlato))
                    {
                        if (c.Tag.ToString() == i.IdIngrediente.ToString())
                            exist = true;
                    }
                }
                if (!exist){
                    if (i.Plato == null)
                    {
                        PanelPlato pnlPlato = new PanelPlato(i.NombreProducto);
                        pnlPlato.Location = new Point(x, y);
                        pnlPlato.Tag = i.IdIngrediente;
                        i.Plato = pnlPlato;
                    }
                    //tenemos que "reiniciar" la posición
                    else {
                        i.Plato.Location = new Point(x, y);
                    }
                    pnlIngredientes.Controls.Add(i.Plato);
                    y += yvar;
                    
                }
            }
        }
        private void quitarControles()
        {

           // Control.ControlCollection controles = pnlIngredientes.Controls;
            int lenght = pnlIngredientes.Controls.Count;
            for (int i = 0; i < lenght; i++) {
                pnlIngredientes.Controls.RemoveAt(0);
            }
            /*foreach (Control c in controles)
            {
                pnlIngredientes.Controls.Remove(c);
               /* bool noExist = false;
                Ingrediente r= null;
                foreach (Ingrediente i in lista)
                {
                    r = i;
                    if (c.GetType() == typeof(PanelPlato))
                    {
                        if (c.Tag.ToString() == i.IdIngrediente.ToString())
                            noExist = true;
                    }
                }
                if (!noExist && r!=null)
                {
                    int desde = pnlIngredientes.Controls.IndexOf(r.Plato);
                    pnlIngredientes.Controls.Remove(r.Plato);
                    //TODO: arreglar reordenarConstroles(desde, controles);
                }   
            }*/
            y = 0;

        }

        private void reordenarConstroles(int desde, Control.ControlCollection controles) {
            int cantControles = controles.Count;
            if (desde <= cantControles) {
                for (; desde < cantControles; desde++) {
                    Control c=controles[desde-1];
                    int yControl = c.Location.Y;
                    c.Location = new Point(c.Location.X,yControl - yvar);
                    y -= yvar;
                }
            }
        
        }
        private void asignarALosLb() {
            lbIngredientesDelPlato.DataSource = null;
            lbIngredientesDelPlato.DataSource = ingredientesParaElPlato;
            lbIngredientesDelPlato.DisplayMember = "NombreProducto";
            filtrarPorCBOCat();
        
        }

        private void filtrarPorCBOCat() {

            string cat = cboCategoria.SelectedValue.ToString();
            lbIngredientes.DataSource = null;
            lbIngredientes.Items.Clear();
            if (cat == "Todos")
            {
                lbIngredientes.DataSource = todosIngredientes;
                lbIngredientes.DisplayMember = "NombreProducto";
            }
            else
            {

                foreach (Ingrediente i in todosIngredientes)
                {
                    if (i.Categoria == cat)
                    {
                        lbIngredientes.Items.Add(i);
                    }
                }
                lbIngredientes.DisplayMember = "NombreProducto";
            }
        }
        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrarPorCBOCat();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ingredientesParaElPlato.Count > 0)
            {
                ofrmCrearPlatoConfirmar = new frmCrearPlatoConfirmar(ingredientesParaElPlato);
                DialogResult res=ofrmCrearPlatoConfirmar.ShowDialog();
                if (res == DialogResult.OK) {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Se necesitan ingredientes para guardar un plato, seleccione al menos 1 ingrediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
