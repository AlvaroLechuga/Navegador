namespace Navegador
{
	partial class Navegador
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vistaPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurarPrevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.favoritosToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.historialToolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
			this.paginaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.Atras = new System.Windows.Forms.ToolStripButton();
			this.Delante = new System.Windows.Forms.ToolStripButton();
			this.Recargar = new System.Windows.Forms.ToolStripButton();
			this.Home = new System.Windows.Forms.ToolStripButton();
			this.Favoritos = new System.Windows.Forms.ToolStripButton();
			this.Nueva = new System.Windows.Forms.ToolStripButton();
			this.Direccion = new System.Windows.Forms.ToolStripLabel();
			this.txtBusqueda = new System.Windows.Forms.ToolStripTextBox();
			this.CloseWindow = new System.Windows.Forms.ToolStripButton();
			this.Busqueda = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 401);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleName = "";
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 398);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webBrowser1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 372);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 3);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(786, 366);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.propiedadesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarComoToolStripMenuItem,
            this.vistaPreviaToolStripMenuItem,
            this.configurarPrevToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.guardarComoToolStripMenuItem.Text = "Guardar Como";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
			// 
			// vistaPreviaToolStripMenuItem
			// 
			this.vistaPreviaToolStripMenuItem.Name = "vistaPreviaToolStripMenuItem";
			this.vistaPreviaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.vistaPreviaToolStripMenuItem.Text = "Vista Previa";
			this.vistaPreviaToolStripMenuItem.Click += new System.EventHandler(this.vistaPreviaToolStripMenuItem_Click);
			// 
			// configurarPrevToolStripMenuItem
			// 
			this.configurarPrevToolStripMenuItem.Name = "configurarPrevToolStripMenuItem";
			this.configurarPrevToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.configurarPrevToolStripMenuItem.Text = "Configurar Pagina";
			this.configurarPrevToolStripMenuItem.Click += new System.EventHandler(this.configurarPrevToolStripMenuItem_Click);
			// 
			// imprimirToolStripMenuItem
			// 
			this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
			this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.imprimirToolStripMenuItem.Text = "Imprimir";
			this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// configuracionToolStripMenuItem
			// 
			this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritosToolStripComboBox1,
            this.historialToolStripComboBox2,
            this.paginaDeInicioToolStripMenuItem,
            this.busquedaToolStripMenuItem});
			this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
			this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.configuracionToolStripMenuItem.Text = "Configuracion";
			// 
			// favoritosToolStripComboBox1
			// 
			this.favoritosToolStripComboBox1.Name = "favoritosToolStripComboBox1";
			this.favoritosToolStripComboBox1.Size = new System.Drawing.Size(121, 23);
			this.favoritosToolStripComboBox1.Text = "Marcadores";
			this.favoritosToolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.favoritosToolStripComboBox1_KeyDown);
			// 
			// historialToolStripComboBox2
			// 
			this.historialToolStripComboBox2.Name = "historialToolStripComboBox2";
			this.historialToolStripComboBox2.Size = new System.Drawing.Size(121, 23);
			this.historialToolStripComboBox2.Text = "Historial";
			this.historialToolStripComboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.historialToolStripComboBox2_KeyDown);
			// 
			// paginaDeInicioToolStripMenuItem
			// 
			this.paginaDeInicioToolStripMenuItem.Name = "paginaDeInicioToolStripMenuItem";
			this.paginaDeInicioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.paginaDeInicioToolStripMenuItem.Text = "Pagina de Inicio";
			this.paginaDeInicioToolStripMenuItem.Click += new System.EventHandler(this.paginaDeInicioToolStripMenuItem_Click);
			// 
			// busquedaToolStripMenuItem
			// 
			this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
			this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.busquedaToolStripMenuItem.Text = "Busqueda";
			this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
			// 
			// propiedadesToolStripMenuItem
			// 
			this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
			this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.propiedadesToolStripMenuItem.Text = "Propiedades";
			this.propiedadesToolStripMenuItem.Click += new System.EventHandler(this.propiedadesToolStripMenuItem_Click);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Delante,
            this.Recargar,
            this.Home,
            this.Favoritos,
            this.Nueva,
            this.Direccion,
            this.txtBusqueda,
            this.CloseWindow,
            this.Busqueda});
			this.toolStrip2.Location = new System.Drawing.Point(3, 24);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(655, 25);
			this.toolStrip2.TabIndex = 1;
			// 
			// Atras
			// 
			this.Atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
			this.Atras.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Atras.Name = "Atras";
			this.Atras.Size = new System.Drawing.Size(23, 22);
			this.Atras.Text = "Navegar hacia atras";
			this.Atras.Click += new System.EventHandler(this.Atras_Click);
			// 
			// Delante
			// 
			this.Delante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Delante.Image = ((System.Drawing.Image)(resources.GetObject("Delante.Image")));
			this.Delante.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Delante.Name = "Delante";
			this.Delante.Size = new System.Drawing.Size(23, 22);
			this.Delante.Text = "Navegar hacia delante";
			this.Delante.Click += new System.EventHandler(this.Delante_Click);
			// 
			// Recargar
			// 
			this.Recargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Recargar.Image = ((System.Drawing.Image)(resources.GetObject("Recargar.Image")));
			this.Recargar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Recargar.Name = "Recargar";
			this.Recargar.Size = new System.Drawing.Size(23, 22);
			this.Recargar.Text = "Refrescar";
			this.Recargar.Click += new System.EventHandler(this.Recargar_Click);
			// 
			// Home
			// 
			this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
			this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(23, 22);
			this.Home.Text = "Home";
			this.Home.Click += new System.EventHandler(this.Home_Click);
			// 
			// Favoritos
			// 
			this.Favoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Favoritos.Image = ((System.Drawing.Image)(resources.GetObject("Favoritos.Image")));
			this.Favoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Favoritos.Name = "Favoritos";
			this.Favoritos.Size = new System.Drawing.Size(23, 22);
			this.Favoritos.Text = "Favoritos";
			this.Favoritos.Click += new System.EventHandler(this.Favoritos_Click);
			// 
			// Nueva
			// 
			this.Nueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Nueva.Image = ((System.Drawing.Image)(resources.GetObject("Nueva.Image")));
			this.Nueva.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Nueva.Name = "Nueva";
			this.Nueva.Size = new System.Drawing.Size(23, 22);
			this.Nueva.Text = "Nueva Pestaña";
			this.Nueva.Click += new System.EventHandler(this.Nueva_Click);
			// 
			// Direccion
			// 
			this.Direccion.Name = "Direccion";
			this.Direccion.Size = new System.Drawing.Size(57, 22);
			this.Direccion.Text = "Direccion";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(400, 25);
			this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
			// 
			// CloseWindow
			// 
			this.CloseWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
			this.CloseWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CloseWindow.Name = "CloseWindow";
			this.CloseWindow.Size = new System.Drawing.Size(23, 22);
			this.CloseWindow.Text = "Cerrar Pestaña";
			this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
			// 
			// Busqueda
			// 
			this.Busqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Busqueda.Image = ((System.Drawing.Image)(resources.GetObject("Busqueda.Image")));
			this.Busqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Busqueda.Name = "Busqueda";
			this.Busqueda.Size = new System.Drawing.Size(23, 22);
			this.Busqueda.Text = "Pagina de Busqueda";
			this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
			// 
			// Navegador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Navegador";
			this.Text = "Navegador";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vistaPreviaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurarPrevToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paginaDeInicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton Atras;
		private System.Windows.Forms.ToolStripButton Delante;
		private System.Windows.Forms.ToolStripButton Recargar;
		private System.Windows.Forms.ToolStripButton Home;
		private System.Windows.Forms.ToolStripButton Favoritos;
		private System.Windows.Forms.ToolStripButton Nueva;
		private System.Windows.Forms.ToolStripLabel Direccion;
		private System.Windows.Forms.ToolStripTextBox txtBusqueda;
		private System.Windows.Forms.ToolStripComboBox favoritosToolStripComboBox1;
		private System.Windows.Forms.ToolStripComboBox historialToolStripComboBox2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStripButton CloseWindow;
		private System.Windows.Forms.ToolStripButton Busqueda;
	}
}

