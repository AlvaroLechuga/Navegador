using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
	public partial class Navegador : Form
	{
		private string pgInicio = "";
		private string pgBusqueda = "";
		private WebBrowser wb = new WebBrowser();
		List<string> historial = new List<string>();
		List<string> favoritos = new List<string>();
		public Navegador()
		{
			InitializeComponent();
		}

		private void webBrowser1_Load(object sender, EventArgs e)
		{
			tabControl1.TabPages[0].Controls.Add(wb);
			wb.Dock = DockStyle.Fill;
			wb.Navigate(pgInicio);
			txtBusqueda.Text = pgInicio;

		}

		WebBrowser navegadorActivo()
		{
			WebBrowser web = new WebBrowser();
			web = (WebBrowser)tabControl1.SelectedTab.Controls[0];
			return web;
		}
		//Al pulsar el enter en la barra de direcciones navegamos a la página indicada
		private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)

				Navigate(txtBusqueda.Text);
		}

		private void Navigate(string direccion)
		{
			wb = navegadorActivo();
			if (String.IsNullOrEmpty(direccion)) return;
			if (direccion.Equals("about:blank")) return;
			if (!direccion.StartsWith("http://") &&
				!direccion.StartsWith("https://"))
			{
				direccion = "http://" + direccion;
			}
			try
			{
				wb.Navigate(new Uri(direccion));
				historial.Add(direccion);
				historialToolStripComboBox2.Items.Add(direccion);

			}
			catch (System.UriFormatException)
			{
				return;
			}
		}
		
		private void Atras_Click(object sender, EventArgs e)
		{
			wb = navegadorActivo();
			wb.GoBack();
		}

		private void Delante_Click(object sender, EventArgs e)
		{
			wb = navegadorActivo();
			wb.GoForward();
		}

		private void Recargar_Click(object sender, EventArgs e)
		{
			wb = navegadorActivo();
			wb.Refresh();
		}

		private void Home_Click(object sender, EventArgs e)
		{
			wb = navegadorActivo();
			if (pgInicio.Equals(""))
			{
				wb.GoHome();
			}
			else
			{
				wb.Navigate(pgInicio);
			}
			
			
		}

		private void Favoritos_Click(object sender, EventArgs e)
		{
			if (!favoritos.Contains(txtBusqueda.Text))
			{
				if (favoritos.Count < 10)
				{
					favoritos.Add(txtBusqueda.Text);
					favoritosToolStripComboBox1.Items.Add(txtBusqueda.Text);
				}
				else if (favoritos.Count >= 10)
				{
					favoritos.RemoveAt(0);
					favoritosToolStripComboBox1.Items.RemoveAt(0);
					favoritos.Add(txtBusqueda.Text);
					favoritosToolStripComboBox1.Items.Add(txtBusqueda.Text);
				}
			}
		}

		private void Nueva_Click(object sender, EventArgs e)
		{
			WebBrowser web = new WebBrowser();
			TabPage tb = new TabPage();
			tb.Controls.Add(web);
			web.Dock = DockStyle.Fill;
			tabControl1.TabPages.Add(tb);
		}


		private void configurarPrevToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wb.ShowPageSetupDialog();
		}

		private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wb.ShowPrintPreviewDialog();
		}

		private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wb.ShowPrintDialog();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void paginaDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pgInicio = Microsoft.VisualBasic.Interaction.InputBox("Establece Pagina de Inicio");
		}

		private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pgBusqueda = Microsoft.VisualBasic.Interaction.InputBox("Establece Pagina de Busqueda");
		}

		private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wb.ShowPropertiesDialog();
		}

		private void favoritosToolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(favoritos.Count != 0)
				{
					string web = favoritosToolStripComboBox1.SelectedItem.ToString();
					wb.Navigate(web);
					txtBusqueda.Text = web;
				}
				else
				{
					MessageBox.Show("No tienes nada agregado a favoritos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
			}

		}

		private void historialToolStripComboBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(historial.Count != 0)
				{
					string web = historialToolStripComboBox2.SelectedItem.ToString();
					wb.Navigate(web);
					txtBusqueda.Text = web;
				}
				else
				{
					MessageBox.Show("No tienes nada agregado a historial", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wb.ShowSaveAsDialog();
		}

		private void CloseWindow_Click(object sender, EventArgs e)
		{
			tabControl1.TabPages.Remove(tabControl1.SelectedTab);
		}

		private void Busqueda_Click(object sender, EventArgs e)
		{
			if (pgBusqueda.Equals(""))
			{
				busquedaToolStripMenuItem_Click(sender, e);
			}
			else
			{
				wb.Navigate(pgBusqueda);
			}
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
				tabControl1.TabPages[0].Text = wb.DocumentTitle;
		}
	}
}
