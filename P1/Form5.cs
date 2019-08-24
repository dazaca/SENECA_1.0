using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using P1.Tools;

namespace P1
{
	/// <summary>
	/// Descripción breve de Form5.
	/// </summary>
	public class Form5 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.TabControl tabInformes;
		private System.Windows.Forms.TabPage tbpR_DEPART;
		private System.Windows.Forms.TabPage tbpR_ETCP;
		private System.Windows.Forms.TabPage tbpActasConvocatorias;
		private System.Windows.Forms.GroupBox gbACCESO_INFO;
		private System.Windows.Forms.Button btProceder;
		private System.Windows.Forms.RadioButton rbEliminaDocumento;
		private System.Windows.Forms.RadioButton rbAccesoDocumento;
		private System.Windows.Forms.RadioButton rbModificar;
		private System.Windows.Forms.GroupBox gbFiltrado;
		private System.Windows.Forms.CheckBox cbConvocatorias;
		private System.Windows.Forms.CheckBox cbActas;
		private System.Windows.Forms.Button btFiltrado;
		private System.Windows.Forms.RadioButton rbNombre;
		private System.Windows.Forms.Label lbFiltrado;
		private System.Windows.Forms.RadioButton rbFecha;
		private System.Windows.Forms.RadioButton rbN_SESION;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btBusquedaXfecha;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TabPage tbpEdicionActas;
		private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.ComboBox cbAcciones;
		private System.Windows.Forms.Button btProceder2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.TextBox tbNombre;
		public System.Windows.Forms.ComboBox cbMinutos;
		public System.Windows.Forms.ComboBox cbHora;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.DateTimePicker dateTimePicker2;
		public System.Windows.Forms.TextBox tbLugar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabCamposActas;
		private System.Windows.Forms.TabPage tbpModif_Observ_Anterior;
		public System.Windows.Forms.TextBox tbActasAnteriores;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tbpOrdenes;
		public System.Windows.Forms.TextBox tbOrdenesDia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tbpRuegosPreguntas;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox tbRuegosyPreguntas;
		private System.Windows.Forms.TabControl tabACTAS_CONVOCATORIAS;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.RadioButton rbAct;
		private System.Windows.Forms.RadioButton rbConv;
		private System.Windows.Forms.TabPage tbpvisor;
		private System.Windows.Forms.Label lbConfirmaIngreso;
		private System.Windows.Forms.Button btCANCEL;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.GroupBox btConfirmacion2;
		private System.Windows.Forms.Button btListadoCompleto;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.TabControl tabVisorDocumentos;
		private System.Windows.Forms.TabPage tbpConvocatorias;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lbContenidoConv;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbEncabezadoConv;
		private System.Windows.Forms.TabPage tbpActas;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label lbModif_observ_Actas;
		private System.Windows.Forms.Label lbOrdenesdia_Actas;
		private System.Windows.Forms.Label lbRuegosPreguntas_Actas;
		private System.Windows.Forms.Label lbFecha_Conv;
		private System.Windows.Forms.Label lbFecha_Acta;
		private System.Windows.Forms.Label lbNum_Sesion_Conv;
		private System.Windows.Forms.Label lbLugar_Conv;
		private System.Windows.Forms.Label lbFecha_Convocatoria;
		private System.Windows.Forms.Label lbHora_Conv;
		private System.Windows.Forms.Label lbLugar_Convocatoria;
		private System.Windows.Forms.Label lbNum_Sesion_Act;
		private System.Windows.Forms.Label lbHora_Act;
		private System.Windows.Forms.Label lbFecha_Act;
		private System.Windows.Forms.Label lbLugar_Act;
		private System.Windows.Forms.Label lbEncabezadoActa;
		private System.Windows.Forms.TabPage tabPage1;
		P1.Tools.funciones funcion = new  funciones();

		public Form5()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.tabInformes = new System.Windows.Forms.TabControl();
			this.tbpR_DEPART = new System.Windows.Forms.TabPage();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.tabACTAS_CONVOCATORIAS = new System.Windows.Forms.TabControl();
			this.tbpActasConvocatorias = new System.Windows.Forms.TabPage();
			this.gbACCESO_INFO = new System.Windows.Forms.GroupBox();
			this.btProceder = new System.Windows.Forms.Button();
			this.rbEliminaDocumento = new System.Windows.Forms.RadioButton();
			this.rbAccesoDocumento = new System.Windows.Forms.RadioButton();
			this.rbModificar = new System.Windows.Forms.RadioButton();
			this.gbFiltrado = new System.Windows.Forms.GroupBox();
			this.btListadoCompleto = new System.Windows.Forms.Button();
			this.cbConvocatorias = new System.Windows.Forms.CheckBox();
			this.cbActas = new System.Windows.Forms.CheckBox();
			this.btFiltrado = new System.Windows.Forms.Button();
			this.rbNombre = new System.Windows.Forms.RadioButton();
			this.lbFiltrado = new System.Windows.Forms.Label();
			this.rbFecha = new System.Windows.Forms.RadioButton();
			this.rbN_SESION = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btBusquedaXfecha = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tbpEdicionActas = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbAcciones = new System.Windows.Forms.ComboBox();
			this.btProceder2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.cbMinutos = new System.Windows.Forms.ComboBox();
			this.cbHora = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.tbLugar = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbConv = new System.Windows.Forms.RadioButton();
			this.rbAct = new System.Windows.Forms.RadioButton();
			this.tabCamposActas = new System.Windows.Forms.TabControl();
			this.tbpModif_Observ_Anterior = new System.Windows.Forms.TabPage();
			this.tbActasAnteriores = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbpOrdenes = new System.Windows.Forms.TabPage();
			this.tbOrdenesDia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbpRuegosPreguntas = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.tbRuegosyPreguntas = new System.Windows.Forms.TextBox();
			this.tbpvisor = new System.Windows.Forms.TabPage();
			this.tabVisorDocumentos = new System.Windows.Forms.TabControl();
			this.tbpConvocatorias = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.lbFecha_Conv = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lbContenidoConv = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lbLugar_Convocatoria = new System.Windows.Forms.Label();
			this.lbHora_Conv = new System.Windows.Forms.Label();
			this.lbFecha_Convocatoria = new System.Windows.Forms.Label();
			this.lbLugar_Conv = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbNum_Sesion_Conv = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lbEncabezadoConv = new System.Windows.Forms.Label();
			this.tbpActas = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lbRuegosPreguntas_Actas = new System.Windows.Forms.Label();
			this.lbOrdenesdia_Actas = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.lbFecha_Acta = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lbModif_observ_Actas = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.lbLugar_Act = new System.Windows.Forms.Label();
			this.lbFecha_Act = new System.Windows.Forms.Label();
			this.lbHora_Act = new System.Windows.Forms.Label();
			this.lbNum_Sesion_Act = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.lbEncabezadoActa = new System.Windows.Forms.Label();
			this.tbpR_ETCP = new System.Windows.Forms.TabPage();
			this.btConfirmacion2 = new System.Windows.Forms.GroupBox();
			this.lbConfirmaIngreso = new System.Windows.Forms.Label();
			this.btCANCEL = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabInformes.SuspendLayout();
			this.tbpR_DEPART.SuspendLayout();
			this.tabACTAS_CONVOCATORIAS.SuspendLayout();
			this.tbpActasConvocatorias.SuspendLayout();
			this.gbACCESO_INFO.SuspendLayout();
			this.gbFiltrado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tbpEdicionActas.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabCamposActas.SuspendLayout();
			this.tbpModif_Observ_Anterior.SuspendLayout();
			this.tbpOrdenes.SuspendLayout();
			this.tbpRuegosPreguntas.SuspendLayout();
			this.tbpvisor.SuspendLayout();
			this.tabVisorDocumentos.SuspendLayout();
			this.tbpConvocatorias.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tbpActas.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.btConfirmacion2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MdiList = true;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuItem1.Text = "Menú";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MergeOrder = 11;
			this.menuItem2.Text = "3---------";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MergeOrder = 18;
			this.menuItem3.Text = "Cerrar ";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// tabInformes
			// 
			this.tabInformes.Controls.Add(this.tbpR_DEPART);
			this.tabInformes.Controls.Add(this.tbpR_ETCP);
			this.tabInformes.Controls.Add(this.tabPage1);
			this.tabInformes.Dock = System.Windows.Forms.DockStyle.Right;
			this.tabInformes.ItemSize = new System.Drawing.Size(119, 18);
			this.tabInformes.Location = new System.Drawing.Point(114, 0);
			this.tabInformes.Name = "tabInformes";
			this.tabInformes.SelectedIndex = 0;
			this.tabInformes.Size = new System.Drawing.Size(800, 605);
			this.tabInformes.TabIndex = 0;
			// 
			// tbpR_DEPART
			// 
			this.tbpR_DEPART.Controls.Add(this.dateTimePicker3);
			this.tbpR_DEPART.Controls.Add(this.tabACTAS_CONVOCATORIAS);
			this.tbpR_DEPART.Location = new System.Drawing.Point(4, 22);
			this.tbpR_DEPART.Name = "tbpR_DEPART";
			this.tbpR_DEPART.Size = new System.Drawing.Size(792, 579);
			this.tbpR_DEPART.TabIndex = 0;
			this.tbpR_DEPART.Text = "Reuniones del Departamento";
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Enabled = false;
			this.dateTimePicker3.Location = new System.Drawing.Point(296, 544);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.TabIndex = 1;
			this.dateTimePicker3.Visible = false;
			// 
			// tabACTAS_CONVOCATORIAS
			// 
			this.tabACTAS_CONVOCATORIAS.Controls.Add(this.tbpActasConvocatorias);
			this.tabACTAS_CONVOCATORIAS.Controls.Add(this.tbpEdicionActas);
			this.tabACTAS_CONVOCATORIAS.Controls.Add(this.tbpvisor);
			this.tabACTAS_CONVOCATORIAS.ItemSize = new System.Drawing.Size(155, 18);
			this.tabACTAS_CONVOCATORIAS.Location = new System.Drawing.Point(16, 16);
			this.tabACTAS_CONVOCATORIAS.Name = "tabACTAS_CONVOCATORIAS";
			this.tabACTAS_CONVOCATORIAS.SelectedIndex = 0;
			this.tabACTAS_CONVOCATORIAS.Size = new System.Drawing.Size(760, 512);
			this.tabACTAS_CONVOCATORIAS.TabIndex = 0;
			// 
			// tbpActasConvocatorias
			// 
			this.tbpActasConvocatorias.Controls.Add(this.gbACCESO_INFO);
			this.tbpActasConvocatorias.Controls.Add(this.gbFiltrado);
			this.tbpActasConvocatorias.Controls.Add(this.dataGrid1);
			this.tbpActasConvocatorias.Location = new System.Drawing.Point(4, 22);
			this.tbpActasConvocatorias.Name = "tbpActasConvocatorias";
			this.tbpActasConvocatorias.Size = new System.Drawing.Size(752, 486);
			this.tbpActasConvocatorias.TabIndex = 0;
			this.tbpActasConvocatorias.Text = "Listado Actas / Convocatorias";
			// 
			// gbACCESO_INFO
			// 
			this.gbACCESO_INFO.Controls.Add(this.btProceder);
			this.gbACCESO_INFO.Controls.Add(this.rbEliminaDocumento);
			this.gbACCESO_INFO.Controls.Add(this.rbAccesoDocumento);
			this.gbACCESO_INFO.Controls.Add(this.rbModificar);
			this.gbACCESO_INFO.Location = new System.Drawing.Point(376, 304);
			this.gbACCESO_INFO.Name = "gbACCESO_INFO";
			this.gbACCESO_INFO.Size = new System.Drawing.Size(344, 152);
			this.gbACCESO_INFO.TabIndex = 5;
			this.gbACCESO_INFO.TabStop = false;
			this.gbACCESO_INFO.Text = "Acceso, Modificación y Eliminación de Documentos";
			// 
			// btProceder
			// 
			this.btProceder.Location = new System.Drawing.Point(216, 48);
			this.btProceder.Name = "btProceder";
			this.btProceder.Size = new System.Drawing.Size(75, 72);
			this.btProceder.TabIndex = 12;
			this.btProceder.Text = "Proceder";
			this.btProceder.Click += new System.EventHandler(this.btProceder_Click);
			// 
			// rbEliminaDocumento
			// 
			this.rbEliminaDocumento.Location = new System.Drawing.Point(40, 112);
			this.rbEliminaDocumento.Name = "rbEliminaDocumento";
			this.rbEliminaDocumento.Size = new System.Drawing.Size(128, 16);
			this.rbEliminaDocumento.TabIndex = 11;
			this.rbEliminaDocumento.Text = "Eliminar Documento";
			// 
			// rbAccesoDocumento
			// 
			this.rbAccesoDocumento.Location = new System.Drawing.Point(40, 72);
			this.rbAccesoDocumento.Name = "rbAccesoDocumento";
			this.rbAccesoDocumento.Size = new System.Drawing.Size(136, 16);
			this.rbAccesoDocumento.TabIndex = 10;
			this.rbAccesoDocumento.Text = "Acceso al Documento";
			// 
			// rbModificar
			// 
			this.rbModificar.Location = new System.Drawing.Point(40, 32);
			this.rbModificar.Name = "rbModificar";
			this.rbModificar.Size = new System.Drawing.Size(144, 16);
			this.rbModificar.TabIndex = 9;
			this.rbModificar.Text = "Modificar Seleccionado";
			// 
			// gbFiltrado
			// 
			this.gbFiltrado.Controls.Add(this.btListadoCompleto);
			this.gbFiltrado.Controls.Add(this.cbConvocatorias);
			this.gbFiltrado.Controls.Add(this.cbActas);
			this.gbFiltrado.Controls.Add(this.btFiltrado);
			this.gbFiltrado.Controls.Add(this.rbNombre);
			this.gbFiltrado.Controls.Add(this.lbFiltrado);
			this.gbFiltrado.Controls.Add(this.rbFecha);
			this.gbFiltrado.Controls.Add(this.rbN_SESION);
			this.gbFiltrado.Controls.Add(this.dateTimePicker1);
			this.gbFiltrado.Controls.Add(this.btBusquedaXfecha);
			this.gbFiltrado.Location = new System.Drawing.Point(376, 24);
			this.gbFiltrado.Name = "gbFiltrado";
			this.gbFiltrado.Size = new System.Drawing.Size(344, 256);
			this.gbFiltrado.TabIndex = 4;
			this.gbFiltrado.TabStop = false;
			this.gbFiltrado.Text = "Búsqueda y Filtrado de Documentos";
			// 
			// btListadoCompleto
			// 
			this.btListadoCompleto.Location = new System.Drawing.Point(200, 64);
			this.btListadoCompleto.Name = "btListadoCompleto";
			this.btListadoCompleto.Size = new System.Drawing.Size(120, 23);
			this.btListadoCompleto.TabIndex = 4;
			this.btListadoCompleto.Text = "Listado Completo";
			this.btListadoCompleto.Visible = false;
			this.btListadoCompleto.Click += new System.EventHandler(this.btListadoCompleto_Click);
			// 
			// cbConvocatorias
			// 
			this.cbConvocatorias.Location = new System.Drawing.Point(24, 64);
			this.cbConvocatorias.Name = "cbConvocatorias";
			this.cbConvocatorias.TabIndex = 2;
			this.cbConvocatorias.Text = "Convocatorias";
			// 
			// cbActas
			// 
			this.cbActas.Location = new System.Drawing.Point(24, 32);
			this.cbActas.Name = "cbActas";
			this.cbActas.Size = new System.Drawing.Size(64, 24);
			this.cbActas.TabIndex = 1;
			this.cbActas.Text = "Actas";
			// 
			// btFiltrado
			// 
			this.btFiltrado.Location = new System.Drawing.Point(216, 144);
			this.btFiltrado.Name = "btFiltrado";
			this.btFiltrado.Size = new System.Drawing.Size(75, 72);
			this.btFiltrado.TabIndex = 8;
			this.btFiltrado.Text = "Filtrar";
			this.btFiltrado.Click += new System.EventHandler(this.btFiltrado_Click);
			// 
			// rbNombre
			// 
			this.rbNombre.Location = new System.Drawing.Point(40, 200);
			this.rbNombre.Name = "rbNombre";
			this.rbNombre.Size = new System.Drawing.Size(104, 16);
			this.rbNombre.TabIndex = 7;
			this.rbNombre.Text = "Nombre";
			// 
			// lbFiltrado
			// 
			this.lbFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbFiltrado.Location = new System.Drawing.Point(16, 112);
			this.lbFiltrado.Name = "lbFiltrado";
			this.lbFiltrado.Size = new System.Drawing.Size(312, 23);
			this.lbFiltrado.TabIndex = 6;
			this.lbFiltrado.Text = "Campos de filtrado______________________________";
			// 
			// rbFecha
			// 
			this.rbFecha.Location = new System.Drawing.Point(40, 176);
			this.rbFecha.Name = "rbFecha";
			this.rbFecha.Size = new System.Drawing.Size(104, 16);
			this.rbFecha.TabIndex = 6;
			this.rbFecha.Text = "Fecha";
			// 
			// rbN_SESION
			// 
			this.rbN_SESION.Location = new System.Drawing.Point(40, 152);
			this.rbN_SESION.Name = "rbN_SESION";
			this.rbN_SESION.Size = new System.Drawing.Size(104, 16);
			this.rbN_SESION.TabIndex = 5;
			this.rbN_SESION.Text = "Nº Sesión";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(120, 32);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.Value = new System.DateTime(2007, 6, 30, 15, 42, 7, 750);
			// 
			// btBusquedaXfecha
			// 
			this.btBusquedaXfecha.Location = new System.Drawing.Point(200, 64);
			this.btBusquedaXfecha.Name = "btBusquedaXfecha";
			this.btBusquedaXfecha.Size = new System.Drawing.Size(120, 23);
			this.btBusquedaXfecha.TabIndex = 3;
			this.btBusquedaXfecha.Text = "Búsqueda por fecha";
			this.btBusquedaXfecha.Click += new System.EventHandler(this.btBusquedaXfecha_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "Listado de Actas y Convocatorias";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 72;
			this.dataGrid1.Size = new System.Drawing.Size(328, 440);
			this.dataGrid1.TabIndex = 1;
			// 
			// tbpEdicionActas
			// 
			this.tbpEdicionActas.Controls.Add(this.groupBox3);
			this.tbpEdicionActas.Controls.Add(this.groupBox2);
			this.tbpEdicionActas.Controls.Add(this.groupBox1);
			this.tbpEdicionActas.Location = new System.Drawing.Point(4, 22);
			this.tbpEdicionActas.Name = "tbpEdicionActas";
			this.tbpEdicionActas.Size = new System.Drawing.Size(752, 486);
			this.tbpEdicionActas.TabIndex = 2;
			this.tbpEdicionActas.Text = "Edición de Actas / Convocatorias";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbAcciones);
			this.groupBox3.Controls.Add(this.btProceder2);
			this.groupBox3.Location = new System.Drawing.Point(544, 328);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 128);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Acciones";
			// 
			// cbAcciones
			// 
			this.cbAcciones.ItemHeight = 13;
			this.cbAcciones.Items.AddRange(new object[] {
															"-Borrar todos los campos",
															"-Generar Acta/Convocatoria",
															"-Actualizar Acta/Convocatoria"});
			this.cbAcciones.Location = new System.Drawing.Point(8, 32);
			this.cbAcciones.Name = "cbAcciones";
			this.cbAcciones.Size = new System.Drawing.Size(168, 21);
			this.cbAcciones.TabIndex = 12;
			this.cbAcciones.Text = "Selecciar Acción";
			// 
			// btProceder2
			// 
			this.btProceder2.Location = new System.Drawing.Point(24, 72);
			this.btProceder2.Name = "btProceder2";
			this.btProceder2.Size = new System.Drawing.Size(136, 24);
			this.btProceder2.TabIndex = 13;
			this.btProceder2.Text = "Proceder";
			this.btProceder2.Click += new System.EventHandler(this.btProceder2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.tbNombre);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Controls.Add(this.cbMinutos);
			this.groupBox2.Controls.Add(this.cbHora);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.tbLugar);
			this.groupBox2.Location = new System.Drawing.Point(32, 328);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 128);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos de interés";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 16);
			this.label8.TabIndex = 11;
			this.label8.Text = "Nombre / Motivo de la Reunión___";
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(16, 40);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(232, 20);
			this.tbNombre.TabIndex = 6;
			this.tbNombre.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(408, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 9;
			this.label7.Text = "Nº Sesión";
			// 
			// listBox1
			// 
			this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listBox1.Items.AddRange(new object[] {
														  "1",
														  "2",
														  "3",
														  "4",
														  "5",
														  "6",
														  "7",
														  "8",
														  "9",
														  "10",
														  "11",
														  "12",
														  "13",
														  "14",
														  "15",
														  "16",
														  "17",
														  "18",
														  "19",
														  "20",
														  "21",
														  "22",
														  "23",
														  "24",
														  "25",
														  "26",
														  "27",
														  "28",
														  "29",
														  "30"});
			this.listBox1.Location = new System.Drawing.Point(408, 88);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(56, 17);
			this.listBox1.TabIndex = 11;
			// 
			// cbMinutos
			// 
			this.cbMinutos.ItemHeight = 13;
			this.cbMinutos.Items.AddRange(new object[] {
														   ":00",
														   ":05",
														   ":10",
														   ":15",
														   ":20",
														   ":25",
														   ":30",
														   ":35",
														   ":40",
														   ":45",
														   ":50",
														   ":55"});
			this.cbMinutos.Location = new System.Drawing.Point(336, 88);
			this.cbMinutos.Name = "cbMinutos";
			this.cbMinutos.Size = new System.Drawing.Size(56, 21);
			this.cbMinutos.TabIndex = 10;
			this.cbMinutos.Text = "Min";
			// 
			// cbHora
			// 
			this.cbHora.ItemHeight = 13;
			this.cbHora.Items.AddRange(new object[] {
														"08",
														"09",
														"10",
														"11",
														"12",
														"13",
														"14",
														"15",
														"16",
														"17",
														"18",
														"19",
														"20",
														"21",
														"22"});
			this.cbHora.Location = new System.Drawing.Point(272, 88);
			this.cbHora.Name = "cbHora";
			this.cbHora.Size = new System.Drawing.Size(56, 21);
			this.cbHora.TabIndex = 9;
			this.cbHora.Text = "Hora";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Lugar de la Reunión___";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(272, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Hora de la Reunión__";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(272, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de la Reunión_____________";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(272, 40);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.TabIndex = 8;
			this.dateTimePicker2.Value = new System.DateTime(2007, 6, 30, 15, 42, 7, 906);
			// 
			// tbLugar
			// 
			this.tbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbLugar.Location = new System.Drawing.Point(16, 88);
			this.tbLugar.Name = "tbLugar";
			this.tbLugar.Size = new System.Drawing.Size(232, 20);
			this.tbLugar.TabIndex = 7;
			this.tbLugar.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbConv);
			this.groupBox1.Controls.Add(this.rbAct);
			this.groupBox1.Controls.Add(this.tabCamposActas);
			this.groupBox1.Location = new System.Drawing.Point(32, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 288);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contenidos Editables de la Memoria del Acta";
			// 
			// rbConv
			// 
			this.rbConv.Location = new System.Drawing.Point(584, 16);
			this.rbConv.Name = "rbConv";
			this.rbConv.Size = new System.Drawing.Size(96, 24);
			this.rbConv.TabIndex = 2;
			this.rbConv.Text = "Convocatoria";
			// 
			// rbAct
			// 
			this.rbAct.Checked = true;
			this.rbAct.Location = new System.Drawing.Point(520, 16);
			this.rbAct.Name = "rbAct";
			this.rbAct.Size = new System.Drawing.Size(48, 24);
			this.rbAct.TabIndex = 1;
			this.rbAct.TabStop = true;
			this.rbAct.Text = "Acta";
			this.rbAct.CheckedChanged += new System.EventHandler(this.rbAct_CheckedChanged);
			// 
			// tabCamposActas
			// 
			this.tabCamposActas.Controls.Add(this.tbpModif_Observ_Anterior);
			this.tabCamposActas.Controls.Add(this.tbpOrdenes);
			this.tabCamposActas.Controls.Add(this.tbpRuegosPreguntas);
			this.tabCamposActas.ItemSize = new System.Drawing.Size(92, 18);
			this.tabCamposActas.Location = new System.Drawing.Point(20, 32);
			this.tabCamposActas.Name = "tabCamposActas";
			this.tabCamposActas.SelectedIndex = 0;
			this.tabCamposActas.Size = new System.Drawing.Size(656, 240);
			this.tabCamposActas.TabIndex = 0;
			// 
			// tbpModif_Observ_Anterior
			// 
			this.tbpModif_Observ_Anterior.Controls.Add(this.tbActasAnteriores);
			this.tbpModif_Observ_Anterior.Controls.Add(this.label1);
			this.tbpModif_Observ_Anterior.Location = new System.Drawing.Point(4, 22);
			this.tbpModif_Observ_Anterior.Name = "tbpModif_Observ_Anterior";
			this.tbpModif_Observ_Anterior.Size = new System.Drawing.Size(648, 214);
			this.tbpModif_Observ_Anterior.TabIndex = 0;
			this.tbpModif_Observ_Anterior.Text = "Actas  Anteriores";
			// 
			// tbActasAnteriores
			// 
			this.tbActasAnteriores.Location = new System.Drawing.Point(24, 40);
			this.tbActasAnteriores.Multiline = true;
			this.tbActasAnteriores.Name = "tbActasAnteriores";
			this.tbActasAnteriores.Size = new System.Drawing.Size(600, 152);
			this.tbActasAnteriores.TabIndex = 3;
			this.tbActasAnteriores.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Escriba aquí las Modificaciones  u Observaciones  de reuniones anteriores :";
			// 
			// tbpOrdenes
			// 
			this.tbpOrdenes.Controls.Add(this.tbOrdenesDia);
			this.tbpOrdenes.Controls.Add(this.label2);
			this.tbpOrdenes.Location = new System.Drawing.Point(4, 22);
			this.tbpOrdenes.Name = "tbpOrdenes";
			this.tbpOrdenes.Size = new System.Drawing.Size(648, 214);
			this.tbpOrdenes.TabIndex = 1;
			this.tbpOrdenes.Text = "Órden(es) del día";
			// 
			// tbOrdenesDia
			// 
			this.tbOrdenesDia.Location = new System.Drawing.Point(24, 40);
			this.tbOrdenesDia.Multiline = true;
			this.tbOrdenesDia.Name = "tbOrdenesDia";
			this.tbOrdenesDia.Size = new System.Drawing.Size(600, 152);
			this.tbOrdenesDia.TabIndex = 4;
			this.tbOrdenesDia.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(416, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Escriba aquí los aspectos tratados o a tratar en la reunión:";
			// 
			// tbpRuegosPreguntas
			// 
			this.tbpRuegosPreguntas.Controls.Add(this.label3);
			this.tbpRuegosPreguntas.Controls.Add(this.tbRuegosyPreguntas);
			this.tbpRuegosPreguntas.Location = new System.Drawing.Point(4, 22);
			this.tbpRuegosPreguntas.Name = "tbpRuegosPreguntas";
			this.tbpRuegosPreguntas.Size = new System.Drawing.Size(648, 214);
			this.tbpRuegosPreguntas.TabIndex = 2;
			this.tbpRuegosPreguntas.Text = "Ruegos y Preguntas";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(352, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ingrese aquí los Ruegos y Preguntas expuestos en la reunión :";
			// 
			// tbRuegosyPreguntas
			// 
			this.tbRuegosyPreguntas.Location = new System.Drawing.Point(24, 40);
			this.tbRuegosyPreguntas.Multiline = true;
			this.tbRuegosyPreguntas.Name = "tbRuegosyPreguntas";
			this.tbRuegosyPreguntas.Size = new System.Drawing.Size(600, 152);
			this.tbRuegosyPreguntas.TabIndex = 5;
			this.tbRuegosyPreguntas.Text = "";
			// 
			// tbpvisor
			// 
			this.tbpvisor.Controls.Add(this.tabVisorDocumentos);
			this.tbpvisor.Location = new System.Drawing.Point(4, 22);
			this.tbpvisor.Name = "tbpvisor";
			this.tbpvisor.Size = new System.Drawing.Size(752, 486);
			this.tbpvisor.TabIndex = 3;
			this.tbpvisor.Text = "Visor de Documentos";
			// 
			// tabVisorDocumentos
			// 
			this.tabVisorDocumentos.Controls.Add(this.tbpConvocatorias);
			this.tabVisorDocumentos.Controls.Add(this.tbpActas);
			this.tabVisorDocumentos.Location = new System.Drawing.Point(8, 8);
			this.tabVisorDocumentos.Name = "tabVisorDocumentos";
			this.tabVisorDocumentos.SelectedIndex = 0;
			this.tabVisorDocumentos.Size = new System.Drawing.Size(736, 472);
			this.tabVisorDocumentos.TabIndex = 0;
			// 
			// tbpConvocatorias
			// 
			this.tbpConvocatorias.Controls.Add(this.groupBox6);
			this.tbpConvocatorias.Controls.Add(this.groupBox5);
			this.tbpConvocatorias.Controls.Add(this.groupBox4);
			this.tbpConvocatorias.Location = new System.Drawing.Point(4, 22);
			this.tbpConvocatorias.Name = "tbpConvocatorias";
			this.tbpConvocatorias.Size = new System.Drawing.Size(728, 446);
			this.tbpConvocatorias.TabIndex = 0;
			this.tbpConvocatorias.Text = "Convocatorias";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label20);
			this.groupBox6.Controls.Add(this.lbFecha_Conv);
			this.groupBox6.Controls.Add(this.label18);
			this.groupBox6.Controls.Add(this.label17);
			this.groupBox6.Controls.Add(this.lbContenidoConv);
			this.groupBox6.Controls.Add(this.label16);
			this.groupBox6.Controls.Add(this.label15);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Controls.Add(this.label13);
			this.groupBox6.Location = new System.Drawing.Point(8, 104);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(712, 336);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(512, 296);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(128, 16);
			this.label20.TabIndex = 8;
			this.label20.Text = " El Jefe de Departamento.";
			// 
			// lbFecha_Conv
			// 
			this.lbFecha_Conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbFecha_Conv.Location = new System.Drawing.Point(488, 272);
			this.lbFecha_Conv.Name = "lbFecha_Conv";
			this.lbFecha_Conv.Size = new System.Drawing.Size(80, 16);
			this.lbFecha_Conv.TabIndex = 7;
			this.lbFecha_Conv.Text = "dd/mm/aaaa";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(408, 272);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 16);
			this.label18.TabIndex = 6;
			this.label18.Text = " En Granada a";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(32, 240);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(648, 16);
			this.label17.TabIndex = 5;
			this.label17.Text = ".- Ruegos y preguntas";
			// 
			// lbContenidoConv
			// 
			this.lbContenidoConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbContenidoConv.Location = new System.Drawing.Point(32, 112);
			this.lbContenidoConv.Name = "lbContenidoConv";
			this.lbContenidoConv.Size = new System.Drawing.Size(648, 120);
			this.lbContenidoConv.TabIndex = 4;
			this.lbContenidoConv.Text = "................................................................................." +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"...........................................................................";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(32, 88);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(648, 16);
			this.label16.TabIndex = 3;
			this.label16.Text = "1.- Lectura y aprobación si procede del acta de la sesión anterior.";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(32, 48);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(648, 24);
			this.label15.TabIndex = 2;
			this.label15.Text = "   De conformidad con la normativa vigente y con el Plan Anual de Centro se le co" +
				"nvoca a usted a la reunión de Departamento, que se celebrará en el lugar, fecha " +
				"y hora arriba indicados, y de acuerdo al siguiente Orden del Día:";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(80, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(272, 16);
			this.label14.TabIndex = 1;
			this.label14.Text = "Nombre del Profesor de Departamento";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(32, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "D.Dª. ";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lbLugar_Convocatoria);
			this.groupBox5.Controls.Add(this.lbHora_Conv);
			this.groupBox5.Controls.Add(this.lbFecha_Convocatoria);
			this.groupBox5.Controls.Add(this.lbLugar_Conv);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.lbNum_Sesion_Conv);
			this.groupBox5.Location = new System.Drawing.Point(8, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(712, 48);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			// 
			// lbLugar_Convocatoria
			// 
			this.lbLugar_Convocatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbLugar_Convocatoria.Location = new System.Drawing.Point(496, 18);
			this.lbLugar_Convocatoria.Name = "lbLugar_Convocatoria";
			this.lbLugar_Convocatoria.Size = new System.Drawing.Size(192, 16);
			this.lbLugar_Convocatoria.TabIndex = 31;
			// 
			// lbHora_Conv
			// 
			this.lbHora_Conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbHora_Conv.Location = new System.Drawing.Point(216, 18);
			this.lbHora_Conv.Name = "lbHora_Conv";
			this.lbHora_Conv.Size = new System.Drawing.Size(32, 16);
			this.lbHora_Conv.TabIndex = 30;
			// 
			// lbFecha_Convocatoria
			// 
			this.lbFecha_Convocatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbFecha_Convocatoria.Location = new System.Drawing.Point(336, 18);
			this.lbFecha_Convocatoria.Name = "lbFecha_Convocatoria";
			this.lbFecha_Convocatoria.Size = new System.Drawing.Size(72, 16);
			this.lbFecha_Convocatoria.TabIndex = 29;
			// 
			// lbLugar_Conv
			// 
			this.lbLugar_Conv.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbLugar_Conv.Location = new System.Drawing.Point(432, 16);
			this.lbLugar_Conv.Name = "lbLugar_Conv";
			this.lbLugar_Conv.Size = new System.Drawing.Size(72, 24);
			this.lbLugar_Conv.TabIndex = 5;
			this.lbLugar_Conv.Text = "Lugar : ";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 24);
			this.label9.TabIndex = 1;
			this.label9.Text = "Sesión Nº: ";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(160, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 24);
			this.label10.TabIndex = 4;
			this.label10.Text = "Hora : ";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(272, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 24);
			this.label11.TabIndex = 4;
			this.label11.Text = "Fecha : ";
			// 
			// lbNum_Sesion_Conv
			// 
			this.lbNum_Sesion_Conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbNum_Sesion_Conv.Location = new System.Drawing.Point(104, 18);
			this.lbNum_Sesion_Conv.Name = "lbNum_Sesion_Conv";
			this.lbNum_Sesion_Conv.Size = new System.Drawing.Size(24, 16);
			this.lbNum_Sesion_Conv.TabIndex = 28;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lbEncabezadoConv);
			this.groupBox4.Location = new System.Drawing.Point(8, -1);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(712, 48);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			// 
			// lbEncabezadoConv
			// 
			this.lbEncabezadoConv.Font = new System.Drawing.Font("Times New Roman", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbEncabezadoConv.Location = new System.Drawing.Point(16, 16);
			this.lbEncabezadoConv.Name = "lbEncabezadoConv";
			this.lbEncabezadoConv.Size = new System.Drawing.Size(440, 23);
			this.lbEncabezadoConv.TabIndex = 0;
			this.lbEncabezadoConv.Text = "Convocatoria de Reunión del Departamento de";
			// 
			// tbpActas
			// 
			this.tbpActas.Controls.Add(this.groupBox7);
			this.tbpActas.Controls.Add(this.groupBox8);
			this.tbpActas.Controls.Add(this.groupBox9);
			this.tbpActas.Location = new System.Drawing.Point(4, 22);
			this.tbpActas.Name = "tbpActas";
			this.tbpActas.Size = new System.Drawing.Size(728, 446);
			this.tbpActas.TabIndex = 1;
			this.tbpActas.Text = "Actas";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.lbRuegosPreguntas_Actas);
			this.groupBox7.Controls.Add(this.lbOrdenesdia_Actas);
			this.groupBox7.Controls.Add(this.label29);
			this.groupBox7.Controls.Add(this.label27);
			this.groupBox7.Controls.Add(this.label21);
			this.groupBox7.Controls.Add(this.lbFecha_Acta);
			this.groupBox7.Controls.Add(this.label23);
			this.groupBox7.Controls.Add(this.label24);
			this.groupBox7.Controls.Add(this.lbModif_observ_Actas);
			this.groupBox7.Controls.Add(this.label26);
			this.groupBox7.Controls.Add(this.label28);
			this.groupBox7.Location = new System.Drawing.Point(8, 104);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox7.Size = new System.Drawing.Size(712, 336);
			this.groupBox7.TabIndex = 7;
			this.groupBox7.TabStop = false;
			// 
			// lbRuegosPreguntas_Actas
			// 
			this.lbRuegosPreguntas_Actas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbRuegosPreguntas_Actas.Location = new System.Drawing.Point(32, 232);
			this.lbRuegosPreguntas_Actas.Name = "lbRuegosPreguntas_Actas";
			this.lbRuegosPreguntas_Actas.Size = new System.Drawing.Size(648, 48);
			this.lbRuegosPreguntas_Actas.TabIndex = 12;
			this.lbRuegosPreguntas_Actas.Text = ".- Ruegos y preguntas :";
			// 
			// lbOrdenesdia_Actas
			// 
			this.lbOrdenesdia_Actas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbOrdenesdia_Actas.Location = new System.Drawing.Point(32, 160);
			this.lbOrdenesdia_Actas.Name = "lbOrdenesdia_Actas";
			this.lbOrdenesdia_Actas.Size = new System.Drawing.Size(648, 48);
			this.lbOrdenesdia_Actas.TabIndex = 11;
			this.lbOrdenesdia_Actas.Text = "Punto 2º-";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.Location = new System.Drawing.Point(56, 80);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(536, 16);
			this.label29.TabIndex = 10;
			this.label29.Text = "-Leída el acta de la sesión anterior se realizaron las siguientes observaciones y" +
				" modificaciones de las misma :";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(56, 80);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(648, 16);
			this.label27.TabIndex = 9;
			this.label27.Text = "-Leída el acta de la sesión anterior y no habiendo enmiendas ni observaciones a l" +
				"a misma, se aprobó por unanimidad";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(544, 304);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(128, 16);
			this.label21.TabIndex = 8;
			this.label21.Text = " El Jefe de Departamento.";
			// 
			// lbFecha_Acta
			// 
			this.lbFecha_Acta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbFecha_Acta.Location = new System.Drawing.Point(488, 288);
			this.lbFecha_Acta.Name = "lbFecha_Acta";
			this.lbFecha_Acta.Size = new System.Drawing.Size(128, 16);
			this.lbFecha_Acta.TabIndex = 7;
			this.lbFecha_Acta.Text = "dd/mm/aaaa";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(408, 288);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 16);
			this.label23.TabIndex = 6;
			this.label23.Text = " En Granada a";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(32, 208);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(648, 16);
			this.label24.TabIndex = 5;
			this.label24.Text = ".- Ruegos y preguntas :";
			// 
			// lbModif_observ_Actas
			// 
			this.lbModif_observ_Actas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbModif_observ_Actas.Location = new System.Drawing.Point(32, 104);
			this.lbModif_observ_Actas.Name = "lbModif_observ_Actas";
			this.lbModif_observ_Actas.Size = new System.Drawing.Size(648, 48);
			this.lbModif_observ_Actas.TabIndex = 4;
			this.lbModif_observ_Actas.Text = "................................................................................." +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"................................................................................" +
				"...........................................................................";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(32, 56);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(328, 16);
			this.label26.TabIndex = 3;
			this.label26.Text = "Punto 1º -Lectura y aprobación si procede del acta de la sesión anterior : ";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(32, 32);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(648, 16);
			this.label28.TabIndex = 1;
			this.label28.Text = "Reunido el departamento en el día de la fecha y lugar de convocatoria arriba cons" +
				"ignados, se desarrolló con el siguiente orden del día:";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.lbLugar_Act);
			this.groupBox8.Controls.Add(this.lbFecha_Act);
			this.groupBox8.Controls.Add(this.lbHora_Act);
			this.groupBox8.Controls.Add(this.lbNum_Sesion_Act);
			this.groupBox8.Controls.Add(this.label30);
			this.groupBox8.Controls.Add(this.label31);
			this.groupBox8.Controls.Add(this.label32);
			this.groupBox8.Controls.Add(this.label33);
			this.groupBox8.Location = new System.Drawing.Point(8, 48);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(712, 48);
			this.groupBox8.TabIndex = 6;
			this.groupBox8.TabStop = false;
			// 
			// lbLugar_Act
			// 
			this.lbLugar_Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbLugar_Act.Location = new System.Drawing.Point(496, 18);
			this.lbLugar_Act.Name = "lbLugar_Act";
			this.lbLugar_Act.Size = new System.Drawing.Size(192, 16);
			this.lbLugar_Act.TabIndex = 33;
			// 
			// lbFecha_Act
			// 
			this.lbFecha_Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbFecha_Act.Location = new System.Drawing.Point(336, 18);
			this.lbFecha_Act.Name = "lbFecha_Act";
			this.lbFecha_Act.Size = new System.Drawing.Size(72, 16);
			this.lbFecha_Act.TabIndex = 32;
			// 
			// lbHora_Act
			// 
			this.lbHora_Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbHora_Act.Location = new System.Drawing.Point(216, 18);
			this.lbHora_Act.Name = "lbHora_Act";
			this.lbHora_Act.Size = new System.Drawing.Size(32, 16);
			this.lbHora_Act.TabIndex = 31;
			// 
			// lbNum_Sesion_Act
			// 
			this.lbNum_Sesion_Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbNum_Sesion_Act.Location = new System.Drawing.Point(104, 18);
			this.lbNum_Sesion_Act.Name = "lbNum_Sesion_Act";
			this.lbNum_Sesion_Act.Size = new System.Drawing.Size(24, 16);
			this.lbNum_Sesion_Act.TabIndex = 29;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(432, 16);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(72, 24);
			this.label30.TabIndex = 5;
			this.label30.Text = "Lugar : ";
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.Location = new System.Drawing.Point(16, 16);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(72, 24);
			this.label31.TabIndex = 1;
			this.label31.Text = "Sesión Nº: ";
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.Location = new System.Drawing.Point(160, 16);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(48, 24);
			this.label32.TabIndex = 4;
			this.label32.Text = "Hora : ";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(272, 16);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(72, 24);
			this.label33.TabIndex = 4;
			this.label33.Text = "Fecha : ";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.lbEncabezadoActa);
			this.groupBox9.Location = new System.Drawing.Point(8, -1);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(712, 48);
			this.groupBox9.TabIndex = 5;
			this.groupBox9.TabStop = false;
			// 
			// lbEncabezadoActa
			// 
			this.lbEncabezadoActa.Font = new System.Drawing.Font("Times New Roman", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbEncabezadoActa.Location = new System.Drawing.Point(16, 16);
			this.lbEncabezadoActa.Name = "lbEncabezadoActa";
			this.lbEncabezadoActa.Size = new System.Drawing.Size(584, 23);
			this.lbEncabezadoActa.TabIndex = 3;
			this.lbEncabezadoActa.Text = "Acta de Reunión de Departamento de";
			// 
			// tbpR_ETCP
			// 
			this.tbpR_ETCP.Location = new System.Drawing.Point(4, 22);
			this.tbpR_ETCP.Name = "tbpR_ETCP";
			this.tbpR_ETCP.Size = new System.Drawing.Size(792, 579);
			this.tbpR_ETCP.TabIndex = 1;
			this.tbpR_ETCP.Text = "Reuniones del ETCP";
			// 
			// btConfirmacion2
			// 
			this.btConfirmacion2.Controls.Add(this.lbConfirmaIngreso);
			this.btConfirmacion2.Controls.Add(this.btCANCEL);
			this.btConfirmacion2.Controls.Add(this.btOK);
			this.btConfirmacion2.Location = new System.Drawing.Point(312, 300);
			this.btConfirmacion2.Name = "btConfirmacion2";
			this.btConfirmacion2.Size = new System.Drawing.Size(312, 124);
			this.btConfirmacion2.TabIndex = 27;
			this.btConfirmacion2.TabStop = false;
			this.btConfirmacion2.Text = "Ventana de Confirmación";
			this.btConfirmacion2.Visible = false;
			// 
			// lbConfirmaIngreso
			// 
			this.lbConfirmaIngreso.Location = new System.Drawing.Point(16, 32);
			this.lbConfirmaIngreso.Name = "lbConfirmaIngreso";
			this.lbConfirmaIngreso.Size = new System.Drawing.Size(288, 16);
			this.lbConfirmaIngreso.TabIndex = 26;
			this.lbConfirmaIngreso.Text = "¿Confirma la eliminación del documento seleccionado?";
			this.lbConfirmaIngreso.Visible = false;
			// 
			// btCANCEL
			// 
			this.btCANCEL.Location = new System.Drawing.Point(176, 72);
			this.btCANCEL.Name = "btCANCEL";
			this.btCANCEL.TabIndex = 25;
			this.btCANCEL.Text = "CANCEL";
			this.btCANCEL.Visible = false;
			this.btCANCEL.Click += new System.EventHandler(this.btCANCEL_Click);
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(64, 72);
			this.btOK.Name = "btOK";
			this.btOK.TabIndex = 24;
			this.btOK.Text = "OK";
			this.btOK.Visible = false;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(792, 579);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Presupuestos";
			// 
			// Form5
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(914, 605);
			this.Controls.Add(this.btConfirmacion2);
			this.Controls.Add(this.tabInformes);
			this.Menu = this.mainMenu1;
			this.Name = "Form5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "INFORMES";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form5_Load);
			this.Closed += new System.EventHandler(this.Form5_Closed);
			this.tabInformes.ResumeLayout(false);
			this.tbpR_DEPART.ResumeLayout(false);
			this.tabACTAS_CONVOCATORIAS.ResumeLayout(false);
			this.tbpActasConvocatorias.ResumeLayout(false);
			this.gbACCESO_INFO.ResumeLayout(false);
			this.gbFiltrado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tbpEdicionActas.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabCamposActas.ResumeLayout(false);
			this.tbpModif_Observ_Anterior.ResumeLayout(false);
			this.tbpOrdenes.ResumeLayout(false);
			this.tbpRuegosPreguntas.ResumeLayout(false);
			this.tbpvisor.ResumeLayout(false);
			this.tabVisorDocumentos.ResumeLayout(false);
			this.tbpConvocatorias.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tbpActas.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.btConfirmacion2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form5_Load(object sender, System.EventArgs e)
		{
			funciones.bandera[30]=0;
			funciones.bandera[49]=0;
			funcion.volcar_listado(this.dataGrid1);
		}

		private void Form5_Closed(object sender, System.EventArgs e)
		{
			funciones.bandera[30]=1;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			funciones.bandera[30]=1;
		}

		private void btProceder2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.cbAcciones.Text.ToString()=="-Generar Acta/Convocatoria")
				{
					if((this.tbOrdenesDia.Text=="")||(this.tbNombre.Text=="")||(this.tbLugar.Text=="")||(this.cbHora.Text.ToString()=="Hora")||(this.cbMinutos.Text.ToString()=="Min")||(this.listBox1.SelectedItem==null))
					{
						if((this.tbActasAnteriores.Text=="")&&(this.rbAct.Checked==true))
						{
							if(this.listBox1.SelectedItem==null)
							{
								MessageBox.Show("Por favor, compruebe que todos los campos necesarios \npara la creación del Acta están rellenos.\nNo olvide confirmar el número de sesión pinchando encima de éste.");
							}
							else
							{
								MessageBox.Show("Por favor, compruebe que todos los campos necesarios \npara la creación del Acta están rellenos.\n");

							}
						}
						else //El radioButtom rbConv está marcado y el texto de actas anteriores no estará relleno
						{
							if(this.listBox1.SelectedItem==null)
							{
								MessageBox.Show("Por favor, compruebe que todos los campos necesarios \npara la creación del Acta están rellenos.\nNo olvide confirmar el número de sesión pinchando encima de éste.");
							}
							else
							{
								MessageBox.Show("Por favor, compruebe que todos los campos necesarios \npara la creación del Acta están rellenos.\n");

							}
						}
					}
					else
					{
						if(this.rbAct.Checked==true)
						{
							if(funcion.inserta_acta(this.tbActasAnteriores.Text.ToString(),this.tbOrdenesDia.Text.ToString(),this.tbRuegosyPreguntas.Text.ToString(),this.tbNombre.Text.ToString(),this.tbLugar.Text.ToString(),this.dateTimePicker2.Value.ToString(),this.cbHora.Text.ToString()+this.cbMinutos.Text.ToString(),this.listBox1.Text.ToString())==1)
							{
								MessageBox.Show("Nueva acta creada.");
								this.tbActasAnteriores.Text="";
								this.tbOrdenesDia.Text="";
								this.tbRuegosyPreguntas.Text="";
								this.tbNombre.Text="";
								this.tbLugar.Text="";
								this.cbHora.Text="Hora";
								this.cbMinutos.Text="Min";
								funcion.volcar_listado(this.dataGrid1);
							}
						}
						else
						{
							if(funcion.inserta_convocatoria(this.tbOrdenesDia.Text.ToString(),this.tbRuegosyPreguntas.Text.ToString(),this.tbNombre.Text.ToString(),this.tbLugar.Text.ToString(),this.dateTimePicker2.Value.ToString(),this.cbHora.Text.ToString()+this.cbMinutos.Text.ToString(),this.listBox1.Text.ToString())==1)
							{
								MessageBox.Show("Nueva convocatoria creada.");
								this.tbActasAnteriores.Text="";
								this.tbOrdenesDia.Text="";
								this.tbRuegosyPreguntas.Text="";
								this.tbNombre.Text="";
								this.tbLugar.Text="";
								this.cbHora.Text="Hora";
								this.cbMinutos.Text="Min";
								funcion.volcar_listado(this.dataGrid1);
							}

						}

					
					}
				}
				else if(this.cbAcciones.Text.ToString()=="-Actualizar Acta/Convocatoria")
				{
					if(P1.Tools.funciones.bandera[49].ToString()=="0")
					{
						MessageBox.Show("Seleccione un acta del listado para actualizarla.");
						funcion.volcar_listado(this.dataGrid1);
						this.tbActasAnteriores.Text="";
						this.tbOrdenesDia.Text="";
						this.tbRuegosyPreguntas.Text="";
						this.tbNombre.Text="";
						this.tbLugar.Text="";
						this.cbHora.Text="Hora";
						this.cbMinutos.Text="Min";
						this.tabCamposActas.SelectedTab = this.tbpModif_Observ_Anterior;
						this.tabACTAS_CONVOCATORIAS.SelectedTab = this.tbpActasConvocatorias;
						this.rbModificar.Checked=true;
					}
					else
					{
						funciones.bandera[49]=0;
						DataGridCell myCell1 = new DataGridCell();
						DataGridCell myCell2 = new DataGridCell();
						myCell1.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
						myCell2.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
						myCell1.ColumnNumber = 0;//La primera posición es la del número de sesión.
						myCell2.ColumnNumber = 2;

						int sesion =funcion.elimina(int.Parse(this.dataGrid1[myCell1].ToString()),this.dataGrid1[myCell2].ToString()); 
						// Sesión recibe el identificador de la fila que fue borrada
						//y que a continuáción será creada (actualizada) de nuevo
						
						if((this.dataGrid1[myCell2].ToString()=="ACTA")&& (sesion!=-1))
						{
							if(funcion.inserta_acta2(this.tbActasAnteriores.Text.ToString(),this.tbOrdenesDia.Text.ToString(),this.tbRuegosyPreguntas.Text.ToString(),this.tbNombre.Text.ToString(),this.tbLugar.Text.ToString(),this.dateTimePicker2.Value.ToString(),this.cbHora.Text.ToString()+this.cbMinutos.Text.ToString(),sesion.ToString(),this.listBox1.Text.ToString())==1)
							{
								MessageBox.Show("La actualización se realizó satisfactoriamente.");
								funcion.volcar_listado(this.dataGrid1);
							}
							
						}
						else if(sesion!=-1)
						{
							if(funcion.inserta_convocatoria2(this.tbOrdenesDia.Text.ToString(),this.tbRuegosyPreguntas.Text.ToString(),this.tbNombre.Text.ToString(),this.tbLugar.Text.ToString(),this.dateTimePicker2.Value.ToString(),this.cbHora.Text.ToString()+this.cbMinutos.Text.ToString(),sesion.ToString(),this.listBox1.Text.ToString())==1)
							{
								MessageBox.Show("La actualización se realizó satisfactoriamente.");
								funcion.volcar_listado(this.dataGrid1);
							}
							
						}
						else
						{
							MessageBox.Show("No se ha podido llevar a cabo la actualización");
						}
						
					}
				}
				else if(this.cbAcciones.Text.ToString()=="-Borrar todos los campos")
				{
					this.tbActasAnteriores.Text="";
					this.tbOrdenesDia.Text="";
					this.tbRuegosyPreguntas.Text="";
					this.tbNombre.Text="";
					this.tbLugar.Text="";
					this.cbHora.Text="Hora";
					this.cbMinutos.Text="Min";

				}
				else
				{
					MessageBox.Show("Seleccione una acción antes de PROCEDER.");
				}
			}
			catch(Exception x){MessageBox.Show(x.Message.ToString());}
		}

		

		private void btBusquedaXfecha_Click(object sender, System.EventArgs e)
		{
			if((this.cbActas.Checked==true)||(this.cbConvocatorias.Checked==true))
			{
				this.btBusquedaXfecha.Visible=false;
				this.btListadoCompleto.Visible=true;
				this.btListadoCompleto.Focus();
				if((this.cbActas.Checked==true)&&(this.cbConvocatorias.Checked==true))
				{
					funcion.filtrar_listado2(this.dataGrid1,this.dateTimePicker1.Value.ToString(),"ACTA+CONVOCATORIA");
				}
				else if(this.cbActas.Checked==true)
				{
					funcion.filtrar_listado2(this.dataGrid1,this.dateTimePicker1.Value.ToString(),"ACTA");
				}
				else if(this.cbConvocatorias.Checked==true)
				{
					funcion.filtrar_listado2(this.dataGrid1,this.dateTimePicker1.Value.ToString(),"CONVOCATORIA");
				}

			}
			else
			{
				MessageBox.Show("Seleccione el tipo de documento a buscar.");
			}
		}

		private void btFiltrado_Click(object sender, System.EventArgs e)
		{
			if((this.rbN_SESION.Checked==false)&&(this.rbFecha.Checked==false)&&(this.rbNombre.Checked==false))
			{
				MessageBox.Show("Seleccione un campo de filtrado.");
			}
			else
			{
				funcion.volcar_listado(this.dataGrid1);
				if(this.rbN_SESION.Checked==true)
				{
					funcion.filtrar_listado(this.dataGrid1,"SESION");
				}
				if(this.rbFecha.Checked==true)
				{
					funcion.filtrar_listado(this.dataGrid1,"FECHA");
				}
				if(this.rbNombre.Checked==true)
				{
					funcion.filtrar_listado(this.dataGrid1,"NOMBRE");
				}
			}
			

		}

		private void btProceder_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataGridCell myCell1 = new DataGridCell();
				myCell1.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
				myCell1.ColumnNumber = 2;

				DataGridCell myCell2 = new DataGridCell();
				myCell2.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
				myCell2.ColumnNumber = 0;
			

				if(this.rbModificar.Checked==true)
				{
					funciones.bandera[49]=1;
					this.tabACTAS_CONVOCATORIAS.SelectedTab = this.tbpEdicionActas;
					
					if(this.dataGrid1[myCell1].ToString()=="ACTA")
					{
						this.rbAct.Checked=true;
						this.tbActasAnteriores.Text="";
						this.tbOrdenesDia.Text="";
						this.tbRuegosyPreguntas.Text="";
						this.tbNombre.Text="";
						this.tbLugar.Text="";
						this.cbHora.Text="Hora";
						this.cbMinutos.Text="Min";
						string tipo=this.dataGrid1[myCell1].ToString();
						int sesion = int.Parse(this.dataGrid1[myCell2].ToString());
						this.cbAcciones.Text="-Actualizar Acta/Convocatoria";
						funcion.carga_contenidos(this.listBox1,this.dateTimePicker2,this.tbActasAnteriores,this.tbOrdenesDia,this.tbRuegosyPreguntas,this.tbNombre,this.tbLugar,this.cbHora,this.cbMinutos,tipo,sesion);


					}
					else
					{
						this.tabCamposActas.SelectedTab=this.tbpOrdenes;
						this.rbConv.Checked=true;						
						this.tbActasAnteriores.Text="";
						this.tbOrdenesDia.Text="";
						this.tbRuegosyPreguntas.Text="";
						this.tbNombre.Text="";
						this.tbLugar.Text="";
						this.cbHora.Text="Hora";
						this.cbMinutos.Text="Min";
						string tipo=this.dataGrid1[myCell1].ToString();
						int sesion = int.Parse(this.dataGrid1[myCell2].ToString());
						this.cbAcciones.Text="-Actualizar Acta/Convocatoria";
						funcion.carga_contenidos(this.listBox1,this.dateTimePicker2,this.tbActasAnteriores,this.tbOrdenesDia,this.tbRuegosyPreguntas,this.tbNombre,this.tbLugar,this.cbHora,this.cbMinutos,tipo,sesion);
					}
				}
				else if(this.rbAccesoDocumento.Checked==true)
				{
					
					DataGridCell myCell11 = new DataGridCell();
					DataGridCell myCell22 = new DataGridCell();
					myCell11.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
					myCell22.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
					myCell11.ColumnNumber = 0;//La primera posición es la del número de sesión.
					myCell22.ColumnNumber = 2;

					if(this.dataGrid1[myCell22].ToString()=="ACTA")
					{
						
						this.lbFecha_Acta.Text=this.dateTimePicker3.Value.ToString().Substring(0,10);
						this.tabACTAS_CONVOCATORIAS.SelectedTab=this.tbpvisor;
						this.tabVisorDocumentos.SelectedTab=this.tbpActas;

						funcion.genera_doc(this.dataGrid1[myCell11].ToString(),this.dataGrid1[myCell22].ToString(),this.lbEncabezadoActa,this.lbNum_Sesion_Act,this.lbHora_Act,this.lbFecha_Act,this.lbLugar_Act,this.lbContenidoConv,this.lbModif_observ_Actas,this.lbOrdenesdia_Actas,this.lbRuegosPreguntas_Actas);
						

					}
					else if(this.dataGrid1[myCell22].ToString()=="CONVOCATORIA")
					{
						this.lbFecha_Conv.Text=this.dateTimePicker3.Value.ToString().Substring(0,10);
						this.tabACTAS_CONVOCATORIAS.SelectedTab=this.tbpvisor;
						this.tabVisorDocumentos.SelectedTab=this.tbpConvocatorias;
						funcion.genera_doc(this.dataGrid1[myCell11].ToString(),this.dataGrid1[myCell22].ToString(),this.lbEncabezadoConv,this.lbNum_Sesion_Conv,this.lbHora_Conv,this.lbFecha_Convocatoria,this.lbLugar_Convocatoria, this.lbContenidoConv,this.lbModif_observ_Actas,this.lbOrdenesdia_Actas,this.lbRuegosPreguntas_Actas);

					}

					

				}
				else if(this.rbEliminaDocumento.Checked==true)
				{
					this.tabACTAS_CONVOCATORIAS.Enabled=false;
					this.btConfirmacion2.Visible=true;
					this.lbConfirmaIngreso.Visible=true;
					this.btOK.Visible=true;
					this.btCANCEL.Visible=true;
					
				}
				else
				{
					MessageBox.Show("Seleccione una acción antes de PROCEDER.");
					this.rbModificar.Focus();
				}
			}
			catch(Exception x){MessageBox.Show(x.Message.ToString());}
			
					



			
		}

		private void rbAct_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.rbAct.Checked==false)
			{
				this.tabCamposActas.SelectedTab = this.tbpOrdenes;
				this.label1.Enabled=false;
				this.tbActasAnteriores.Text="";
				this.tbActasAnteriores.Enabled=false;
				
			}
			else
			{
				this.tabCamposActas.SelectedTab = this.tbpModif_Observ_Anterior;
				this.label1.Enabled=true;
				this.tbActasAnteriores.Enabled=true;
			}


		}

		private void btOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataGridCell myCell1 = new DataGridCell();
				DataGridCell myCell2 = new DataGridCell();
				myCell1.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
				myCell2.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
				myCell1.ColumnNumber = 0;//La primera posición es la del número de sesión.
				myCell2.ColumnNumber = 2;

				if(funcion.elimina(int.Parse(this.dataGrid1[myCell1].ToString()),this.dataGrid1[myCell2].ToString())!=-1)
				{
					this.btConfirmacion2.Visible=false;
					this.lbConfirmaIngreso.Visible=false;
					this.btOK.Visible=false;
					this.btCANCEL.Visible=false;
					this.tabACTAS_CONVOCATORIAS.Enabled=true;
					
					MessageBox.Show("El documento se eliminó correctamente.");
					funcion.volcar_listado(this.dataGrid1);
				}
				else
				{
					this.btConfirmacion2.Visible=false;
					this.lbConfirmaIngreso.Visible=false;
					this.btOK.Visible=false;
					this.btCANCEL.Visible=false;

					this.tabACTAS_CONVOCATORIAS.Enabled=true;
					
					MessageBox.Show("No se pudo eliminar el documento.");
				}
			}
			catch(Exception x){MessageBox.Show(x.Message.ToString());}
		}

		private void btCANCEL_Click(object sender, System.EventArgs e)
		{
			this.btConfirmacion2.Visible=false;
			this.lbConfirmaIngreso.Visible=false;
			this.btOK.Visible=false;
			this.btCANCEL.Visible=false;

			this.tabACTAS_CONVOCATORIAS.Enabled=true;

		
		}

		private void btListadoCompleto_Click(object sender, System.EventArgs e)
		{
			this.btBusquedaXfecha.Visible=true;
			this.btBusquedaXfecha.Focus();
			this.btListadoCompleto.Visible=false;
			this.cbActas.Checked=false;
			this.cbConvocatorias.Checked=false;
			funcion.volcar_listado(this.dataGrid1);
		}

		

				
		

		
	}
}
