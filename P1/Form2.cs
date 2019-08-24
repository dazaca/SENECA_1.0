using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using P1.Tools;


namespace P1
{
	/// <summary>
	/// Descripción breve de Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		

		public Form2()
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
		//Constantes para capturar clicks sobre la ventana
		private const int WM_NCHITTEST = 0x84;
		private const int HTCAPTION = 2;
		private const int HTCLIENT = 1;
		//Constantes para detectar el cambio de tamaño
		private const int WM_SYSCOMMAND = 0x112;
		private const int SC_SIZE = 0xF000;
		
		//Constantes para detectar el cierre de ventana
		private const int SC_CLOSE = 0xF060;
		//private const int WM_SYSCOMMAND = 0x0112; 
		
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		public System.Windows.Forms.MenuItem menuItem4;
		public System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		P1.Tools.funciones funcion = new  funciones();
		protected override void WndProc(ref System.Windows.Forms.Message m)
		{

			if (m.Msg == WM_SYSCOMMAND && (((int) m.WParam) & 0xFFF0) ==  SC_SIZE)
			{
				m.Result = new System.IntPtr(0);
				return;
			}

			// Salvo casos extremos SIEMPRE se debe permitir que el método base procese el mensaje
			base.WndProc(ref m);

			// Si el mensaje es de detección de clic y se está pulsando sobre el área cliente de la ventana
			//cambiamos el mensaje para que se piense que estamos pulsando sobre la barra de títulos 
			//y por lo tanto moverá la ventana
			if (m.Msg == WM_NCHITTEST && m.Result.ToInt32() == HTCLIENT)
			{
				m.Result = new IntPtr(HTCAPTION);
			}
			try
			{
				if(m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE){
				//Form1.ActiveForm.Close();/*Form1.ActiveForm.BringToFront();/*Form1.ActiveForm.Focus();*/
					//Form1.ActiveForm.Show();
				} 
			}
			catch(Exception x){
			MessageBox.Show(x.Message.ToString());
			}
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
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem11,
																					  this.menuItem9});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem8,
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuItem1.Text = "Menú";
			this.menuItem1.Select += new System.EventHandler(this.menuItem1_Select);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem2.Text = "Cuentas";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "Administrador";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "Profesores";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem15,
																					  this.menuItem16,
																					  this.menuItem17});
			this.menuItem3.MergeOrder = 10;
			this.menuItem3.Text = "Informes";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.Text = "Reuniones de Departamento";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Text = "Reuniones ETCP";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.Text = "Presupuestos";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.MergeOrder = 19;
			this.menuItem8.Text = "-";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.MergeOrder = 20;
			this.menuItem6.Text = "Cambiar Usuario";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.MergeOrder = 30;
			this.menuItem7.Text = "Salir";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "Ayuda";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem12,
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem9.Text = "Ventana";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "Cascada";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "Horizontal";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "Vertical";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.Text = "Arrange";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(914, 584);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SÉNECA 1.0 ";

		}
		#endregion

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Form3 f3;
			
				f3 = new Form3();
				f3.MdiParent=this; // Hace que el formulario aparezca dentro del marco del formulario Padre
				f3.Text="CUENTA ADMINISTRADOR";
				this.menuItem4.Text = "Administrador (Activado)";
				this.menuItem4.Enabled = false;				
				f3.Show();
			
			
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Close();			
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.Close();			
		}

		

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Form4 f4;
			
			
			f4 = new Form4();
			f4.MdiParent=this; // Hace que el formulario aparezca dentro del marco del formulario Padre
			f4.Text="CUENTAS DE PROFESORES";
			this.menuItem5.Text = "Profesores (Activado)";
			this.menuItem5.Enabled = false;
			f4.Show();
		}		

		private void menuItem1_Select(object sender, System.EventArgs e)
		{
			
			if(funciones.bandera[20]==1)
			{
				this.menuItem4.Text = "Administrador";
				this.menuItem4.Enabled = true;
			}
			if(funciones.bandera[21]==1)
			{
				this.menuItem5.Text = "Profesores";
				this.menuItem5.Enabled = true;

			}

			if(funciones.bandera[30]==1)
			{
				this.menuItem15.Text = "Reuniones de Departamento";
				this.menuItem15.Enabled = true;
			}

		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons); //PARA ORGANIZAR ICONOS
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			Form5 f5;
			
			f5 = new Form5();
			f5.MdiParent=this; // Hace que el formulario aparezca dentro del marco del formulario Padre
			f5.Text="INFORMES";
			this.menuItem15.Text = "Reuniones de Departamento(Activado)";
			this.menuItem15.Enabled = false;
				
				
			f5.Show();
		}

		


		
	}
}
