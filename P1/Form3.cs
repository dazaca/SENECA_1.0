using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using P1.Tools;


namespace P1
{
	/// <summary>
	/// Descripción breve de Form3.
	/// </summary>
	/// 
	///

	
	public class Form3 : System.Windows.Forms.Form
	{
		
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.TabControl tbCuenta1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		
		private P1.dset1 dset11;
		
		
		private System.Data.OracleClient.OracleConnection oracleConnection1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		OracleCommand Ocommand= new OracleCommand();
		private System.Windows.Forms.TextBox ID;
		private System.Windows.Forms.TextBox PASS;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button BValidar;
		private System.Windows.Forms.CheckBox CBconfirmar1;
		private System.Windows.Forms.CheckBox CBconfirmar2;
		public System.Windows.Forms.TextBox NewPass;
		public System.Windows.Forms.TextBox NewNom;
		private System.Windows.Forms.CheckBox CBconfirmar3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox CBNewDepart;
		private System.Windows.Forms.Label Ldepart;
		private System.Windows.Forms.TextBox PASS2;
		private System.Windows.Forms.Button Mostrar;
		private System.Windows.Forms.Button Ocultar;
		public System.Windows.Forms.TextBox NewPASSconfirmado;
		
		
		private System.Windows.Forms.Button BDescartar;
		OracleDataAdapter dataAdapter=new OracleDataAdapter();
		P1.Tools.funciones funcion = new  funciones();
		
		
					
		public Form3() 
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
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.tbCuenta1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Ocultar = new System.Windows.Forms.Button();
			this.Mostrar = new System.Windows.Forms.Button();
			this.PASS2 = new System.Windows.Forms.TextBox();
			this.Ldepart = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.TextBox();
			this.PASS = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.NewPASSconfirmado = new System.Windows.Forms.TextBox();
			this.CBNewDepart = new System.Windows.Forms.ComboBox();
			this.CBconfirmar3 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CBconfirmar2 = new System.Windows.Forms.CheckBox();
			this.CBconfirmar1 = new System.Windows.Forms.CheckBox();
			this.BDescartar = new System.Windows.Forms.Button();
			this.BValidar = new System.Windows.Forms.Button();
			this.NewNom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NewPass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dset11 = new P1.dset1();
			this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
			this.tbCuenta1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dset11)).BeginInit();
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
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuItem1.Text = "Menú";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.MergeOrder = 11;
			this.menuItem4.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.menuItem4.Text = "3---------";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MergeOrder = 18;
			this.menuItem5.Text = "Cerrar ";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click_1);
			// 
			// tbCuenta1
			// 
			this.tbCuenta1.Controls.Add(this.tabPage1);
			this.tbCuenta1.Controls.Add(this.tabPage2);
			this.tbCuenta1.Dock = System.Windows.Forms.DockStyle.Right;
			this.tbCuenta1.Location = new System.Drawing.Point(114, 0);
			this.tbCuenta1.Name = "tbCuenta1";
			this.tbCuenta1.SelectedIndex = 0;
			this.tbCuenta1.Size = new System.Drawing.Size(800, 584);
			this.tbCuenta1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(792, 558);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Nombre/Contraseña";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(176, 352);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(472, 128);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Acciones   ";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(280, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Borrar Datos Actuales";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(72, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Modificar Datos Cuenta";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Ocultar);
			this.groupBox1.Controls.Add(this.Mostrar);
			this.groupBox1.Controls.Add(this.PASS2);
			this.groupBox1.Controls.Add(this.Ldepart);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ID);
			this.groupBox1.Controls.Add(this.PASS);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(176, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 248);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos de la cuenta del Administrador";
			// 
			// Ocultar
			// 
			this.Ocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Ocultar.Location = new System.Drawing.Point(336, 120);
			this.Ocultar.Name = "Ocultar";
			this.Ocultar.TabIndex = 3;
			this.Ocultar.Text = "Ocultar";
			this.Ocultar.Visible = false;
			this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
			// 
			// Mostrar
			// 
			this.Mostrar.Location = new System.Drawing.Point(336, 120);
			this.Mostrar.Name = "Mostrar";
			this.Mostrar.TabIndex = 6;
			this.Mostrar.Text = "Mostar";
			this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
			// 
			// PASS2
			// 
			this.PASS2.BackColor = System.Drawing.Color.White;
			this.PASS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.PASS2.Location = new System.Drawing.Point(80, 120);
			this.PASS2.Name = "PASS2";
			this.PASS2.ReadOnly = true;
			this.PASS2.Size = new System.Drawing.Size(216, 21);
			this.PASS2.TabIndex = 2;
			this.PASS2.Text = "";
			this.PASS2.Visible = false;
			// 
			// Ldepart
			// 
			this.Ldepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Ldepart.Location = new System.Drawing.Point(56, 176);
			this.Ldepart.Name = "Ldepart";
			this.Ldepart.Size = new System.Drawing.Size(352, 23);
			this.Ldepart.TabIndex = 5;
			this.Ldepart.Text = "Departamento de ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = " Nombre del Administrador";
			// 
			// ID
			// 
			this.ID.BackColor = System.Drawing.Color.White;
			this.ID.Location = new System.Drawing.Point(80, 56);
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Size = new System.Drawing.Size(120, 20);
			this.ID.TabIndex = 1;
			this.ID.Text = "";
			// 
			// PASS
			// 
			this.PASS.BackColor = System.Drawing.Color.White;
			this.PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.PASS.Location = new System.Drawing.Point(80, 120);
			this.PASS.Name = "PASS";
			this.PASS.PasswordChar = '*';
			this.PASS.ReadOnly = true;
			this.PASS.Size = new System.Drawing.Size(216, 21);
			this.PASS.TabIndex = 3;
			this.PASS.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = " Contraseña del Administrador :";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitter1);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(792, 558);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Modificar";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 558);
			this.splitter1.TabIndex = 6;
			this.splitter1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.NewPASSconfirmado);
			this.groupBox3.Controls.Add(this.CBNewDepart);
			this.groupBox3.Controls.Add(this.CBconfirmar3);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.CBconfirmar2);
			this.groupBox3.Controls.Add(this.CBconfirmar1);
			this.groupBox3.Controls.Add(this.BDescartar);
			this.groupBox3.Controls.Add(this.BValidar);
			this.groupBox3.Controls.Add(this.NewNom);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.NewPass);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(136, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(568, 440);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "   Modificación datos del Administrador";
			// 
			// NewPASSconfirmado
			// 
			this.NewPASSconfirmado.BackColor = System.Drawing.Color.White;
			this.NewPASSconfirmado.Location = new System.Drawing.Point(72, 192);
			this.NewPASSconfirmado.Name = "NewPASSconfirmado";
			this.NewPASSconfirmado.PasswordChar = '*';
			this.NewPASSconfirmado.Size = new System.Drawing.Size(96, 20);
			this.NewPASSconfirmado.TabIndex = 8;
			this.NewPASSconfirmado.Text = "";
			this.NewPASSconfirmado.Visible = false;
			// 
			// CBNewDepart
			// 
			this.CBNewDepart.Items.AddRange(new object[] {
															 "Tecnología",
															 "Filosofía",
															 "Biología",
															 "Matemáticas",
															 "Geografía e Historia",
															 "Física y Química",
															 "Música",
															 "Lengua y Literatura",
															 "Plástica"});
			this.CBNewDepart.Location = new System.Drawing.Point(72, 272);
			this.CBNewDepart.Name = "CBNewDepart";
			this.CBNewDepart.Size = new System.Drawing.Size(121, 21);
			this.CBNewDepart.TabIndex = 10;
			this.CBNewDepart.Text = "Departamento";
			// 
			// CBconfirmar3
			// 
			this.CBconfirmar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CBconfirmar3.Location = new System.Drawing.Point(224, 272);
			this.CBconfirmar3.Name = "CBconfirmar3";
			this.CBconfirmar3.Size = new System.Drawing.Size(80, 24);
			this.CBconfirmar3.TabIndex = 11;
			this.CBconfirmar3.Text = "Confirmar";
			this.CBconfirmar3.CheckedChanged += new System.EventHandler(this.CBconfirmar3_CheckedChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(64, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Nuevo NOMBRE del Departamento :";
			// 
			// CBconfirmar2
			// 
			this.CBconfirmar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CBconfirmar2.Location = new System.Drawing.Point(224, 192);
			this.CBconfirmar2.Name = "CBconfirmar2";
			this.CBconfirmar2.Size = new System.Drawing.Size(80, 24);
			this.CBconfirmar2.TabIndex = 9;
			this.CBconfirmar2.Text = "Confirmar";
			this.CBconfirmar2.CheckedChanged += new System.EventHandler(this.CBconfirmar2_CheckedChanged);
			// 
			// CBconfirmar1
			// 
			this.CBconfirmar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CBconfirmar1.Location = new System.Drawing.Point(224, 120);
			this.CBconfirmar1.Name = "CBconfirmar1";
			this.CBconfirmar1.Size = new System.Drawing.Size(80, 24);
			this.CBconfirmar1.TabIndex = 7;
			this.CBconfirmar1.Text = "Confirmar";
			this.CBconfirmar1.CheckedChanged += new System.EventHandler(this.CBconfirmar1_CheckedChanged);
			// 
			// BDescartar
			// 
			this.BDescartar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.BDescartar.Location = new System.Drawing.Point(328, 360);
			this.BDescartar.Name = "BDescartar";
			this.BDescartar.Size = new System.Drawing.Size(128, 23);
			this.BDescartar.TabIndex = 13;
			this.BDescartar.Text = "Descartar";
			this.BDescartar.Click += new System.EventHandler(this.BDescartar_Click);
			// 
			// BValidar
			// 
			this.BValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.BValidar.Location = new System.Drawing.Point(88, 360);
			this.BValidar.Name = "BValidar";
			this.BValidar.Size = new System.Drawing.Size(128, 23);
			this.BValidar.TabIndex = 12;
			this.BValidar.Text = "Validar Cambios";
			this.BValidar.Click += new System.EventHandler(this.BValidar_Click);
			// 
			// NewNom
			// 
			this.NewNom.BackColor = System.Drawing.Color.White;
			this.NewNom.Location = new System.Drawing.Point(72, 120);
			this.NewNom.Name = "NewNom";
			this.NewNom.Size = new System.Drawing.Size(128, 20);
			this.NewNom.TabIndex = 6;
			this.NewNom.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(64, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(216, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nueva CONTRASEÑA del Administrador :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(48, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(472, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Modifique desde aquí el NOMBRE, CONTRASEÑA y DEPARTAMENTO del Administrador :";
			// 
			// NewPass
			// 
			this.NewPass.BackColor = System.Drawing.Color.White;
			this.NewPass.Location = new System.Drawing.Point(72, 192);
			this.NewPass.Name = "NewPass";
			this.NewPass.Size = new System.Drawing.Size(96, 20);
			this.NewPass.TabIndex = 8;
			this.NewPass.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(184, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nuevo NOMBRE de Administrador :";
			// 
			// dset11
			// 
			this.dset11.DataSetName = "dset1";
			this.dset11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// oracleConnection1
			// 
			this.oracleConnection1.ConnectionString = "user id=admin1;data source=;password=admin1";
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(914, 584);
			this.Controls.Add(this.tbCuenta1);
			this.Menu = this.mainMenu1;
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CUENTAS DEL ADMINISTRADOR";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form3_Load);
			this.Closed += new System.EventHandler(this.Form3_Closed);
			this.tbCuenta1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dset11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void menuItem5_Click_1(object sender, System.EventArgs e)
		{
			this.Close();				
			funciones.bandera[20]=1;
			
		}	

		private void Form3_Load(object sender, System.EventArgs e)
		{
			funciones.bandera[20]=0;
			funciones.bandera[21]=0;
			try
			{
				this.Ocommand.Connection=this.oracleConnection1;
				this.Ocommand.CommandText="SELECT ADMIN_ID,ADMIN_PASS,DEPT_NOMBRE FROM CONFIG";
				this.dataAdapter.SelectCommand=this.Ocommand;
				this.oracleConnection1.Open();
				this.dataAdapter.Fill(this.dset11,"CONFIG");//Trae los datos de la BD y los
				//lleva al dataSet almacenando los
				//datos de la consulta en una tabla del
				//dataSet con nombre "CONFIG". Lo mismo
				//haremos con el UPDATE.

				OracleCommandBuilder objBuilder = new OracleCommandBuilder(dataAdapter); //Necesario para el UPDATE
				this.oracleConnection1.Close();
				DataRow dR=this.dset11.Tables["CONFIG"].NewRow();
				this.ID.Text=this.dset11.Tables["CONFIG"].Rows[0][0].ToString();
				this.PASS.Text=this.dset11.Tables["CONFIG"].Rows[0][1].ToString();
				this.PASS2.Text=this.dset11.Tables["CONFIG"].Rows[0][1].ToString();
				if(this.dset11.Tables["CONFIG"].Rows[0][2].ToString()=="")
				{
					this.Ldepart.Text+="(sin especificar)";
				}
				else{
					this.Ldepart.Text+=this.dset11.Tables["CONFIG"].Rows[0][2].ToString();
				
				}
				

			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message);
			}
		}

		private void Ocultar_Click(object sender, System.EventArgs e)
		{
			this.PASS.Visible = true;
			this.PASS2.Visible = false;
			this.Ocultar.Visible = false;
			this.Mostrar.Visible = true;
		}

		private void Mostrar_Click(object sender, System.EventArgs e)
		{
			this.PASS.Visible = false;
			this.PASS2.Visible = true;
			this.Ocultar.Visible = true;
			this.Mostrar.Visible = false;
		}

		private void CBconfirmar1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.CBconfirmar1.Checked==true)
			{
				this.NewNom.BackColor= System.Drawing.Color.LightGray;
				this.NewNom.Enabled = false;
			}
			else{
				this.NewNom.BackColor= System.Drawing.Color.White;
				this.NewNom.Enabled = true;
			}
		}

		private void CBconfirmar2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.CBconfirmar2.Checked==true)
			{
				this.NewPass.Visible = false;
				this.NewPASSconfirmado.Text = this.NewPass.Text;
				this.NewPASSconfirmado.Visible = true;
				this.NewPASSconfirmado.BackColor= System.Drawing.Color.LightGray;
				this.NewPASSconfirmado.Enabled = false;
			}
			else
			{
				this.NewPASSconfirmado.BackColor = System.Drawing.Color.White;
				this.NewPASSconfirmado.Visible = false;
				this.NewPass.Visible = true;
				this.NewPass.Text = "";
				this.NewPass.Focus();
			}
		}

		private void CBconfirmar3_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((this.CBNewDepart.SelectedItem == null)&&(this.CBconfirmar3.Checked==true))
			{
				MessageBox.Show("Seleccione un departamento.");
				this.CBconfirmar3.Checked = false;
				this.CBNewDepart.Focus();
			}
			else if(this.CBconfirmar3.Checked==true) 
			{
				this.CBNewDepart.BackColor= System.Drawing.Color.LightGray;
				this.CBNewDepart.Enabled = false;
			}
			else 
			{
				this.CBNewDepart.BackColor= System.Drawing.Color.White;
				this.CBNewDepart.Enabled = true;
			}
		
		}

		private void BValidar_Click(object sender, System.EventArgs e)
		{
			
			OKCANCEL confirmacion;
			confirmacion = new OKCANCEL();
			try
			{
				//Si los checkboxes de confirmación no se marcaron...
				if((this.CBconfirmar1.Checked == false)&&(this.CBconfirmar2.Checked == false)&&(this.CBconfirmar3.Checked == false))
				{
					//...y si además se intentó modificar algún campo...
					try
					{
						if((this.NewNom.Text.ToString()!= "")||(this.NewPass.Text.ToString()!= "")||(this.CBNewDepart.SelectedIndex.ToString() != "-1"))
						{
					
							MessageBox.Show("Confirme los campos a modificar.");
						}
				
							//...y no se rellenó ningún campo a modificar..
						else
						{
							MessageBox.Show("No existen campos seleccionados para modificar.");
						
						}
						
					}
					catch(Exception x)
					{
						MessageBox.Show(x.Message.ToString());
					}		
					
				}

					// Si existe algún campo de datos relleno y además posee su casilla de confirmación activada...
				else if (((this.NewNom.Text.ToString()!= "")&&(this.CBconfirmar1.Checked == true))||((this.NewPass.Text.ToString()!= "")&&(this.CBconfirmar2.Checked == true))||((this.CBNewDepart.SelectedIndex.ToString() != "-1")&&(this.CBconfirmar3.Checked == true)))
				{
	
					// Mostraremos una ventana de aviso de confirmación:
		      
				
					confirmacion.ShowDialog();
				

					// Según se marque OK o CANCEL en dicha ventana de confirmación...
					switch(confirmacion.DialogResult.ToString())
					{
						case "OK":

							if((this.CBconfirmar1.Checked == true)&&(this.CBconfirmar2.Checked == true)&&(this.CBconfirmar3.Checked == true))
							{
								// Si se confirma el ingreso de un nombre,una contraseña y un departamento nuevos, se consultan
								// los valores actuales en el dataset de los mismos para actualizarlos.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
								dR["ADMIN_PASS"]=this.NewPass.Text;
								dR["ADMIN_ID"]=this.NewNom.Text;
								dR["DEPT_NOMBRE"]=this.CBNewDepart.SelectedItem;
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la
								// ficha donde se muestra la información de la
								// cuenta del administrador:
								this.ID.Text = this.NewNom.Text;
								this.PASS.Text = this.NewPass.Text;
								this.PASS2.Text = this.NewPass.Text;
								this.Ldepart.Text = "Departamento de " + this.CBNewDepart.SelectedItem.ToString();
								break;
							}

							else if((this.CBconfirmar1.Checked == true)&&(this.CBconfirmar2.Checked == true))
							{
								// Si se confirma el ingreso de un nombre y una contraseña, se consultan
								// los valores actuales en el dataset de los mismos para actualizarlos.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
								dR["ADMIN_PASS"]=this.NewPass.Text;
								dR["ADMIN_ID"]=this.NewNom.Text;
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la
								// ficha donde se muestra la información de la
								// cuenta del administrador:
								this.ID.Text = this.NewNom.Text;
								this.PASS.Text = this.NewPass.Text;
								this.PASS2.Text = this.NewPass.Text;
												
								break;
							}

							else if((this.CBconfirmar1.Checked == true)&&(this.CBconfirmar3.Checked == true))
							{
								// Si se confirma el ingreso de un nombre y un departamento nuevos, se consultan
								// los valores actuales en el dataset de los mismos para actualizarlos.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
								dR["ADMIN_ID"]=this.NewNom.Text;
								dR["DEPT_NOMBRE"]=this.CBNewDepart.SelectedItem;
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la
								// ficha donde se muestra la información de la
								// cuenta del administrador:
								this.ID.Text = this.NewNom.Text;
								this.Ldepart.Text = "Departamento de " + this.CBNewDepart.SelectedItem.ToString();
						
								break;
							}

							else if((this.CBconfirmar2.Checked == true)&&(this.CBconfirmar3.Checked == true))
							{
								// Si se confirma el ingreso de una contraseña y un departamento nuevos, se consultan
								// los valores actuales en el dataset de los mismos para actualizarlos.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
								dR["ADMIN_PASS"]=this.NewPass.Text;
								dR["DEPT_NOMBRE"]=this.CBNewDepart.SelectedItem;
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la 
								// ficha donde se muestra la información de la
								// cuenta del administrador:
								this.PASS.Text = this.NewPass.Text;
								this.PASS2.Text = this.NewPass.Text;
								this.Ldepart.Text = "Departamento de " + this.CBNewDepart.SelectedItem.ToString();
								break;					
							}

							else if(this.CBconfirmar1.Checked == true)
							{
								// Si únicamente se confirma el ingreso de un nombre, se consulta
								// el valor actual en el dataset del mismo para actualizarlo.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
								dR["ADMIN_ID"]=this.NewNom.Text;
						
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la 
								// ficha donde se muestra la información de la
								// cuenta del administrador:
								this.ID.Text = this.NewNom.Text;
						
						
								break;
							}

							else if(this.CBconfirmar2.Checked == true)
							{
								try
								{
									// Si únicamente se confirma el ingreso de una contraseña, se consulta
									// el valores actual en el dataset de la misma para actualizarla.
						
											
									DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
									dR["ADMIN_PASS"]=this.NewPass.Text;
									dataAdapter.Update(this.dset11,"CONFIG");						
									// Tras actualizar el dataset, haremos lo mismo en
									// la ficha donde se muestra la información de la
									// cuenta del administrador:
									this.PASS.Text = this.NewPass.Text;
									this.PASS2.Text = this.NewPass.Text;
									this.Ldepart.Text = "Departamento de " + this.CBNewDepart.SelectedItem.ToString();
									break;	
								}
								catch(Exception x)
								{
									MessageBox.Show(x.Message.ToString());
								}
							}

							else if(this.CBconfirmar3.Checked == true)
							{
								// Si únicamente se confirma el ingreso de un departamento nuevo, se consulta
								// el valor actual en el dataset del mismo para actualizarlo.
						
											
								DataRow dR=this.dset11.Tables["CONFIG"].Rows[0];
						
						
								dR["DEPT_NOMBRE"]=this.CBNewDepart.SelectedItem;
								dataAdapter.Update(this.dset11,"CONFIG");						
								// Tras actualizar el dataset, haremos lo mismo con la
								// ficha donde se muestra la información de la
								// cuenta del administrador:
						
								this.Ldepart.Text = "Departamento de " + this.CBNewDepart.SelectedItem.ToString();
						
								break;
							}



							break;
									
						case "Cancel":

							//En caso de no confirmarse los cambios haremos que los texbox vuelvan a sus estados iniciales:
							this.CBconfirmar1.Checked = false;
							this.CBconfirmar2.Checked = false;
							this.CBconfirmar3.Checked = false;
							this.NewNom.Focus();
							this.NewNom.BackColor = System.Drawing.Color.White;
							this.NewNom.Text = "";
							this.NewPass.BackColor = System.Drawing.Color.White;
							this.NewPass.Text = "";
							this.CBNewDepart.BackColor = System.Drawing.Color.White;
							this.CBNewDepart.Text = "Departamento";
							break;
						default :
							break;
			
					}//Fin SWITCH_CASE
				}//Fin ELSE IF principal

					// Si se marcó un checkbox pero no se especificó contenido...
				else
				{
					MessageBox.Show("No existen datos que modificar");
					// Y desmarcamos todos los checkboxes:
					this.CBconfirmar1.Checked = false;
					this.CBconfirmar2.Checked = false;
					this.CBconfirmar3.Checked = false;
				
				}
			}//Fin Try		

			catch(Exception excepcion)
			{
				MessageBox.Show(excepcion.Message.ToString());
			}
						

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.tbCuenta1.SelectedTab = tabPage2;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			// EVENTO CLICK DEL BOTÓN DE BORRADO DE LOS DATOS DEL ADMINISTRADOR
			// Se eliminan los campos actualmente visibles de NOMBRE,CONTRASEÑA y NOMBRE DEL DEPARTAMENTO:
			this.ID.Text = "";
			this.PASS.Text = "";
			this.PASS2.Text = "";
			this.Ldepart.Text= "Departamento de ";
			MessageBox.Show("Por favor, ingrese los nuevos datos del Administrador.");
			this.tbCuenta1.SelectedTab = tabPage2;
			// Se avisa al usuario de la obligatoriedad de rellenar los nuevos
			// campos eliminados.
			
			
			

		}

		private void BDescartar_Click(object sender, System.EventArgs e)
		{
			this.NewNom.Enabled=true;
			this.NewNom.Text="";
			this.NewPASSconfirmado.Enabled=true;
			this.NewPASSconfirmado.Text="";
			this.CBNewDepart.Enabled=true;
			this.CBNewDepart.Text="Departamento";
			this.CBconfirmar1.Enabled=true;
			this.CBconfirmar2.Enabled=true;
			this.CBconfirmar3.Enabled=true;
			this.CBconfirmar1.Checked=false;
			this.CBconfirmar2.Checked=false;
			this.CBconfirmar3.Checked=false;
		}

		private void Form3_Closed(object sender, System.EventArgs e)
		{
			//Al cierre de este formulario se activan las banderas para habilitar los submenuses.
			funciones.bandera[20]=1;
			

		}

		

		
		
		

		

		

		

		

		
	}
}
