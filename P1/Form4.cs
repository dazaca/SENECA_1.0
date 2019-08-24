using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using P1.Tools;
using System.Data;
using System.Data.OracleClient;


namespace P1
{
	/// <summary>
	/// Descripción breve de Form4.
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.TabPage tabp_list_prof;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tb_nombre;
		private System.Windows.Forms.TextBox tb_apellidos;
		private System.Windows.Forms.TextBox tb_dni;
		private System.Windows.Forms.Button btPrimero;
		private System.Windows.Forms.Button btAnterior;
		private System.Windows.Forms.Button btSiguiente;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button tbBusqueda;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Button btBorrar;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbMovil;
		private System.Windows.Forms.TextBox tbFijo;
		private System.Windows.Forms.Button btSelectAll;
		private System.Windows.Forms.Button btDeselectAll;
		private System.Windows.Forms.Button btAccion;
		private System.Windows.Forms.TabControl tbCuenta2;
		private System.Windows.Forms.TabControl tabinfo;
		private System.Windows.Forms.TabPage tabpFijo;
		private System.Windows.Forms.TabPage tabpMovil;
		private System.Windows.Forms.TabPage tabpEmail;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.PictureBox pb_fotografia;
		private System.Windows.Forms.ComboBox cbAccion;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCANCEL;
		private System.Windows.Forms.GroupBox btConfirmacion;
		private System.Windows.Forms.GroupBox gbEdicion;
		private System.Windows.Forms.GroupBox gbDatosProf;
		private System.Windows.Forms.CheckBox cbImagen;
		private System.Windows.Forms.CheckBox cbNombre;
		private System.Windows.Forms.CheckBox cbApellidos;
		private System.Windows.Forms.CheckBox cbDNI;
		private System.Windows.Forms.CheckBox cbFijo;
		private System.Windows.Forms.CheckBox cbEmail;
		private System.Windows.Forms.CheckBox cbMovil;
		private System.Windows.Forms.CheckBox cbPassword;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lbConfirmaIngreso;
		private System.Windows.Forms.Label lbConfirmaElimina;
		private System.Windows.Forms.Label lb_img_no_disp;
		private System.Windows.Forms.Button btUltimo;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		
		private System.Windows.Forms.Button bLimpiar;

		System.Data.DataView odv = new System.Data.DataView();
		OracleConnection Cnt = new OracleConnection();
		public string ConnectionString ="user id=ADMIN1;data source=ORCL;password=ADMIN1";
		OracleCommand Cmd = new OracleCommand();
		OracleDataAdapter DA = new OracleDataAdapter();
		DataSet DS = new DataSet();

		P1.Tools.funciones funcion = new  funciones();
		public string ruta_imagen;
		private System.Windows.Forms.TextBox tb_password2;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.DataGrid dataGrid4;
		private System.Windows.Forms.RadioButton rbDesvincular;
		private System.Windows.Forms.RadioButton rbAsignar;
		private System.Windows.Forms.TabControl tabGrupos;
		private System.Windows.Forms.Button btProceder;
		private System.Windows.Forms.ComboBox cbNombreProf;
		public int cont;

		public Form4()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form4));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.tbCuenta2 = new System.Windows.Forms.TabControl();
			this.tabp_list_prof = new System.Windows.Forms.TabPage();
			this.btConfirmacion = new System.Windows.Forms.GroupBox();
			this.lbConfirmaElimina = new System.Windows.Forms.Label();
			this.lbConfirmaIngreso = new System.Windows.Forms.Label();
			this.btCANCEL = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.gbEdicion = new System.Windows.Forms.GroupBox();
			this.btAccion = new System.Windows.Forms.Button();
			this.btDeselectAll = new System.Windows.Forms.Button();
			this.cbAccion = new System.Windows.Forms.ComboBox();
			this.btSelectAll = new System.Windows.Forms.Button();
			this.btBorrar = new System.Windows.Forms.Button();
			this.gbDatosProf = new System.Windows.Forms.GroupBox();
			this.tb_password2 = new System.Windows.Forms.TextBox();
			this.cbPassword = new System.Windows.Forms.CheckBox();
			this.cbDNI = new System.Windows.Forms.CheckBox();
			this.cbApellidos = new System.Windows.Forms.CheckBox();
			this.cbNombre = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lb_img_no_disp = new System.Windows.Forms.Label();
			this.cbImagen = new System.Windows.Forms.CheckBox();
			this.pb_fotografia = new System.Windows.Forms.PictureBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tabinfo = new System.Windows.Forms.TabControl();
			this.tabpFijo = new System.Windows.Forms.TabPage();
			this.tbFijo = new System.Windows.Forms.TextBox();
			this.cbFijo = new System.Windows.Forms.CheckBox();
			this.tabpMovil = new System.Windows.Forms.TabPage();
			this.cbMovil = new System.Windows.Forms.CheckBox();
			this.tbMovil = new System.Windows.Forms.TextBox();
			this.tabpEmail = new System.Windows.Forms.TabPage();
			this.cbEmail = new System.Windows.Forms.CheckBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tbBusqueda = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btSiguiente = new System.Windows.Forms.Button();
			this.btAnterior = new System.Windows.Forms.Button();
			this.btUltimo = new System.Windows.Forms.Button();
			this.btPrimero = new System.Windows.Forms.Button();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.tb_dni = new System.Windows.Forms.TextBox();
			this.tb_apellidos = new System.Windows.Forms.TextBox();
			this.tb_nombre = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btProceder = new System.Windows.Forms.Button();
			this.rbDesvincular = new System.Windows.Forms.RadioButton();
			this.rbAsignar = new System.Windows.Forms.RadioButton();
			this.cbNombreProf = new System.Windows.Forms.ComboBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tabGrupos = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.dataGrid4 = new System.Windows.Forms.DataGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbCuenta2.SuspendLayout();
			this.tabp_list_prof.SuspendLayout();
			this.btConfirmacion.SuspendLayout();
			this.gbEdicion.SuspendLayout();
			this.gbDatosProf.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabinfo.SuspendLayout();
			this.tabpFijo.SuspendLayout();
			this.tabpMovil.SuspendLayout();
			this.tabpEmail.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabGrupos.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
			this.groupBox2.SuspendLayout();
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
			// tbCuenta2
			// 
			this.tbCuenta2.Controls.Add(this.tabp_list_prof);
			this.tbCuenta2.Controls.Add(this.tabPage2);
			this.tbCuenta2.Dock = System.Windows.Forms.DockStyle.Right;
			this.tbCuenta2.Location = new System.Drawing.Point(114, 0);
			this.tbCuenta2.Name = "tbCuenta2";
			this.tbCuenta2.SelectedIndex = 0;
			this.tbCuenta2.Size = new System.Drawing.Size(800, 605);
			this.tbCuenta2.TabIndex = 1;
			// 
			// tabp_list_prof
			// 
			this.tabp_list_prof.Controls.Add(this.btConfirmacion);
			this.tabp_list_prof.Controls.Add(this.gbEdicion);
			this.tabp_list_prof.Controls.Add(this.gbDatosProf);
			this.tabp_list_prof.Location = new System.Drawing.Point(4, 22);
			this.tabp_list_prof.Name = "tabp_list_prof";
			this.tabp_list_prof.Size = new System.Drawing.Size(792, 579);
			this.tabp_list_prof.TabIndex = 0;
			this.tabp_list_prof.Text = "Registro de Profesores";
			// 
			// btConfirmacion
			// 
			this.btConfirmacion.Controls.Add(this.lbConfirmaElimina);
			this.btConfirmacion.Controls.Add(this.lbConfirmaIngreso);
			this.btConfirmacion.Controls.Add(this.btCANCEL);
			this.btConfirmacion.Controls.Add(this.btOK);
			this.btConfirmacion.Location = new System.Drawing.Point(248, 170);
			this.btConfirmacion.Name = "btConfirmacion";
			this.btConfirmacion.Size = new System.Drawing.Size(304, 120);
			this.btConfirmacion.TabIndex = 26;
			this.btConfirmacion.TabStop = false;
			this.btConfirmacion.Text = "Ventana de Confirmación";
			this.btConfirmacion.Visible = false;
			// 
			// lbConfirmaElimina
			// 
			this.lbConfirmaElimina.Location = new System.Drawing.Point(64, 32);
			this.lbConfirmaElimina.Name = "lbConfirmaElimina";
			this.lbConfirmaElimina.Size = new System.Drawing.Size(200, 32);
			this.lbConfirmaElimina.TabIndex = 27;
			this.lbConfirmaElimina.Text = "¿Eliminar los campos seleccionados?";
			this.lbConfirmaElimina.Visible = false;
			// 
			// lbConfirmaIngreso
			// 
			this.lbConfirmaIngreso.Location = new System.Drawing.Point(24, 24);
			this.lbConfirmaIngreso.Name = "lbConfirmaIngreso";
			this.lbConfirmaIngreso.Size = new System.Drawing.Size(264, 40);
			this.lbConfirmaIngreso.TabIndex = 26;
			this.lbConfirmaIngreso.Text = "¿Confirma el ingreso de los datos seleccionados?";
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
			// gbEdicion
			// 
			this.gbEdicion.Controls.Add(this.btAccion);
			this.gbEdicion.Controls.Add(this.btDeselectAll);
			this.gbEdicion.Controls.Add(this.cbAccion);
			this.gbEdicion.Controls.Add(this.btSelectAll);
			this.gbEdicion.Controls.Add(this.btBorrar);
			this.gbEdicion.Location = new System.Drawing.Point(32, 424);
			this.gbEdicion.Name = "gbEdicion";
			this.gbEdicion.Size = new System.Drawing.Size(728, 100);
			this.gbEdicion.TabIndex = 5;
			this.gbEdicion.TabStop = false;
			this.gbEdicion.Text = "Edición de Campos";
			// 
			// btAccion
			// 
			this.btAccion.Location = new System.Drawing.Point(608, 40);
			this.btAccion.Name = "btAccion";
			this.btAccion.Size = new System.Drawing.Size(104, 23);
			this.btAccion.TabIndex = 17;
			this.btAccion.Text = "Ejecutar Acción";
			this.btAccion.Click += new System.EventHandler(this.btAccion_Click);
			// 
			// btDeselectAll
			// 
			this.btDeselectAll.Location = new System.Drawing.Point(40, 40);
			this.btDeselectAll.Name = "btDeselectAll";
			this.btDeselectAll.Size = new System.Drawing.Size(112, 23);
			this.btDeselectAll.TabIndex = 14;
			this.btDeselectAll.Text = "Desmarcar Todos";
			this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
			// 
			// cbAccion
			// 
			this.cbAccion.Items.AddRange(new object[] {
														  "Ingresar Datos Selecciondados",
														  "Eliminar Datos Seleccionados"});
			this.cbAccion.Location = new System.Drawing.Point(384, 40);
			this.cbAccion.Name = "cbAccion";
			this.cbAccion.Size = new System.Drawing.Size(192, 21);
			this.cbAccion.TabIndex = 16;
			this.cbAccion.Text = "Seleccione Acción";
			// 
			// btSelectAll
			// 
			this.btSelectAll.Location = new System.Drawing.Point(40, 40);
			this.btSelectAll.Name = "btSelectAll";
			this.btSelectAll.Size = new System.Drawing.Size(112, 23);
			this.btSelectAll.TabIndex = 16;
			this.btSelectAll.Text = "Marcar Todos";
			this.btSelectAll.Visible = false;
			this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
			// 
			// btBorrar
			// 
			this.btBorrar.Location = new System.Drawing.Point(184, 40);
			this.btBorrar.Name = "btBorrar";
			this.btBorrar.Size = new System.Drawing.Size(120, 23);
			this.btBorrar.TabIndex = 15;
			this.btBorrar.Text = "Borrar Seleccionados";
			this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
			// 
			// gbDatosProf
			// 
			this.gbDatosProf.Controls.Add(this.tb_password2);
			this.gbDatosProf.Controls.Add(this.cbPassword);
			this.gbDatosProf.Controls.Add(this.cbDNI);
			this.gbDatosProf.Controls.Add(this.cbApellidos);
			this.gbDatosProf.Controls.Add(this.cbNombre);
			this.gbDatosProf.Controls.Add(this.groupBox5);
			this.gbDatosProf.Controls.Add(this.groupBox4);
			this.gbDatosProf.Controls.Add(this.tabinfo);
			this.gbDatosProf.Controls.Add(this.groupBox1);
			this.gbDatosProf.Controls.Add(this.btSiguiente);
			this.gbDatosProf.Controls.Add(this.btAnterior);
			this.gbDatosProf.Controls.Add(this.btUltimo);
			this.gbDatosProf.Controls.Add(this.btPrimero);
			this.gbDatosProf.Controls.Add(this.tb_password);
			this.gbDatosProf.Controls.Add(this.tb_dni);
			this.gbDatosProf.Controls.Add(this.tb_apellidos);
			this.gbDatosProf.Controls.Add(this.tb_nombre);
			this.gbDatosProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbDatosProf.Location = new System.Drawing.Point(32, 32);
			this.gbDatosProf.Name = "gbDatosProf";
			this.gbDatosProf.Size = new System.Drawing.Size(728, 360);
			this.gbDatosProf.TabIndex = 4;
			this.gbDatosProf.TabStop = false;
			this.gbDatosProf.Text = "Datos de las cuentas del Profesorado";
			// 
			// tb_password2
			// 
			this.tb_password2.Location = new System.Drawing.Point(96, 240);
			this.tb_password2.Name = "tb_password2";
			this.tb_password2.Size = new System.Drawing.Size(152, 20);
			this.tb_password2.TabIndex = 9;
			this.tb_password2.Text = "";
			this.tb_password2.Visible = false;
			// 
			// cbPassword
			// 
			this.cbPassword.Location = new System.Drawing.Point(16, 240);
			this.cbPassword.Name = "cbPassword";
			this.cbPassword.Size = new System.Drawing.Size(80, 16);
			this.cbPassword.TabIndex = 26;
			this.cbPassword.Text = "Password :";
			// 
			// cbDNI
			// 
			this.cbDNI.Location = new System.Drawing.Point(16, 128);
			this.cbDNI.Name = "cbDNI";
			this.cbDNI.Size = new System.Drawing.Size(72, 16);
			this.cbDNI.TabIndex = 25;
			this.cbDNI.Text = "DNI/NIF :";
			// 
			// cbApellidos
			// 
			this.cbApellidos.Location = new System.Drawing.Point(16, 88);
			this.cbApellidos.Name = "cbApellidos";
			this.cbApellidos.Size = new System.Drawing.Size(80, 16);
			this.cbApellidos.TabIndex = 24;
			this.cbApellidos.Text = "Apellidos :";
			this.cbApellidos.CheckedChanged += new System.EventHandler(this.cbApellidos_CheckedChanged);
			// 
			// cbNombre
			// 
			this.cbNombre.Location = new System.Drawing.Point(16, 48);
			this.cbNombre.Name = "cbNombre";
			this.cbNombre.Size = new System.Drawing.Size(72, 16);
			this.cbNombre.TabIndex = 23;
			this.cbNombre.Text = "Nombre :";
			this.cbNombre.CheckedChanged += new System.EventHandler(this.cbNombre_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lb_img_no_disp);
			this.groupBox5.Controls.Add(this.cbImagen);
			this.groupBox5.Controls.Add(this.pb_fotografia);
			this.groupBox5.Location = new System.Drawing.Point(544, 24);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(160, 128);
			this.groupBox5.TabIndex = 22;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Fotografía";
			// 
			// lb_img_no_disp
			// 
			this.lb_img_no_disp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lb_img_no_disp.Location = new System.Drawing.Point(48, 48);
			this.lb_img_no_disp.Name = "lb_img_no_disp";
			this.lb_img_no_disp.Size = new System.Drawing.Size(64, 32);
			this.lb_img_no_disp.TabIndex = 25;
			this.lb_img_no_disp.Text = "Imagen no Disponible";
			this.lb_img_no_disp.Visible = false;
			this.lb_img_no_disp.Click += new System.EventHandler(this.lb_img_no_disp_Click);
			// 
			// cbImagen
			// 
			this.cbImagen.Checked = true;
			this.cbImagen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbImagen.Location = new System.Drawing.Point(136, 104);
			this.cbImagen.Name = "cbImagen";
			this.cbImagen.Size = new System.Drawing.Size(16, 16);
			this.cbImagen.TabIndex = 27;
			this.cbImagen.CheckedChanged += new System.EventHandler(this.cbImagen_CheckedChanged);
			// 
			// pb_fotografia
			// 
			this.pb_fotografia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_fotografia.Location = new System.Drawing.Point(24, 24);
			this.pb_fotografia.Name = "pb_fotografia";
			this.pb_fotografia.Size = new System.Drawing.Size(104, 80);
			this.pb_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_fotografia.TabIndex = 23;
			this.pb_fotografia.TabStop = false;
			this.pb_fotografia.Click += new System.EventHandler(this.pb_fotografia_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.treeView1);
			this.groupBox4.Location = new System.Drawing.Point(312, 24);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(216, 272);
			this.groupBox4.TabIndex = 21;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Grupos";
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(8, 16);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(200, 248);
			this.treeView1.TabIndex = 22;
			// 
			// tabinfo
			// 
			this.tabinfo.Controls.Add(this.tabpFijo);
			this.tabinfo.Controls.Add(this.tabpMovil);
			this.tabinfo.Controls.Add(this.tabpEmail);
			this.tabinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabinfo.Location = new System.Drawing.Point(16, 160);
			this.tabinfo.Name = "tabinfo";
			this.tabinfo.SelectedIndex = 0;
			this.tabinfo.Size = new System.Drawing.Size(248, 64);
			this.tabinfo.TabIndex = 8;
			// 
			// tabpFijo
			// 
			this.tabpFijo.Controls.Add(this.tbFijo);
			this.tabpFijo.Controls.Add(this.cbFijo);
			this.tabpFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabpFijo.Location = new System.Drawing.Point(4, 22);
			this.tabpFijo.Name = "tabpFijo";
			this.tabpFijo.Size = new System.Drawing.Size(240, 38);
			this.tabpFijo.TabIndex = 0;
			this.tabpFijo.Text = "Fijo";
			// 
			// tbFijo
			// 
			this.tbFijo.AutoSize = false;
			this.tbFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbFijo.Location = new System.Drawing.Point(36, 10);
			this.tbFijo.Name = "tbFijo";
			this.tbFijo.Size = new System.Drawing.Size(192, 18);
			this.tbFijo.TabIndex = 6;
			this.tbFijo.Text = "";
			this.tbFijo.TextChanged += new System.EventHandler(this.tbFijo_TextChanged);
			// 
			// cbFijo
			// 
			this.cbFijo.Location = new System.Drawing.Point(12, 10);
			this.cbFijo.Name = "cbFijo";
			this.cbFijo.Size = new System.Drawing.Size(16, 16);
			this.cbFijo.TabIndex = 26;
			// 
			// tabpMovil
			// 
			this.tabpMovil.Controls.Add(this.cbMovil);
			this.tabpMovil.Controls.Add(this.tbMovil);
			this.tabpMovil.Location = new System.Drawing.Point(4, 22);
			this.tabpMovil.Name = "tabpMovil";
			this.tabpMovil.Size = new System.Drawing.Size(240, 38);
			this.tabpMovil.TabIndex = 1;
			this.tabpMovil.Text = "Móvil";
			// 
			// cbMovil
			// 
			this.cbMovil.Location = new System.Drawing.Point(10, 12);
			this.cbMovil.Name = "cbMovil";
			this.cbMovil.Size = new System.Drawing.Size(16, 16);
			this.cbMovil.TabIndex = 27;
			// 
			// tbMovil
			// 
			this.tbMovil.Location = new System.Drawing.Point(36, 10);
			this.tbMovil.Name = "tbMovil";
			this.tbMovil.Size = new System.Drawing.Size(192, 18);
			this.tbMovil.TabIndex = 7;
			this.tbMovil.Text = "";
			this.tbMovil.TextChanged += new System.EventHandler(this.tbMovil_TextChanged);
			// 
			// tabpEmail
			// 
			this.tabpEmail.Controls.Add(this.cbEmail);
			this.tabpEmail.Controls.Add(this.tbEmail);
			this.tabpEmail.Location = new System.Drawing.Point(4, 22);
			this.tabpEmail.Name = "tabpEmail";
			this.tabpEmail.Size = new System.Drawing.Size(240, 38);
			this.tabpEmail.TabIndex = 2;
			this.tabpEmail.Text = "E-mail";
			// 
			// cbEmail
			// 
			this.cbEmail.Location = new System.Drawing.Point(10, 12);
			this.cbEmail.Name = "cbEmail";
			this.cbEmail.Size = new System.Drawing.Size(16, 16);
			this.cbEmail.TabIndex = 28;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(36, 10);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(192, 18);
			this.tbEmail.TabIndex = 0;
			this.tbEmail.Text = "";
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.tbBusqueda);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(544, 184);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 112);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Búsqueda";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(8, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 21);
			this.comboBox1.TabIndex = 28;
			this.comboBox1.Text = "Campo Filtrado";
			// 
			// tbBusqueda
			// 
			this.tbBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tbBusqueda.Image")));
			this.tbBusqueda.Location = new System.Drawing.Point(120, 80);
			this.tbBusqueda.Name = "tbBusqueda";
			this.tbBusqueda.Size = new System.Drawing.Size(24, 24);
			this.tbBusqueda.TabIndex = 15;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 29;
			this.textBox1.Text = "Keyword";
			// 
			// btSiguiente
			// 
			this.btSiguiente.Location = new System.Drawing.Point(216, 312);
			this.btSiguiente.Name = "btSiguiente";
			this.btSiguiente.TabIndex = 12;
			this.btSiguiente.Text = "Siguiente";
			this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
			// 
			// btAnterior
			// 
			this.btAnterior.Location = new System.Drawing.Point(128, 312);
			this.btAnterior.Name = "btAnterior";
			this.btAnterior.TabIndex = 11;
			this.btAnterior.Text = "Anterior";
			this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
			// 
			// btUltimo
			// 
			this.btUltimo.Location = new System.Drawing.Point(304, 312);
			this.btUltimo.Name = "btUltimo";
			this.btUltimo.TabIndex = 13;
			this.btUltimo.Text = "Último";
			this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
			// 
			// btPrimero
			// 
			this.btPrimero.Location = new System.Drawing.Point(40, 312);
			this.btPrimero.Name = "btPrimero";
			this.btPrimero.TabIndex = 10;
			this.btPrimero.Text = "Primero";
			this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(96, 240);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(152, 20);
			this.tb_password.TabIndex = 7;
			this.tb_password.Text = "";
			this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
			// 
			// tb_dni
			// 
			this.tb_dni.Location = new System.Drawing.Point(96, 128);
			this.tb_dni.Name = "tb_dni";
			this.tb_dni.Size = new System.Drawing.Size(80, 20);
			this.tb_dni.TabIndex = 5;
			this.tb_dni.Text = "";
			this.tb_dni.TextChanged += new System.EventHandler(this.tb_dni_TextChanged);
			// 
			// tb_apellidos
			// 
			this.tb_apellidos.Location = new System.Drawing.Point(96, 88);
			this.tb_apellidos.Name = "tb_apellidos";
			this.tb_apellidos.Size = new System.Drawing.Size(200, 20);
			this.tb_apellidos.TabIndex = 4;
			this.tb_apellidos.Text = "";
			this.tb_apellidos.TextChanged += new System.EventHandler(this.tb_apellidos_TextChanged);
			// 
			// tb_nombre
			// 
			this.tb_nombre.Location = new System.Drawing.Point(96, 48);
			this.tb_nombre.Name = "tb_nombre";
			this.tb_nombre.Size = new System.Drawing.Size(168, 20);
			this.tb_nombre.TabIndex = 3;
			this.tb_nombre.Text = "";
			this.tb_nombre.TextChanged += new System.EventHandler(this.tb_nombre_TextChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Controls.Add(this.splitter1);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(792, 579);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Asignación Grupos";
			this.tabPage2.Visible = false;
			this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btProceder);
			this.groupBox6.Controls.Add(this.rbDesvincular);
			this.groupBox6.Controls.Add(this.rbAsignar);
			this.groupBox6.Controls.Add(this.cbNombreProf);
			this.groupBox6.Location = new System.Drawing.Point(32, 416);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(728, 100);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Asignación de Grupos a Profesores";
			// 
			// btProceder
			// 
			this.btProceder.Location = new System.Drawing.Point(512, 40);
			this.btProceder.Name = "btProceder";
			this.btProceder.Size = new System.Drawing.Size(136, 23);
			this.btProceder.TabIndex = 3;
			this.btProceder.Text = "Proceder";
			this.btProceder.Click += new System.EventHandler(this.btProceder_Click);
			// 
			// rbDesvincular
			// 
			this.rbDesvincular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbDesvincular.Location = new System.Drawing.Point(280, 56);
			this.rbDesvincular.Name = "rbDesvincular";
			this.rbDesvincular.Size = new System.Drawing.Size(192, 16);
			this.rbDesvincular.TabIndex = 2;
			this.rbDesvincular.Text = "Desvincular Grupo Seleccionado";
			this.rbDesvincular.MouseEnter += new System.EventHandler(this.rbDesvincular_MouseEnter);
			this.rbDesvincular.CheckedChanged += new System.EventHandler(this.rbDesvincular_CheckedChanged);
			// 
			// rbAsignar
			// 
			this.rbAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbAsignar.Location = new System.Drawing.Point(280, 32);
			this.rbAsignar.Name = "rbAsignar";
			this.rbAsignar.Size = new System.Drawing.Size(168, 16);
			this.rbAsignar.TabIndex = 1;
			this.rbAsignar.Text = "Asignar Grupo Seleccionado";
			this.rbAsignar.MouseEnter += new System.EventHandler(this.rbAsignar_MouseEnter);
			this.rbAsignar.CheckedChanged += new System.EventHandler(this.rbAsignar_CheckedChanged);
			// 
			// cbNombreProf
			// 
			this.cbNombreProf.Location = new System.Drawing.Point(24, 40);
			this.cbNombreProf.Name = "cbNombreProf";
			this.cbNombreProf.Size = new System.Drawing.Size(200, 21);
			this.cbNombreProf.TabIndex = 0;
			this.cbNombreProf.Text = "Seleccione el Nombre del Profesor";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 579);
			this.splitter1.TabIndex = 6;
			this.splitter1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tabGrupos);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(32, 32);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(728, 360);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Registro de Profesores y Grupos disponibles";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// tabGrupos
			// 
			this.tabGrupos.Controls.Add(this.tabPage1);
			this.tabGrupos.Controls.Add(this.tabPage3);
			this.tabGrupos.Location = new System.Drawing.Point(288, 32);
			this.tabGrupos.Name = "tabGrupos";
			this.tabGrupos.SelectedIndex = 0;
			this.tabGrupos.Size = new System.Drawing.Size(424, 312);
			this.tabGrupos.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGrid2);
			this.tabPage1.Controls.Add(this.dataGrid1);
			this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(416, 286);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Grupos Desvinculados";
			this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
			this.tabPage1.MouseEnter += new System.EventHandler(this.tabPage1_MouseEnter);
			// 
			// dataGrid2
			// 
			this.dataGrid2.CaptionText = "Listado de alumnos disponibles por grupo seleccionado.";
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(16, 143);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.PreferredColumnWidth = 71;
			this.dataGrid2.Size = new System.Drawing.Size(384, 136);
			this.dataGrid2.TabIndex = 6;
			this.dataGrid2.MouseEnter += new System.EventHandler(this.dataGrid2_MouseEnter);
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "Listado de grupos disponibles y desvinculados a un profesor.";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 114;
			this.dataGrid1.RowHeaderWidth = 38;
			this.dataGrid1.Size = new System.Drawing.Size(384, 128);
			this.dataGrid1.TabIndex = 5;
			this.dataGrid1.MouseEnter += new System.EventHandler(this.dataGrid1_MouseEnter);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGrid3);
			this.tabPage3.Controls.Add(this.dataGrid4);
			this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(416, 286);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "Grupos Asociados";
			this.tabPage3.MouseEnter += new System.EventHandler(this.tabPage3_MouseEnter);
			// 
			// dataGrid3
			// 
			this.dataGrid3.CaptionText = "Listado de alumnos disponibles por grupo seleccionado.";
			this.dataGrid3.DataMember = "";
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(16, 143);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.Size = new System.Drawing.Size(384, 136);
			this.dataGrid3.TabIndex = 8;
			this.dataGrid3.MouseEnter += new System.EventHandler(this.dataGrid3_MouseEnter);
			// 
			// dataGrid4
			// 
			this.dataGrid4.CaptionText = "Listado de grupos asociados a un profesor.";
			this.dataGrid4.DataMember = "";
			this.dataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid4.Location = new System.Drawing.Point(16, 8);
			this.dataGrid4.Name = "dataGrid4";
			this.dataGrid4.Size = new System.Drawing.Size(384, 128);
			this.dataGrid4.TabIndex = 7;
			this.dataGrid4.MouseEnter += new System.EventHandler(this.dataGrid4_MouseEnter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.treeView2);
			this.groupBox2.Location = new System.Drawing.Point(16, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 312);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Profesores/Cursos";
			// 
			// treeView2
			// 
			this.treeView2.ImageIndex = -1;
			this.treeView2.Location = new System.Drawing.Point(16, 24);
			this.treeView2.Name = "treeView2";
			this.treeView2.SelectedImageIndex = -1;
			this.treeView2.Size = new System.Drawing.Size(224, 272);
			this.treeView2.TabIndex = 1;
			// 
			// Form4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(914, 605);
			this.Controls.Add(this.tbCuenta2);
			this.Menu = this.mainMenu1;
			this.Name = "Form4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CUENTAS DEL PROFESORADO Y GRUPOS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form4_Load);
			this.Closed += new System.EventHandler(this.Form4_Closed);
			this.tbCuenta2.ResumeLayout(false);
			this.tabp_list_prof.ResumeLayout(false);
			this.btConfirmacion.ResumeLayout(false);
			this.gbEdicion.ResumeLayout(false);
			this.gbDatosProf.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabinfo.ResumeLayout(false);
			this.tabpFijo.ResumeLayout(false);
			this.tabpMovil.ResumeLayout(false);
			this.tabpEmail.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tabGrupos.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form4_Load(object sender, System.EventArgs e)
		{
			P1.Tools.funciones.globalcont=0;
			cont=1;
			this.cbImagen.Checked=true;
			this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
			if(this.pb_fotografia.Image!=null)
			{
				this.cbImagen.Checked=true;
				this.lb_img_no_disp.Visible=false;
				this.ruta_imagen = this.pb_fotografia.Image.ToString();
			}
			else
			{
				this.lb_img_no_disp.Visible=true;
				this.cbImagen.Checked=false;
				this.ruta_imagen="";
			}
			this.treeView1.Nodes.Clear();
			funcion.listado_grupos(cont,this.treeView1);
			this.treeView1.ExpandAll();

			/////////////////////////////////////////////////////////////

			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
					
				Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
				Cmd.Connection = Cnt;
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"CAMPOS_FICHA");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				Cnt.Close();

				this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
				this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
				this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
				this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
				this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
				this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
				this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
			}
			DS.Tables["CAMPOS_FICHA"].Clear();

			/////////////////////////////////////////////////////////////////////////////////////////////////
			///

			
			if((funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)&&(funcion.buscaPASS(this.tb_dni.Text.ToString())!= -1))
			{
				
				this.tb_password.Enabled=false;
				this.cbPassword.Enabled=false;
			}
			else 
			{
				this.tb_password2.Enabled=false;
				this.tb_password.Enabled=true;
				this.cbPassword.Enabled=true;
			}

			///////////////////////////////////////////////////////////////////////
			
			this.treeView2.Nodes.Clear();
			funcion.listado_grupos2(this.treeView2);
			
			this.Cmd.Connection=this.Cnt;
			this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof = 0";
			this.DA.SelectCommand=this.Cmd;
			this.Cnt.Open();
			DA.Fill(this.DS,"dG_ALUM"); 
			this.Cnt.Close();

			this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from g_alum where id_prof=0)";
			this.DA.SelectCommand=this.Cmd;
			Cnt.Open();
			DA.Fill(this.DS,"dALUM"); 
			this.Cnt.Close();

			
			

			///No se puede habilitar esta restricción ya que todos los valores no tienen los valores primarios correspondientes.
			
			this.DS.Relations.Add("Relacion",this.DS.Tables["dG_ALUM"].Columns["id_grupo"],this.DS.Tables["dALUM"].Columns ["id_grupo"]);
			
				
			//this.dataGrid1.DataSource= this.DS.Tables["dG_ALUM"].Columns["nombre,materia,tutoria"];
			this.dataGrid1.DataSource= this.DS;			
			this.dataGrid1.DataMember="dG_ALUM";
			//this.dataGrid2.DataSource= this.DS.Tables["dALUM"].Columns["nombre,apellidos,dni,repetidor"];
			this.dataGrid2.DataSource= this.DS;			
			this.dataGrid2.DataMember="dG_ALUM.Relacion";

			///////////////////////////////////////////////////////////////////////////////////////////////////////////
			
			this.Cmd.Connection=this.Cnt;
			this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof != 0";
			this.DA.SelectCommand=this.Cmd;
			this.Cnt.Open();
			DA.Fill(this.DS,"dG_ALUM2");
			this.Cnt.Close();

			this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from G_ALUM where id_prof!=0)";
			this.DA.SelectCommand=this.Cmd;
			Cnt.Open();
			DA.Fill(this.DS,"dALUM2"); 
			this.Cnt.Close();
			
			///No se puede habilitar esta restricción ya que todos los valores no tienen los valores primarios correspondientes.
			this.DS.Relations.Add("Relacion2",this.DS.Tables["dG_ALUM2"].Columns["ID_GRUPO"],this.DS.Tables["dALUM2"].Columns ["id_grupo"]);
			//this.dataGrid4.DataSource= this.DS.Tables["dG_ALUM2"].Columns["nombre,materia,tutoria"];
			this.dataGrid4.DataSource= this.DS;
			
			this.dataGrid4.DataMember="dG_ALUM2";
			//this.dataGrid3.DataSource= this.DS.Tables["dALUM2"].Columns["nombre,apellidos,dni,repetidor"];
			this.dataGrid3.DataSource= this.DS;
			this.dataGrid3.DataMember="dG_ALUM2.Relacion2";
			

			//////////////////////////////////////////////////////////////////////////////////////////////////////

			
			
		}//Fin FormLoad

		//Deseleccionar todos los checkboxes

		private void btDeselectAll_Click(object sender, System.EventArgs e)
		{
			this.btDeselectAll.Visible = false;
			this.btSelectAll.Visible=true;
			this.cbNombre.Checked = false;
			this.cbApellidos.Checked = false;
			this.cbDNI.Checked = false;
			this.cbFijo.Checked = false;
			this.cbMovil.Checked = false;
			this.cbEmail.Checked = false;
			this.cbPassword.Checked = false;
			this.cbImagen.Checked = false;
		}
		

		private void btSelectAll_Click(object sender, System.EventArgs e)
		{
			this.btSelectAll.Visible = false;
			this.btDeselectAll.Visible=true;
			this.cbNombre.Checked = true;
			this.cbApellidos.Checked = true;
			this.cbDNI.Checked = true;
			this.cbFijo.Checked = true;
			this.cbMovil.Checked = true;
			this.cbEmail.Checked = true;
			this.cbPassword.Checked = true;
			this.btDeselectAll.Visible = true;
			this.btDeselectAll.Visible = true;
			this.cbImagen.Checked=true;
		}

		private void btBorrar_Click(object sender, System.EventArgs e)
		{
			if(this.cbNombre.Checked == true){this.tb_nombre.Text="";}
			if(this.cbApellidos.Checked == true){this.tb_apellidos.Text="";}
			if(this.cbDNI.Checked == true){this.tb_dni.Text="";}
			if(this.cbMovil.Checked == true){this.tbMovil.Text="";}
			if(this.cbFijo.Checked == true){this.tbFijo.Text="";}
			if(this.cbEmail.Checked == true){this.tbEmail.Text="";}
			if(this.cbPassword.Checked == true)
			{
				this.tb_password.Text="";
				this.tb_password.Enabled=true;
				this.cbPassword.Enabled=true;
			}			
			if(this.cbImagen.Checked == true)
			{
				this.pb_fotografia.Image=null;
				this.cbImagen.Checked=false;
			}
			this.treeView1.Nodes.Clear();


		}

		private void btAccion_Click(object sender, System.EventArgs e)
		{
			switch (this.cbAccion.SelectedIndex)
			{
				case -1: MessageBox.Show("Ninguna Acción Seleccionada");
					break;
				case 0: 
					if((this.cbNombre.Checked==false)||(this.cbDNI.Checked==false))
					{
						if((this.cbNombre.Checked==false)&&(this.cbDNI.Checked==false))
						{MessageBox.Show("Los campos NOMBRE y DNI han de ser seleccionados.");}
						else
						{
							if(this.cbNombre.Checked==false)
							{
								MessageBox.Show("El campo NOMBRE no puede estar vacio.");
							}
							else
							{
								MessageBox.Show("El campo DNI no puede estar vacio.");
							}							
							
						}
					}
					else
					{
					
						this.btConfirmacion.Visible=true;
						this.btOK.Visible=true;
						this.btCANCEL.Visible=true;
						this.gbDatosProf.Enabled=false;
						this.gbEdicion.Enabled=false;
						this.lbConfirmaIngreso.Visible=true;
					}
					
						
					break;

				case 1: 

					if(this.cbDNI.Checked==false)
					{
						
						this.lbConfirmaElimina.Text="¿Confirma la eliminación de los datos seleccionados?";
						this.btConfirmacion.Visible=true;
						this.lbConfirmaIngreso.Visible=false;
						this.lbConfirmaElimina.Visible=true;
						this.btOK.Visible=true;
						this.btCANCEL.Visible=true;
						this.gbDatosProf.Enabled=false;
						this.gbEdicion.Enabled=false;
					}
					else
					{
					    this.lbConfirmaElimina.Text="El campo DNI está seleccionado.\nSe eliminarán todos los campos.";
						this.btConfirmacion.Visible=true;
						this.lbConfirmaIngreso.Visible=false;
						this.lbConfirmaElimina.Visible=true;
						this.btOK.Visible=true;
						this.btCANCEL.Visible=true;
						this.gbDatosProf.Enabled=false;
						this.gbEdicion.Enabled=false;
						
					}


					break;
				
				default:
					break;
			}
		}

		private void btOK_Click(object sender, System.EventArgs e)
		{
			


			if(this.cbAccion.SelectedIndex == 1)//Se pidió borrado de los campos
			{
				//Sólo queremos que se borren los marcados, por tanto mostraremos
				//aquellos que se conserven, deseleccionando los que se borrarán (su
				//campo textbox quedará vacio y por tanto sin contenido que será el
				//que se le pase en la función.

				if(this.cbDNI.Checked==true)
				{
					this.tb_nombre.Text="";
					this.tb_apellidos.Text="";
					this.tbFijo.Text="";
					this.tbMovil.Text="";
					this.tbEmail.Text="";
					this.tb_password.Text="";
					this.cbImagen.Checked=false;
					this.tb_dni.Text="";
					this.treeView1.Nodes.Clear();
					this.btSelectAll.Visible=false;
					this.btDeselectAll.Visible=true;
					///////////////////////////////////
					
					this.btConfirmacion.Visible=false;
					this.btOK.Visible=false;
					this.btCANCEL.Visible=false;
					this.lbConfirmaIngreso.Visible=false;
					this.lbConfirmaElimina.Visible=false;
					this.gbEdicion.Enabled=true;
					this.gbDatosProf.Enabled=true;
				
					funcion.update_DB(cont,this.ruta_imagen.ToString(),this.cbImagen.Checked,this.tb_dni.Text.ToString(),this.tb_apellidos.Text.ToString(),this.cbApellidos.Checked,this.tb_nombre.Text.ToString(),this.tbFijo.Text.ToString(),this.cbFijo.Checked,this.tbMovil.Text.ToString(),this.cbMovil.Checked,this.tbEmail.Text.ToString(),this.cbEmail.Checked);



				}
				else
				{
					if(this.cbNombre.Checked == false){this.cbNombre.Checked = true;}
					else{this.cbNombre.Checked = false;}
					if(this.cbApellidos.Checked == false){this.cbApellidos.Checked = true;}
					else{this.cbApellidos.Checked = false;}
					if(this.cbDNI.Checked == false){this.cbDNI.Checked = true;}
					
					if(this.cbFijo.Checked == false){this.cbFijo.Checked = true;}
					else{this.cbFijo.Checked = false;}
					if(this.cbMovil.Checked == false){this.cbMovil.Checked = true;}
					else{this.cbMovil.Checked = false;}
					if(this.cbEmail.Checked == false){this.cbEmail.Checked = true;}
					else{this.cbEmail.Checked = false;}
					if(this.cbPassword.Checked == false){this.cbPassword.Checked = true;}
					else{this.cbPassword.Checked = false;}

					//////////////////////////////////////////
					
					this.btConfirmacion.Visible=false;
					this.btOK.Visible=false;
					this.btCANCEL.Visible=false;
					this.lbConfirmaIngreso.Visible=false;
					this.lbConfirmaElimina.Visible=false;
						this.gbEdicion.Enabled=true;
					this.gbDatosProf.Enabled=true;
					this.btSelectAll.Visible=false;
					this.btDeselectAll.Visible=true;
					
	         	// En caso de ser campos nuevos introducidos por primera vez
				
					funcion.update_DB(funcion.buscaDNI(this.tb_dni.Text.ToString()),this.ruta_imagen.ToString(),this.cbImagen.Checked,this.tb_dni.Text.ToString(),this.tb_apellidos.Text.ToString(),this.cbApellidos.Checked,this.tb_nombre.Text.ToString(),this.tbFijo.Text.ToString(),this.cbFijo.Checked,this.tbMovil.Text.ToString(),this.cbMovil.Checked,this.tbEmail.Text.ToString(),this.cbEmail.Checked);

					////////////////////////////////////////// Actualizamos los campos
					if (Cnt.State == System.Data.ConnectionState.Closed)
					{
						Cnt.ConnectionString = ConnectionString;
						Cnt.Open();
					}
				
				
					try
					{
					
						Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
						Cmd.Connection = Cnt;
						DA.SelectCommand = Cmd;
						DA.Fill(DS,"CAMPOS_FICHA");
						OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
						Cnt.Close();
						
							this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
							this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
							this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
							this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
							this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
							this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
							this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

							////////
							this.cbImagen.Checked=true;
							this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
							if(this.pb_fotografia.Image!=null)
							{
								this.cbImagen.Checked=true;
								this.lb_img_no_disp.Visible=false;
								this.ruta_imagen = this.pb_fotografia.Image.ToString();
							}
							else
							{
								this.lb_img_no_disp.Visible=true;
								this.cbImagen.Checked=false;
								this.ruta_imagen="";
							}
							this.treeView1.Nodes.Clear();
							funcion.listado_grupos(cont,this.treeView1);
							this.treeView1.ExpandAll();
						
					}
					catch(Exception x)
					{
						MessageBox.Show(x.Message.ToString());
					}
				}							
				
			}
			else // Actualiza o crea
			{
				this.btConfirmacion.Visible=false;
				this.btOK.Visible=false;
				this.btCANCEL.Visible=false;
				this.lbConfirmaIngreso.Visible=false;
				this.lbConfirmaElimina.Visible=false;
				this.gbEdicion.Enabled=true;
				this.gbDatosProf.Enabled=true;

				if(funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)//El profesor ya se encontraba registrado.
				{
					//MessageBox.Show("Ya existe un profesor registrado con este DNI.");
					//Se actualizarán los campos del profe ya encontrado.
					
					funcion.update_DB(funcion.buscaDNI(this.tb_dni.Text.ToString()),this.ruta_imagen.ToString(),this.cbImagen.Checked,this.tb_dni.Text.ToString(),this.tb_apellidos.Text.ToString(),this.cbApellidos.Checked,this.tb_nombre.Text.ToString(),this.tbFijo.Text.ToString(),this.cbFijo.Checked,this.tbMovil.Text.ToString(),this.cbMovil.Checked,this.tbEmail.Text.ToString(),this.cbEmail.Checked);
					
					MessageBox.Show("Profesor con DNI "+this.tb_dni.Text.ToString()+" actualizado correctamente.");

					
					//funcion.

				}
				else // El profe no estaba registrado. Se creará uno nuevo en la posición id_prof que
					// haya libre.
				{
					this.btConfirmacion.Visible=false;
					this.btOK.Visible=false;
					this.btCANCEL.Visible=false;
					this.lbConfirmaIngreso.Visible=false;
					this.lbConfirmaElimina.Visible=false;
					this.gbEdicion.Enabled=true;
					this.gbDatosProf.Enabled=true;
                    
					funcion.update_DB(funcion.campovacio(funcion.check_max("PROFESOR")),this.ruta_imagen.ToString(),this.cbImagen.Checked,this.tb_dni.Text.ToString(),this.tb_apellidos.Text.ToString(),this.cbApellidos.Checked,this.tb_nombre.Text.ToString(),this.tbFijo.Text.ToString(),this.cbFijo.Checked,this.tbMovil.Text.ToString(),this.cbMovil.Checked,this.tbEmail.Text.ToString(),this.cbEmail.Checked);
					

				}		



			}
		}

		private void tb_nombre_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tb_nombre.Text!="")
			{
				this.cbNombre.Checked=true;
			}
			else
			{
				this.cbNombre.Checked =false;
			}
		}

		private void tb_apellidos_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tb_apellidos.Text!="")
			{
				this.cbApellidos.Checked=true;
			}
			else
			{
				this.cbApellidos.Checked =false;
			}
		}

		private void tb_dni_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tb_dni.Text!="")
			{
				this.cbDNI.Checked=true;
			}
			else
			{
				this.cbDNI.Checked =false;
			}
		
		}

		private void tbFijo_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tbFijo.Text!="")
			{
				this.cbFijo.Checked=true;
			}
			else
			{
				this.cbFijo.Checked =false;
			}
		
		}

		private void tbMovil_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tbMovil.Text!="")
			{
				this.cbMovil.Checked=true;
			}
			else
			{
				this.cbMovil.Checked =false;
			}
		
		}

		private void tbEmail_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tbEmail.Text!="")
			{
				this.cbEmail.Checked=true;
			}
			else
			{
				this.cbEmail.Checked =false;
			}
		
		}

		private void tb_password_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tb_password.Text!="")
			{
				this.cbPassword.Checked=true;
			}
			else
			{
				this.cbPassword.Checked =false;
			}
		}

		private void btCANCEL_Click(object sender, System.EventArgs e)
		{
			this.btConfirmacion.Visible=false;
			this.btOK.Visible=false;
			this.btCANCEL.Visible=false;
			this.lbConfirmaIngreso.Visible=false;
			this.lbConfirmaElimina.Visible=false;
			this.gbEdicion.Enabled=true;
			this.gbDatosProf.Enabled=true;
		}

		private void pb_fotografia_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.Title = "Abrir";
			openFileDialog1.DefaultExt="JPG";
			openFileDialog1.Filter="Archivos de mapa de bits (*.bmp)|*.bmp|JPEG (*.JPEG)|*.JPEG|GIF (*.GIF)|*.GIF|TIFF (*.TIFF)|*.TIFF|JPG (*.JPG)|*.JPG|Todos los archivos (*.*)|*.*";
			openFileDialog1.ShowDialog();
			try
			{	
				
				if(openFileDialog1.FileName!="")
				{
					this.cbImagen.Checked=true;
					this.lb_img_no_disp.Visible=false;
					this.ruta_imagen = this.openFileDialog1.FileName.ToString();
					this.pb_fotografia.Image = System.Drawing.Image.FromFile(this.ruta_imagen.ToString(),true);
				}
				else
				{

                    this.lb_img_no_disp.Visible=true;
					this.cbImagen.Checked=false;
				}


				 
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());			
			}
			
			
		}

		private void btPrimero_Click(object sender, System.EventArgs e)
		{
			cont=1;
			
			this.btSelectAll.Visible=false;
			this.btDeselectAll.Visible=true;
			this.cbImagen.Checked=false;
			

			/////////////////////////////////////////////////////////////

			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
					
				Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
				Cmd.Connection = Cnt;
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"CAMPOS_FICHA");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				Cnt.Close();
				if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
				{
					this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
					this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
					this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
					this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
					this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
					this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
					this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

					////////
					this.cbImagen.Checked=true;
					this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
					if(this.pb_fotografia.Image!=null)
					{
						this.cbImagen.Checked=true;
						this.lb_img_no_disp.Visible=false;
						this.ruta_imagen = this.pb_fotografia.Image.ToString();
					}
					else
					{
						this.lb_img_no_disp.Visible=true;
						this.cbImagen.Checked=false;
						this.ruta_imagen="";
					}
					this.treeView1.Nodes.Clear();
					funcion.listado_grupos(cont,this.treeView1);
					this.treeView1.ExpandAll();
				}

				else
				{
					cont=funcion.check_max("PROFESOR");
					this.btDeselectAll.Visible = false;
					this.btSelectAll.Visible=true;
					this.cbNombre.Checked = false;
					this.cbApellidos.Checked = false;
					this.cbDNI.Checked = false;
					this.cbFijo.Checked = false;
					this.cbMovil.Checked = false;
					this.cbEmail.Checked = false;
					this.cbPassword.Checked = false;
					this.cbImagen.Checked = false;
					this.tb_nombre.Text="";
					this.tb_apellidos.Text="";
					this.tbFijo.Text="";
					this.tbMovil.Text="";
					this.tbEmail.Text="";
					this.tb_password.Text="";
					this.cbImagen.Checked=false;
					this.tb_dni.Text="";

				}
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
			}
			DS.Tables["CAMPOS_FICHA"].Clear();

			/////////////////////////////////////////////////////////////////////////////////////////////////
			if((funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)&&(funcion.buscaPASS(this.tb_dni.Text.ToString())!= -1))
			{
				
				this.tb_password.Enabled=false;
				this.cbPassword.Enabled=false;
			}
			else 
			{
				this.tb_password2.Enabled=false;
				this.tb_password.Enabled=true;
				this.cbPassword.Enabled=true;
			}
		}

		private void btAnterior_Click(object sender, System.EventArgs e)
		{
			
			this.btSelectAll.Visible=false;
			this.btDeselectAll.Visible=true;
			
			if(this.cont>1)
			{
				this.cbImagen.Checked=false;
				cont--;
				

				/////////////////////////////////////////////////////////////

				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
				
				
				try
				{
					
					Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"CAMPOS_FICHA");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					Cnt.Close();
					if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
					{
						this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
						this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
						this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
						this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
						this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
						this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
						this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

						////////
						this.cbImagen.Checked=true;
						this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
						if(this.pb_fotografia.Image!=null)
						{
							this.cbImagen.Checked=true;
							this.lb_img_no_disp.Visible=false;
							this.ruta_imagen = this.pb_fotografia.Image.ToString();
						}
						else
						{
							this.lb_img_no_disp.Visible=true;
							this.cbImagen.Checked=false;
							this.ruta_imagen="";
						}
						this.treeView1.Nodes.Clear();
						funcion.listado_grupos(cont,this.treeView1);
						this.treeView1.ExpandAll();
					}

					else
					{
						if(funcion.campovacio(funcion.check_max("PROFESOR"))< funcion.check_max("PROFESOR"))
						{
							cont=(funcion.campovacio(funcion.check_max("PROFESOR")))-1;
							DS.Tables["CAMPOS_FICHA"].Clear();
							Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
							Cmd.Connection = Cnt;
							DA.SelectCommand = Cmd;
							DA.Fill(DS,"CAMPOS_FICHA");
							OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
							Cnt.Close();
							if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
							{
								this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
								this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
								this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
								this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
								this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
								this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
								this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

								////////
								this.cbImagen.Checked=true;
								this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
								if(this.pb_fotografia.Image!=null)
								{
									this.cbImagen.Checked=true;
									this.lb_img_no_disp.Visible=false;
									this.ruta_imagen = this.pb_fotografia.Image.ToString();
								}
								else
								{
									this.lb_img_no_disp.Visible=true;
									this.cbImagen.Checked=false;
									this.ruta_imagen="";
								}
								this.treeView1.Nodes.Clear();
								funcion.listado_grupos(cont,this.treeView1);
								this.treeView1.ExpandAll();
							}
						}
						else
						{
							cont=funcion.check_max("PROFESOR");
							this.btDeselectAll.Visible = false;
							this.btSelectAll.Visible=true;
							this.cbNombre.Checked = false;
							this.cbApellidos.Checked = false;
							this.cbDNI.Checked = false;
							this.cbFijo.Checked = false;
							this.cbMovil.Checked = false;
							this.cbEmail.Checked = false;
							this.cbPassword.Checked = false;
							this.cbImagen.Checked = false;
							this.tb_nombre.Text="";
							this.tb_apellidos.Text="";
							this.tbFijo.Text="";
							this.tbMovil.Text="";
							this.tbEmail.Text="";
							this.tb_password.Text="";
							this.cbImagen.Checked=false;
							this.tb_dni.Text="";

						}
					}
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}
				DS.Tables["CAMPOS_FICHA"].Clear();

				/////////////////////////////////////////////////////////////////////////////////////////////////
				
			
				if((funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)&&(funcion.buscaPASS(this.tb_dni.Text.ToString())!= -1))
				{
				
					this.tb_password.Enabled=false;
					this.cbPassword.Enabled=false;
				}
				else 
				{
					this.tb_password2.Enabled=false;
					this.tb_password.Enabled=true;
					this.cbPassword.Enabled=true;
				}
			}
		
		}

		private void btSiguiente_Click(object sender, System.EventArgs e)
		{
			this.btSelectAll.Visible=false;
			this.btDeselectAll.Visible=true;
			
			if(this.cont< funcion.check_max("PROFESOR"))
			{
				this.cbImagen.Checked=false;
				cont++;
				
				/////////////////////////////////////////////////////////////

				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
				
				
				try
				{
					
					Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"CAMPOS_FICHA");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					Cnt.Close();
					if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
					{
						this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
						this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
						this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
						this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
						this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
						this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
						this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

						////////
						this.cbImagen.Checked=true;
						this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
						if(this.pb_fotografia.Image!=null)
						{
							this.cbImagen.Checked=true;
							this.lb_img_no_disp.Visible=false;
							this.ruta_imagen = this.pb_fotografia.Image.ToString();
						}
						else
						{
							this.lb_img_no_disp.Visible=true;
							this.cbImagen.Checked=false;
							this.ruta_imagen="";
						}
						this.treeView1.Nodes.Clear();
						funcion.listado_grupos(cont,this.treeView1);
						this.treeView1.ExpandAll();
					}
					else
					{
						if(funcion.campovacio(funcion.check_max("PROFESOR"))< funcion.check_max("PROFESOR"))
						{
							cont=(funcion.campovacio(funcion.check_max("PROFESOR")))+1;
							DS.Tables["CAMPOS_FICHA"].Clear();
							Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
							Cmd.Connection = Cnt;
							DA.SelectCommand = Cmd;
							DA.Fill(DS,"CAMPOS_FICHA");
							OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
							Cnt.Close();
							if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
							{
								this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
								this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
								this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
								this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
								this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
								this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
								this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

								////////
								this.cbImagen.Checked=true;
								this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
								if(this.pb_fotografia.Image!=null)
								{
									this.cbImagen.Checked=true;
									this.lb_img_no_disp.Visible=false;
									this.ruta_imagen = this.pb_fotografia.Image.ToString();
								}
								else
								{
									this.lb_img_no_disp.Visible=true;
									this.cbImagen.Checked=false;
									this.ruta_imagen="";
								}
								this.treeView1.Nodes.Clear();
								funcion.listado_grupos(cont,this.treeView1);
								this.treeView1.ExpandAll();
							}
						}
						else
						{
							cont=funcion.check_max("PROFESOR");
							this.btDeselectAll.Visible = false;
							this.btSelectAll.Visible=true;
							this.cbNombre.Checked = false;
							this.cbApellidos.Checked = false;
							this.cbDNI.Checked = false;
							this.cbFijo.Checked = false;
							this.cbMovil.Checked = false;
							this.cbEmail.Checked = false;
							this.cbPassword.Checked = false;
							this.cbImagen.Checked = false;
							this.tb_nombre.Text="";
							this.tb_apellidos.Text="";
							this.tbFijo.Text="";
							this.tbMovil.Text="";
							this.tbEmail.Text="";
							this.tb_password.Text="";
							this.cbImagen.Checked=false;
							this.tb_dni.Text="";
							this.treeView1.Nodes.Clear();

						}
					}
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}
				DS.Tables["CAMPOS_FICHA"].Clear();

				/////////////////////////////////////////////////////////////////////////////////////////////////
				
				if((funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)&&(funcion.buscaPASS(this.tb_dni.Text.ToString())!= -1))
				{
				
					this.tb_password.Enabled=false;
					this.cbPassword.Enabled=false;
				}
				else 
				{
					this.tb_password2.Enabled=false;
					this.tb_password.Enabled=true;
					this.cbPassword.Enabled=true;
				}
			}
		}

		private void btUltimo_Click(object sender, System.EventArgs e)
		{
			cont=funcion.check_max("PROFESOR");
			this.btSelectAll.Visible=false;
			this.btDeselectAll.Visible=true;
			this.cbImagen.Checked=false;
		
			
			
			/////////////////////////////////////////////////////////////

			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
					
				Cmd.CommandText = "SELECT NOMBRE,APELLIDOS,DNI,FIJO,MOVIL,EMAIL,PASSWORD FROM PROFESOR WHERE id_prof =" + (cont);
				Cmd.Connection = Cnt;
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"CAMPOS_FICHA");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				Cnt.Close();
				if(DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString()!="")
				{
					this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();
					this.tb_dni.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["DNI"].ToString();
					this.tb_apellidos.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["APELLIDOS"].ToString();
					this.tbFijo.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["FIJO"].ToString();
					this.tbMovil.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["MOVIL"].ToString();
					this.tbEmail.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["EMAIL"].ToString();
					this.tb_password.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["PASSWORD"].ToString();

					////////
					this.cbImagen.Checked=true;
					this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
					if(this.pb_fotografia.Image!=null)
					{
						this.cbImagen.Checked=true;
						this.lb_img_no_disp.Visible=false;
						this.ruta_imagen = this.pb_fotografia.Image.ToString();
					}
					else
					{
						this.lb_img_no_disp.Visible=true;
						this.cbImagen.Checked=false;
						this.ruta_imagen="";
					}
					this.treeView1.Nodes.Clear();
					funcion.listado_grupos(cont,this.treeView1);
					this.treeView1.ExpandAll();
				}
				else
				{
					cont=funcion.check_max("PROFESOR");
					this.btDeselectAll.Visible = false;
					this.btSelectAll.Visible=true;
					this.cbNombre.Checked = false;
					this.cbApellidos.Checked = false;
					this.cbDNI.Checked = false;
					this.cbFijo.Checked = false;
					this.cbMovil.Checked = false;
					this.cbEmail.Checked = false;
					this.cbPassword.Checked = false;
					this.cbImagen.Checked = false;
					this.tb_nombre.Text="";
					this.tb_apellidos.Text="";
					this.tbFijo.Text="";
					this.tbMovil.Text="";
					this.tbEmail.Text="";
					this.tb_password.Text="";
					this.cbImagen.Checked=false;
					this.tb_dni.Text="";
					this.treeView1.Nodes.Clear();

				}
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
			}
			DS.Tables["CAMPOS_FICHA"].Clear();

			/////////////////////////////////////////////////////////////////////////////////////////////////
			
			if((funcion.buscaDNI(this.tb_dni.Text.ToString())!= -1)&&(funcion.buscaPASS(this.tb_dni.Text.ToString())!= -1))
			{
				
				this.tb_password.Enabled=false;
				this.cbPassword.Enabled=false;
			}
			else 
			{
				this.tb_password2.Enabled=false;
				this.tb_password.Enabled=true;
				this.cbPassword.Enabled=true;
			}
		
		}

		

		private void cbImagen_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.cbImagen.Checked==true)
			{
				this.pb_fotografia.Image=funcion.ReadFromDB((cont-1).ToString());
				this.lb_img_no_disp.Visible=false;
								
			}
			else
			{
				this.pb_fotografia.Image=null;
				this.lb_img_no_disp.Visible=true;
			}
		
		}

		private void cbNombre_CheckedChanged(object sender, System.EventArgs e)
		{
			
		}

		private void cbApellidos_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void lb_img_no_disp_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.Title = "Abrir";
			openFileDialog1.DefaultExt="JPG";
			openFileDialog1.Filter="Todos los archivos (*.*)|*.*|Archivos de mapa de bits (*.bmp)|*.bmp|JPEG (*.JPEG)|*.JPEG|GIF (*.GIF)|*.GIF|TIFF (*.TIFF)|*.TIFF|JPG (*.JPG)|*.JPG";
			openFileDialog1.ShowDialog();
			try
			{	
				
				if(openFileDialog1.FileName!="")
				{
					this.cbImagen.Checked=true;
					this.lb_img_no_disp.Visible=false;
					this.ruta_imagen = this.openFileDialog1.FileName.ToString();
					this.pb_fotografia.Image = System.Drawing.Image.FromFile(this.ruta_imagen.ToString(),true);
				}
				else
				{

					this.lb_img_no_disp.Visible=true;
					this.cbImagen.Checked=false;
				}


				 
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());			
			}
		}

		private void groupBox3_Enter(object sender, System.EventArgs e)
		{
		
		}

		

		private void btProceder_Click(object sender, System.EventArgs e)
		{
			
			DataGridCell myCell = new DataGridCell();
			DataGridCell myCell2 = new DataGridCell();
			
			myCell.RowNumber = this.dataGrid1.CurrentCell.RowNumber;
			myCell.ColumnNumber = 0;

			myCell2.RowNumber = this.dataGrid4.CurrentCell.RowNumber;
			myCell2.ColumnNumber = 0;
			//MessageBox.Show(this.dataGrid1[myCell].ToString());

			
			if(this.rbAsignar.Enabled==true)
			{
				try
				{
					if(this.dataGrid1[myCell].ToString()==null)
					{
						MessageBox.Show("Todos los grupos han sido asociados.\nImporte nuevos listados de grupos desde Séneca.");
					}
					else
					{
						if (Cnt.State == System.Data.ConnectionState.Closed)
						{
							Cnt.ConnectionString = ConnectionString;
							Cnt.Open();
						}					
					
						string query1;
						query1="update G_ALUM set id_prof=(select id_prof from PROFESOR where nombre = '"+ this.cbNombreProf.SelectedItem.ToString() + "') where id_grupo ="+this.dataGrid1[myCell];
						Cmd.CommandText = query1;
						Cmd.Connection = Cnt;
						Cmd.ExecuteNonQuery();
						////////////////////////////////////////////////////////////////////////////////////////
						///////////////////////////////////////////////////////////////////////
			
						this.treeView2.Nodes.Clear();
						funcion.listado_grupos2(this.treeView2);
						DS.Tables["dALUM"].Clear();
						DS.Tables["dG_ALUM"].Clear();
						DS.Tables["dALUM2"].Clear();
						DS.Tables["dG_ALUM2"].Clear();
						
						
						

			
						this.Cmd.Connection=this.Cnt;
						this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof = 0";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dG_ALUM"); 
						

						this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from g_alum where id_prof=0)";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dALUM");		
							
						this.dataGrid1.DataSource= this.DS;			
						this.dataGrid1.DataMember="dG_ALUM";
			
						this.dataGrid2.DataSource= this.DS;			
						this.dataGrid2.DataMember="dG_ALUM.Relacion";

						///////////////////////////////////////////////////////////////////////////////////////////////////////////
			
						this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof != 0";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dG_ALUM2");
						

						this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from G_ALUM where id_prof!=0)";
						this.DA.SelectCommand=this.Cmd;
					
						DA.Fill(this.DS,"dALUM2"); 
						this.Cnt.Close();
			
						
						this.dataGrid4.DataSource= this.DS;
			
						this.dataGrid4.DataMember="dG_ALUM2";
						
						this.dataGrid3.DataSource= this.DS;
						this.dataGrid3.DataMember="dG_ALUM2.Relacion2";
			

						////////////////////////////////////////////////////////////////////////////////////////
						////////////////////////////////////////////////////////////////////////////////////////
					}//Fin else anidado			
				}//Fin Try
				catch(Exception x)
				{
					MessageBox.Show(x.Message);
				}
			}
			else 
			{
				try
				{
					if(this.dataGrid4[myCell2].ToString()==null)
					{
						MessageBox.Show("No existen grupos para desvincular.");
					}
				
					else
					{
					
						if (Cnt.State == System.Data.ConnectionState.Closed)
						{
							Cnt.ConnectionString = ConnectionString;
							Cnt.Open();
						}					
					
						string query1;
						query1="update G_ALUM set id_prof=0 where id_grupo="+this.dataGrid4[myCell2];
						Cmd.CommandText = query1;
						Cmd.Connection = Cnt;
						Cmd.ExecuteNonQuery();

						////////////////////////////////////////////////////////////////////////////////////////
						///////////////////////////////////////////////////////////////////////
			
						this.treeView2.Nodes.Clear();
						funcion.listado_grupos2(this.treeView2);
						DS.Tables["dALUM"].Clear();
						DS.Tables["dG_ALUM"].Clear();
						DS.Tables["dALUM2"].Clear();
						DS.Tables["dG_ALUM2"].Clear();
			
						this.Cmd.Connection=this.Cnt;
						this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof = 0";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dG_ALUM"); 
						

						this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from g_alum where id_prof=0)";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dALUM");			
						
						this.dataGrid1.DataSource= this.DS;			
						this.dataGrid1.DataMember="dG_ALUM";
						
						this.dataGrid2.DataSource= this.DS;			
						this.dataGrid2.DataMember="dG_ALUM.Relacion";

						///////////////////////////////////////////////////////////////////////////////////////////////////////////
			
						this.Cmd.CommandText="SELECT id_grupo,nombre,materia,tutoria FROM G_ALUM where id_prof != 0";
						this.DA.SelectCommand=this.Cmd;
						
						DA.Fill(this.DS,"dG_ALUM2");
						

						this.Cmd.CommandText="SELECT id_grupo,nombre,apellidos,dni,repetidor FROM ALUM where id_grupo IN (select id_grupo from G_ALUM where id_prof!=0)";
						this.DA.SelectCommand=this.Cmd;
					
						DA.Fill(this.DS,"dALUM2"); 
						this.Cnt.Close();
			
						
						this.dataGrid4.DataSource= this.DS;
			
						this.dataGrid4.DataMember="dG_ALUM2";
						
						this.dataGrid3.DataSource= this.DS;
						this.dataGrid3.DataMember="dG_ALUM2.Relacion2";
			

						////////////////////////////////////////////////////////////////////////////////////////
						////////////////////////////////////////////////////////////////////////////////////////
							
					
					}
			
					
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message);
				}

			}//Fin else		
	}



		

		private void tabPage1_Enter(object sender, System.EventArgs e)
		{
			this.rbDesvincular.Enabled=false;
			this.rbAsignar.Enabled=true;
		}

		
		private void tabPage1_MouseEnter(object sender, System.EventArgs e)
		{
			this.rbDesvincular.Enabled=false;
			this.rbAsignar.Enabled=true;
			this.rbAsignar.Checked=false;
			this.rbDesvincular.Checked=false;
			this.cbNombreProf.Enabled=true;
		}

		private void tabPage3_MouseEnter(object sender, System.EventArgs e)
		{
			this.rbDesvincular.Enabled=true;
			this.rbAsignar.Enabled=false;
			this.rbAsignar.Checked=false;
			this.rbDesvincular.Checked=false;
			this.cbNombreProf.Enabled=false;
		}

		private void dataGrid3_MouseEnter(object sender, System.EventArgs e)
		{
			this.tabPage3.Cursor=Cursors.Default;
		}

		private void dataGrid4_MouseEnter(object sender, System.EventArgs e)
		{
			this.tabPage3.Cursor=Cursors.Hand;
		}

		private void dataGrid1_MouseEnter(object sender, System.EventArgs e)
		{
			this.tabPage1.Cursor=Cursors.Hand;
		}

		private void dataGrid2_MouseEnter(object sender, System.EventArgs e)
		{
			this.tabPage1.Cursor=Cursors.Default;
		}

		private void rbAsignar_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.rbAsignar.Checked==true)
			{
				this.btProceder.Enabled=true;
			}
			else
			{
				this.btProceder.Enabled=false;
			}
		}

		private void rbDesvincular_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.rbDesvincular.Checked==true)
			{
				this.btProceder.Enabled=true;
			}
			else
			{
				this.btProceder.Enabled=false;
			}
		}

		private void rbDesvincular_MouseEnter(object sender, System.EventArgs e)
		{
			if(this.rbDesvincular.Enabled==false)
			{
				this.rbDesvincular.Cursor=Cursors.Default;
			}
			else
			{
				this.rbDesvincular.Cursor=Cursors.Hand;
			}
		}

		private void rbAsignar_MouseEnter(object sender, System.EventArgs e)
		{
			if(this.rbAsignar.Enabled==false)
			{
				this.rbAsignar.Cursor=Cursors.Default;
			}
			else
			{
				this.rbAsignar.Cursor=Cursors.Hand;
			}
		}

		

		private void tabPage2_Enter(object sender, System.EventArgs e)
		{
			///LLenamos el Combobox que contiene los nombres de profes registrados.
			/////////////////////////////////////////////////////////////////////////////////////////////////////
			
			
			this.cbNombreProf.Items.Clear();   
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}

			try
			{
				string query1;
				query1="select nombre from PROFESOR";
				Cmd.CommandText = query1;
				Cmd.Connection = Cnt;
				Cmd.ExecuteNonQuery();
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"NOMBRES_PROF");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				Cnt.Close();

				//this.tb_nombre.Text = DS.Tables["CAMPOS_FICHA"].Rows[0]["NOMBRE"].ToString();


				DataRow dR=this.DS.Tables["NOMBRES_PROF"].NewRow();				
						
				foreach (DataRow dr in this.DS.Tables["NOMBRES_PROF"].Rows)
				{
					this.cbNombreProf.Items.Add(dr[0]);
				}
				
				
				this.DS.Tables["NOMBRES_PROF"].Clear();
			
			
			}
			catch(Exception x){MessageBox.Show(x.Message);}
			///////////////////////////////////////////////////////////////////////////////////////////////////
		
		}

		private void Form4_Closed(object sender, System.EventArgs e)
		{
			funciones.bandera[21]=1;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();				
			funciones.bandera[21]=1;
		}

		

		

		
		

		

		

		
		
	}
}
