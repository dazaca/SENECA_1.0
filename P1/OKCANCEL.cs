using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace P1
{
	/// <summary>
	/// Descripción breve de OKCANCEL.
	/// </summary>
	public class OKCANCEL : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Label Lmodifdat;
		private System.Windows.Forms.Button Bcancelar;
		private System.Windows.Forms.Button Baceptar;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OKCANCEL()
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
			this.Bcancelar = new System.Windows.Forms.Button();
			this.Baceptar = new System.Windows.Forms.Button();
			this.Lmodifdat = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Bcancelar
			// 
			this.Bcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Bcancelar.Location = new System.Drawing.Point(160, 80);
			this.Bcancelar.Name = "Bcancelar";
			this.Bcancelar.Size = new System.Drawing.Size(72, 24);
			this.Bcancelar.TabIndex = 3;
			this.Bcancelar.Text = "CANCEL";
			this.Bcancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// Baceptar
			// 
			this.Baceptar.Location = new System.Drawing.Point(72, 80);
			this.Baceptar.Name = "Baceptar";
			this.Baceptar.Size = new System.Drawing.Size(72, 24);
			this.Baceptar.TabIndex = 2;
			this.Baceptar.Text = "OK";
			this.Baceptar.Click += new System.EventHandler(this.button1_Click);
			// 
			// Lmodifdat
			// 
			this.Lmodifdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Lmodifdat.Location = new System.Drawing.Point(80, 32);
			this.Lmodifdat.Name = "Lmodifdat";
			this.Lmodifdat.Size = new System.Drawing.Size(152, 16);
			this.Lmodifdat.TabIndex = 4;
			this.Lmodifdat.Text = "¿Desea validar los cambios?";
			this.Lmodifdat.Click += new System.EventHandler(this.Lmodifdat_Click);
			// 
			// OKCANCEL
			// 
			this.AcceptButton = this.Baceptar;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.Bcancelar;
			this.ClientSize = new System.Drawing.Size(312, 134);
			this.Controls.Add(this.Lmodifdat);
			this.Controls.Add(this.Bcancelar);
			this.Controls.Add(this.Baceptar);
			this.Name = "OKCANCEL";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "OKCANCEL";
			this.Load += new System.EventHandler(this.OKCANCEL_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.OK;
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
			this.Close();
		}

		private void OKCANCEL_Load(object sender, System.EventArgs e)
		{
			//Hacemos fijo el tamaño de la ventana de confirmación.
			
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			
		}

		private void Lmodifdat_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
