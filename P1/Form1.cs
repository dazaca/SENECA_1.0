using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace P1
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Data.OracleClient.OracleConnection oracleConnection1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
				
		OracleCommand Ocommand= new OracleCommand();
		private P1.dset1 dset11;
		DataSet dset = new DataSet();
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		OracleDataAdapter dataAdapter=new OracleDataAdapter();
		
		

		
		public Form1()
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
				if (components != null) 
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
			this.dset11 = new P1.dset1();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dset11)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(136, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "USUARIOS";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(144, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 152);
			this.button2.Name = "button2";
			this.button2.TabIndex = 8;
			this.button2.Text = "SALIR";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 152);
			this.button1.Name = "button1";
			this.button1.TabIndex = 7;
			this.button1.Text = "VALIDAR";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oracleConnection1
			// 
			this.oracleConnection1.ConnectionString = "user id=admin1;data source=;password=admin1";
			// 
			// dset11
			// 
			this.dset11.DataSetName = "dset1";
			this.dset11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "USUARIO :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "CONTRASEÑA";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(32, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 208);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingreso de contraseña y nombre de usuario";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 262);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VALIDACIÓN DE USUARIO";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Activated += new System.EventHandler(this.Form1_Activated);
			((System.ComponentModel.ISupportInitialize)(this.dset11)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
			
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Hacemos fijo el tamaño de la ventana de confirmación.
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			//Eliminación de imágenes generadas en el directorio de inicio de la aplicación (BIN/DEBUG)
			for(int i=0;i<1000;i++)
			{
				
				if(P1.Tools.funciones.DeleteFile(Application.StartupPath+"\\image"+i.ToString()+".jpg")==false)
				{break;}
				
			}		
			try
			{
				//Captación datos de la tabla config
				this.Ocommand.Connection=this.oracleConnection1;
				this.Ocommand.CommandText="SELECT ADMIN_ID,ADMIN_PASS FROM CONFIG";
				this.dataAdapter.SelectCommand=this.Ocommand;
				this.oracleConnection1.Open();
				this.dataAdapter.Fill(this.dset11,"CONFIG");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(dataAdapter);
 
				//Captación datos de la tabla Profesores
				this.Ocommand.CommandText="SELECT NOMBRE FROM PROFESOR";
				this.dataAdapter.SelectCommand=this.Ocommand;				
				this.dataAdapter.Fill(this.dset,"PFS");
				OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(dataAdapter); //Necesario para el UPDATE
				
				

				DataRow dR2=this.dset.Tables["PFS"].NewRow();
				DataRow dR=this.dset11.Tables["CONFIG"].NewRow();

				this.oracleConnection1.Close();
				/////////////////////////////////////////////////////////
				//Recorremos la tabla CONFIG y PROFESOR  para mostrar en combobox
				//el listado de usuarios actualmente registrados en el 
				//programa.
				foreach (DataRow dr in this.dset11.Tables["CONFIG"].Rows)
				{
					this.comboBox1.Items.Add(dr[0]);
				}
				foreach (DataRow dr in this.dset.Tables["PFS"].Rows)
				{
					this.comboBox1.Items.Add(dr[0]);
				}
				////////////////////////////////////////////////////////
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message);
			}
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Form2 Secundario;
			if((this.dset11.Tables["CONFIG"].Rows[0][1]).ToString()!= this.textBox1.Text)
			{
				MessageBox.Show("Error en la contraseña. Introduzca nueva clave.");
				this.textBox1.Clear(); // Limpiamos el texbox de la contraseña.
				this.textBox1.Focus(); // Situamos el tabulador en el texbox para que
				// el usuario vuelva a pasar aquí la contraseña
				// correcta.
			}
			else
			{				
				Secundario = new Form2();				
				Secundario.ShowDialog();				
			}
			

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Activated(object sender, System.EventArgs e)
		{
						
			/////////////////////////////////////////////////////////
			///Actualizamos el combobox cada vez que se active este
			///formulario para así mostrar correctamente en aquél
			///la lista de USUARIOS actuales que existen
			///registrados en la base de datos.
			//Recorremos la tabla CONFIG para mostrar en combobox
			//el listado de usuarios actualmente registrados en el 
			//programa.Para ello:

			//Actualizamos el dataset...		
			
			this.comboBox1.Items.Clear();
			this.dset11.Tables["CONFIG"].Clear();
			this.dset.Tables["PFS"].Clear();
            
			try
			{
				//Captación datos de la tabla config
				this.Ocommand.Connection=this.oracleConnection1;
				this.Ocommand.CommandText="SELECT ADMIN_ID,ADMIN_PASS FROM CONFIG";
				this.dataAdapter.SelectCommand=this.Ocommand;
				this.oracleConnection1.Open();
				this.dataAdapter.Fill(this.dset11,"CONFIG");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(dataAdapter);
 
				//Captación datos de la tabla Profesores
				this.Ocommand.CommandText="SELECT NOMBRE FROM PROFESOR";
				this.dataAdapter.SelectCommand=this.Ocommand;				
				this.dataAdapter.Fill(this.dset,"PFS");
				OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(dataAdapter); //Necesario para el UPDATE
				
				

				DataRow dR2=this.dset.Tables["PFS"].NewRow();
				DataRow dR=this.dset11.Tables["CONFIG"].NewRow();

				this.oracleConnection1.Close();
				/////////////////////////////////////////////////////////
				//Recorremos la tabla CONFIG y PROFESOR  para mostrar en combobox
				//el listado de usuarios actualmente registrados en el 
				//programa.
				foreach (DataRow dr in this.dset11.Tables["CONFIG"].Rows)
				{
					this.comboBox1.Items.Add(dr[0]);
				}
				foreach (DataRow dr in this.dset.Tables["PFS"].Rows)
				{
					this.comboBox1.Items.Add(dr[0]);
				}
				////////////////////////////////////////////////////////
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message);
			}
			
			
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		

		
	}
}
