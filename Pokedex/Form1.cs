using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class frmInicial : Form
    {

        private List<Pokemon> listapokemon;

        public frmInicial()
        {
            InitializeComponent();
        }

        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.listar();
            dgvPokemons.DataSource = listapokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            cargarImagen(listapokemon[0].UrlImagen);

        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen); 
            }
            catch (Exception ex)
            {
                pbPokemon.Load("https://img.magnific.com/premium-vector/photo-icon-vector-flat-photo-icon_874723-130.jpg?semt=ais_test_b&w=740&q=80");
            }
            
        }
    }
}
