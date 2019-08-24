using System;
using System.Text;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;

namespace P1.Tools
{
	

	class funciones
	{
		public static int[] bandera = new int[50];
		//bandera[49]-->para controlar si es una actualización de un acta
		//bandera[20],bandera[21],bandera[30] controlan la activación de los submenús de la barra de menús.
		public static int globalcont;
		//globalcont es el contador global para las imágenes
		public string ConnectionString ="user id=ADMIN1;data source=ORCL;password=ADMIN1";
		OracleConnection Cnt = new OracleConnection();
		OracleCommand Cmd = new OracleCommand();
		OracleDataAdapter DA = new OracleDataAdapter();
		DataSet DS = new DataSet();		
		
		/// Esta función actualiza los campos del profesor. Al no utilizarse en un
		/// un ingreso inicial, no recibe la PASSWORD, a diferencia de 
		/// ADDtoDB, que sí lo hace.
		public bool update_DB(int id_prof, string strImageName, bool check1, string dni,string apellidos, bool check2,string nombre,string fijo,bool check3, string movil,bool check4,string email,bool check5)
		{
			string c2apellidos;
			string c2apellidoscampo;
			string c3fijo;
			string c3fijocampo;
			string c4movil;
			string c4movilcampo;
			string c5email;
			string c5emailcampo;
			string imagen = strImageName;
			
			if(check1==false)
			{
                imagen=null;
			}


			if(check2==true)
			{
				c2apellidos=",'"+apellidos.ToString()+"'";
				c2apellidoscampo=",APELLIDOS";
			}
			else
			{
				c2apellidos="";
				c2apellidoscampo="";
			}
			if(check3==true)
			{
				c3fijo=",'"+fijo.ToString()+"'";
				c3fijocampo=",FIJO";
			}
			else
			{
				c3fijo="";
				c3fijocampo="";
			}
			if(check4==true)
			{
				c4movil=",'"+movil.ToString()+"'";
				c4movilcampo=",MOVIL";
			}
			else
			{
				c4movil="";
				c4movilcampo="";
			}
			if(check5==true)
			{
				c5email=",'"+email.ToString()+"'";
				c5emailcampo=",EMAIL";
			}
			else
			{
				c5email="";
				c5emailcampo="";
			}

			//////////////////////////////////////////////////////////////


			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}

			try
			{
				string query1;
				query1="delete from profesor where id_prof="+id_prof;
				Cmd.CommandText = query1;
				Cmd.Connection = Cnt;
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x){MessageBox.Show(x.Message);}
	
			try
			{
				if(check1 == true)//Si la imagen está marcada para ser actualizada...
				{
				
					FileStream fls;
					fls = new FileStream(@imagen, FileMode.Open, FileAccess.Read);
					byte[] blob = new byte[fls.Length];
					fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
					fls.Close();
				
					string query = "insert into PROFESOR(ID_PROF,FOTOGRAFIA,DNI,NOMBRE"+c2apellidoscampo.ToString()+c3fijocampo.ToString()+ c4movilcampo.ToString()+ c5emailcampo.ToString()+") values (" + id_prof + "," + " :BlobParameter, '" + dni.ToString()+ "', '"+nombre.ToString()+"'"+c2apellidos.ToString()+ c3fijo.ToString()+c4movil.ToString()+c5email.ToString()+")";

					OracleParameter blobParameter = new OracleParameter();
					blobParameter.OracleType = OracleType.Blob;
					blobParameter.ParameterName = "BlobParameter";
					blobParameter.Value = blob;

				
					Cmd.CommandText = query;
					Cmd.Connection = Cnt;

					Cmd.Parameters.Add(blobParameter);
					try
					{
						Cmd.ExecuteNonQuery();
					}
					catch(Exception x)
					{
						MessageBox.Show(x.Message.ToString());
					}

				
				}
	
			
				else 
				{
					string query = "insert into PROFESOR(ID_PROF,DNI,NOMBRE"+c2apellidoscampo.ToString()+c3fijocampo.ToString()+ c4movilcampo.ToString()+ c5emailcampo.ToString()+")values(" + id_prof + ", '" + dni.ToString()+ "', '"+nombre.ToString()+"'"+c2apellidos.ToString()+ c3fijo.ToString()+c4movil.ToString()+c5email.ToString()+")";
					Cmd.CommandText = query;
					Cmd.Connection = Cnt;
					Cmd.ExecuteNonQuery();
				
				}
			}
			catch(Exception excep)
			{
				MessageBox.Show(excep.Message.ToString());
			}

			return true;
			
			

		}//Fin procedimiento Update_DB

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public bool AddtoDB(int id_prof, string strImageName, string dni,string apellidos,string nombre,string fijo, string movil,string email,string password)
		{

			if (strImageName != "")
			{
				try
				{
					FileStream fls;
					fls = new FileStream(@strImageName, FileMode.Open, FileAccess.Read);

					byte[] blob = new byte[fls.Length];
					fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
					fls.Close();

					if (Cnt.State == System.Data.ConnectionState.Closed)
					{
						Cnt.ConnectionString = ConnectionString;
						Cnt.Open();
					}

					string query;
					query = "insert into PROFESOR(ID_PROF,FOTOGRAFIA,DNI,APELLIDOS,NOMBRE,FIJO,MOVIL,EMAIL,PASSWORD) values(" + id_prof + "," + " :BlobParameter, '" + dni.ToString()+"', '" +apellidos.ToString()+"', '"+nombre.ToString()+"', '" + fijo.ToString()+ "', '" + movil.ToString() + "', '" + email.ToString() + "', '" + password.ToString()+"')";

					OracleParameter blobParameter = new OracleParameter();
					blobParameter.OracleType = OracleType.Blob;
					blobParameter.ParameterName = "BlobParameter";
					blobParameter.Value = blob;

				
					Cmd.CommandText = query;
					Cmd.Connection = Cnt;

					Cmd.Parameters.Add(blobParameter);
					Cmd.ExecuteNonQuery();
				}
				catch(Exception x){MessageBox.Show(x.Message.ToString());}

				return true;
			}
			else{
				try
				{
					if (Cnt.State == System.Data.ConnectionState.Closed)
					{
						Cnt.ConnectionString = ConnectionString;
						Cnt.Open();
					}

					string query;
					query = "insert into PROFESOR(ID_PROF,DNI,APELLIDOS,NOMBRE,FIJO,MOVIL,EMAIL,PASSWORD) values(" + id_prof + "," + dni.ToString()+"', '" +apellidos.ToString()+"', '"+nombre.ToString()+"', '" + fijo.ToString()+ "', '" + movil.ToString() + "', '" + email.ToString() + "', '" + password.ToString()+"')";
					Cmd.CommandText = query;
					Cmd.Connection = Cnt;
				
					Cmd.ExecuteNonQuery();
				}
				catch(Exception x){MessageBox.Show(x.Message.ToString());}

				return false;
			}
		}//Fin ADDtoDB

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public bool AddtoDB2(string id_prof, string id_grupo, string nombre, string materia, string tutoria)
		{

			try{
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}

				string query;
				query = "insert into G_ALUM(id_prof,id_grupo,nombre,materia,tutoria) values(" + id_prof+ "," +id_grupo +", '"+nombre+"', '" + materia +"',"+tutoria+")";

				Cmd.CommandText = query;
				Cmd.Connection = Cnt;

				Cmd.ExecuteNonQuery();			
			}catch(Exception x){MessageBox.Show(x.Message.ToString());}

			return true;
		}//Fin AddtoDB2

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////

		public Image ReadFromDB(string id_profe)
		{
			
			
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
					try
				{
					for(int idnum=1;idnum<=this.check_max("PROFESOR");idnum++)
					{
						Cmd.CommandText = "SELECT ID_PROF,FOTOGRAFIA FROM PROFESOR WHERE id_prof =" + idnum;
						Cmd.Connection = Cnt;
						DA.SelectCommand = Cmd;
						DA.Fill(DS,"FOTOS");
						OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					}
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}
			
			try
			{
				byte[] blob = (byte[])DS.Tables["FOTOS"].Rows[int.Parse(id_profe)]["FOTOGRAFIA"];
			

				globalcont++;
				globalcont+=int.Parse(id_profe);
				//FileStream FS = new FileStream("image"+id_profe+".jpg", FileMode.OpenOrCreate);				
				FileStream FS = new FileStream("image"+globalcont.ToString()+".jpg", FileMode.OpenOrCreate);
				//string f = System.Security.Permissions.FileIOPermissionAccess.Read.ToString();
				if(FS.Read(blob, 0, blob.Length).ToString()== "0")
				{
					FS.Write(blob, 0, blob.Length);
				}
				else
				{
					FS.Read(blob, 0, blob.Length);
				
					//FS.Write(blob, 0, blob.Length);
				}	
				FS.Flush();
				FS.Close();
			   
				FS = null;
				//DS.Tables["FOTOS"].Clear();
				DS.Tables["FOTOS"].Clear();
				return Image.FromFile("image"+globalcont.ToString()+".jpg");
				
			
				
			}
			catch(Exception x)
			{
				//MessageBox.Show(x.Message.ToString());
				return null;
			}
		}//Fin Función ReadFromDB


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////


		
		/// <summary>
		/// Función que comprueba si una tabla está vacia o no.Como parámetro se le
		/// pasará el nombre de la tabla sobre la que se quiere consultar acerca de la
		/// existencia de al menos una clave primaria registrada en aquella. Si encuentra
		/// valores en la tabla devolverá el correspondiente al identificador de fila máximo y en
		/// caso contrario el valor será 0. Si se da algún otro tipo de fallo el valor devuelto
		/// será de -1.
		/// </summary>
		/// <param name="nombre_tabla"></param>
		/// <returns></returns>
		public int check_max(string nombre_tabla)
		{
			/*int t;
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
					
			}
			
			Cmd.Connection = Cnt;
			Cmd.CommandText="check_max";
			Cmd.CommandType= CommandType.StoredProcedure;
			try
			{
				//////////////////////////////////////////
				/// Código para el parámetro de salida del procedimiento.            
				OracleParameter objParam3 = new OracleParameter("idmax",OracleType.Number,3);	
				objParam3.Direction= ParameterDirection.Output;
				Cmd.Parameters.Add(objParam3);			
				////////////////////						
				Cmd.ExecuteNonQuery();				
				Cnt.Close();				
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			t = int.Parse(Cmd.Parameters[0].Value.ToString());
			return int.Parse(Cmd.Parameters[0].Value.ToString());*/
			try
			{

				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
					
				}
				Cmd.Connection = Cnt;
				Cmd.CommandText = "SELECT COUNT(ID_PROF) FROM "+ nombre_tabla.ToString();
				Cmd.CommandType = CommandType.Text;
				if (this.Cmd.ExecuteScalar().ToString() == "")
				{
					return 0;			
				}
				else
				{
					return int.Parse(this.Cmd.ExecuteScalar().ToString());
				}			
							
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
				
			}

			

		}


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		/// <summary>
		/// Procedimiento que recibe el índice del identificador del profesor
		/// del cual quieren mostrarse sus datos de la tabla cursos a través
		/// de un treeview, el cual también se le pasa como parámetro.
		/// </summary>
		/// <param name="indicePadre"></param>
		/// <param name="tree1"></param>
		public void listado_grupos(int indicePadre,TreeView tree1) 
		{   
			//// Creación del nodo "padre":
			TreeNode nuevoNodo = new TreeNode();
			
			//// Apertura de conexión para la consulta:
			Cmd.Connection = Cnt;

			//// Las consultas sólo seleccionan aquellas tablas que posean el id del
			//// profesor que se pasó como parámetro al procedimiento:
			///

			///////////////////////////////////////////////////////
			///

			try
			{

				Cmd.CommandText = "SELECT id_prof,nombre FROM PROFESOR WHERE ID_PROF =" + indicePadre.ToString();
				DA.SelectCommand = Cmd;
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
			
				DA.Fill(DS,"PROFESOR_SELECTED");
			
				Cnt.Close();
				////////////////////////////////////////////////////////
				Cmd.CommandText = "SELECT * FROM G_ALUM WHERE ID_PROF =" + indicePadre.ToString();
				DA.SelectCommand = Cmd;
				Cnt.Open();
			
				DA.Fill(DS,"G_ALUM_SELECTED");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				Cnt.Close();

			            
				// Crearemos un DataView para mostrar el nodo padre (nombre del profesor):
				DataView dataViewHijos = new DataView(DS.Tables["PROFESOR_SELECTED"]);
			

				// Y otro para aquellos campos que dependen del padre (campos 
				// almacenadados en la tabla del dataset DS.G_ALUM:
				DataView dataViewHijos2 = new DataView(DS.Tables["G_ALUM_SELECTED"]);

				//nuevoNodo.Text = "Profesor: "+dataRowCurrent["nombre"].ToString().Trim();
				//tree1.Nodes.Add(nuevoNodo);
            		
			
				foreach(DataRowView dataRowCurrent in dataViewHijos)
				{
					// Agregamos al TreeView los nodos Hijos que se han obtenido en el DataView.
					nuevoNodo.Text = "Profesor: "+dataRowCurrent["nombre"].ToString().Trim();
					tree1.Nodes.Add(nuevoNodo);				
				}

				foreach(DataRowView dataRowCurrent2 in dataViewHijos2)
				{
				

					TreeNode nuevoNodo12 = new TreeNode(); // Nodo CURSO (anida a materia y tutoría)
					TreeNode nuevoNodo13 = new TreeNode(); // Nodo MATERIA
					TreeNode nuevoNodo14 = new TreeNode(); // Nodo TUTORÍA
				
					// Asignamos al texto de los nodos los campos correspondientes del dataSet:
					nuevoNodo12.Text = "Curso: "+dataRowCurrent2["nombre"].ToString().Trim();
					nuevoNodo13.Text = "Materia: "+dataRowCurrent2["materia"].ToString().Trim();
					nuevoNodo14.Text = "Tutoría: "+dataRowCurrent2["tutoria"].ToString().Trim();
				
					// Por último agregamos los nodos al árbol:
					nuevoNodo.Nodes.Add(nuevoNodo12);
					nuevoNodo12.Nodes.Add(nuevoNodo13);
					nuevoNodo12.Nodes.Add(nuevoNodo14);
             		
				}//fin foreach

				DS.Tables["G_ALUM_SELECTED"].Clear();
				DS.Tables["PROFESOR_SELECTED"].Clear();
			}
			catch(Exception x){MessageBox.Show(x.Message.ToString());}
		
		}//fin procedimiento
		
		//////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////


		/// <summary>
		/// Procedimiento que recibe el índice del identificador del profesor
		/// del cual quieren mostrarse sus datos de la tabla cursos a través
		/// de un treeview, el cual también se le pasa como parámetro.
		/// </summary>
		/// <param name="indicePadre"></param>
		/// <param name="tree1"></param>
		public void listado_grupos2(TreeView tree1) 
		{   					
			//// Apertura de conexión para la consulta:
			Cmd.Connection = Cnt;

			//// Las consultas sólo seleccionan aquellas tablas que posean el id del
			//// profesor que se pasó como parámetro al procedimiento:
			///

			///////////////////////////////////////////////////////
			///
			try
			{

				Cmd.CommandText = "SELECT id_prof,nombre FROM PROFESOR";
				DA.SelectCommand = Cmd;
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
			
				DA.Fill(DS,"PROFESOR_SELECTED2");
			
				Cnt.Close();
				

			            
				// Crearemos un DataView para mostrar el nodo padre (nombre del profesor):
				DataView dataViewHijos = new DataView(DS.Tables["PROFESOR_SELECTED2"]);
			

				// Y otro para aquellos campos que dependen del padre (campos 
				// almacenadados en la tabla del dataset DS.G_ALUM:
				

				//nuevoNodo.Text = "Profesor: "+dataRowCurrent["nombre"].ToString().Trim();
				//tree1.Nodes.Add(nuevoNodo);
            		
				int indicePadre =1;
				foreach(DataRowView dataRowCurrent in dataViewHijos)
				{
					//// Creación del nodo "padre":
					TreeNode nuevoNodo = new TreeNode();
					// Agregamos al TreeView los nodos Hijos que se han obtenido en el DataView.
					nuevoNodo.Text = "Profesor: "+dataRowCurrent["nombre"].ToString().Trim();
					tree1.Nodes.Add(nuevoNodo);	
					

					////////////////////////////////////////////////////////
					Cmd.CommandText = "SELECT * FROM G_ALUM WHERE ID_PROF =" + indicePadre.ToString();
					DA.SelectCommand = Cmd;
					Cnt.Open();
			
					DA.Fill(DS,"G_ALUM_SELECTED2");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					Cnt.Close();

					DataView dataViewHijos2 = new DataView(DS.Tables["G_ALUM_SELECTED2"]);

					foreach(DataRowView dataRowCurrent2 in dataViewHijos2)
					{
				

						TreeNode nuevoNodo12 = new TreeNode(); // Nodo CURSO (anida a materia y tutoría)
						TreeNode nuevoNodo13 = new TreeNode(); // Nodo MATERIA
						TreeNode nuevoNodo14 = new TreeNode(); // Nodo TUTORÍA
				
						// Asignamos al texto de los nodos los campos correspondientes del dataSet:
						nuevoNodo12.Text = "Curso: "+dataRowCurrent2["nombre"].ToString().Trim();
						nuevoNodo13.Text = "Materia: "+dataRowCurrent2["materia"].ToString().Trim();
						if(dataRowCurrent2["tutoria"].ToString()=="1")
						{
							nuevoNodo14.Text = "Tutoría: Sí";
						}
						else
						{
							nuevoNodo14.Text = "Tutoría: No";
						}
				
						// Por último agregamos los nodos al árbol:
						nuevoNodo.Nodes.Add(nuevoNodo12);
						nuevoNodo12.Nodes.Add(nuevoNodo13);
						nuevoNodo12.Nodes.Add(nuevoNodo14);
						            		
					}//fin foreach anidado
					indicePadre++;
					DS.Tables["G_ALUM_SELECTED2"].Clear(); 
				}
				DS.Tables["PROFESOR_SELECTED2"].Clear();
			}
			catch(Exception x){MessageBox.Show(x.Message.ToString());}
		
		}//fin procedimiento


		//////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////////////////////////////



		
		/// <summary>
		/// Procedimiento que busca en la base de datos si existe algún campo DNI
		/// de la tabla PROFESORES similar a aquél que le es pasado como variable 
		/// cadena. En caso de encontrarlo devolverá el id_prof asociado a este
		/// DNI. En caso contrario devuelve -1.
		/// </summary>
		/// <param name="DNI"></param>
		/// <returns></returns>
		public int buscaDNI (string DNI)
		{
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
				Cmd.Connection = Cnt;
				Cmd.CommandText = "SELECT DNI FROM PROFESOR WHERE dni = '" + DNI.ToString()+"' ";
				Cmd.CommandType = CommandType.Text;
				if(this.Cmd.ExecuteScalar().ToString()== DNI.ToString())
				{
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT id_prof FROM PROFESOR WHERE dni = '" + DNI.ToString()+"' ";
					Cmd.CommandType = CommandType.Text;

					return int.Parse(Cmd.ExecuteScalar().ToString());
				}
				/*DA.SelectCommand = Cmd
				DA.Fill(DS,"BUSCADN");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				DataRow dR=this.DS.Tables["BUSCADN"].NewRow();
				if(this.DS.Tables["BUSCADNI"].Rows[0][0].ToString()== DNI.ToString())
				{
					//return true;
				}*/
				
			}
			catch(Exception x)
			{
				if(x.Message.ToString()=="Referencia a objeto no establecida como instancia de un objeto.")
				{
					return -1;
				}
				else
				{
					MessageBox.Show(x.Message.ToString());
				}
				return -1;
			}
			
			return -1;
			
		}//Fin procedimiento



		/// <summary>
		/// Procedimiento que busca en la base de datos si existe algún campo PASSWORD
		/// de la tabla PROFESORES correspondiente a un profesor que una vez creado lo
		/// haya modificado. En caso de encontrarlo devolverá el id_prof asociado dicho
		/// profesor. En caso contrario devuelve -1.
		/// </summary>
		/// <param name="DNI"></param>
		/// <returns></returns>
		public int buscaPASS (string DNI)
		{
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
				Cmd.Connection = Cnt;
				Cmd.CommandText = "SELECT PASSWORD FROM PROFESOR WHERE dni = '" + DNI.ToString()+"' ";
				Cmd.CommandType = CommandType.Text;
				if(this.Cmd.ExecuteScalar().ToString()!= "" )
				{
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT id_prof FROM PROFESOR WHERE dni = '" + DNI.ToString()+"' ";
					Cmd.CommandType = CommandType.Text;

					return int.Parse(Cmd.ExecuteScalar().ToString());
				}
				
				
			}
			catch(Exception x)
			{
				if(x.Message.ToString()=="Referencia a objeto no establecida como instancia de un objeto.")
				{
					return -1;
				}
				else
				{
					MessageBox.Show(x.Message.ToString());
				}
				return -1;
			}
			
			return -1;
			
		}//Fin procedimiento

		///////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		

		public static bool DeleteFile(string fileName) 
		{
		
			try 
			{
				System.IO.File.Delete(fileName);
				return true;
			} 
			catch (Exception x)
			{
				return false;
			}
			
		} 
		
		//////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int campovacio(int maxindice)
		{
			int i;
			if(maxindice>0)
			{
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
				for (i=1;i<=maxindice;i++)
				{
					
				
					Cmd.CommandText = "SELECT dni FROM PROFESOR where id_prof="+i;
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"VACIOS");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					DataRow dR=this.DS.Tables["VACIOS"].NewRow();
					if(this.DS.Tables["VACIOS"].Rows[i][0].ToString()=="")
					{
						return i;
					}
									
				}
				//MessageBox.Show("id_prof="+(i).ToString());
				return maxindice;//En caso de que todos las filas con id
				//tengan dni, devuelve el valor del último
				//id_prof incrementado en 1.
			}
			else return 1;
		
		}//Fin función campovacio

		//////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////F U N C I O N E S   U S A D A S   E N  E L   F O R M U L A R I O  5 /////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////
		///


		public int check_max2(string tipo)
		{
			try
			{

				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
					
				}
				if(tipo=="ACTA")
				{
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT MAX(SESION) FROM INFORREUN WHERE TIPO = 'ACTA'";
					Cmd.CommandType = CommandType.Text;
					if (this.Cmd.ExecuteScalar().ToString() == "")
					{
						return 0;			
					}
					else
					{
						return int.Parse(this.Cmd.ExecuteScalar().ToString());
					}				
				}
				else 
				{
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT MAX(SESION) FROM INFORREUN WHERE TIPO = 'CONVOCATORIA'";
					Cmd.CommandType = CommandType.Text;
					if (this.Cmd.ExecuteScalar().ToString() == "")
					{
						return 0;			
					}
					else
					{
						return int.Parse(this.Cmd.ExecuteScalar().ToString());
					}			

				}
							
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
				
			}
		
		}// Fin función check_max2

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int inserta_acta(string m_o_anteriores, string ordendia, string ruegospreguntas, string nombre, string lugar, string fecha, string hora,string sesion)
		{
			int id_sesion;
			string query;
			
			id_sesion=check_max2("ACTA")+1;


			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN values("+sesion+","+id_sesion+",'ACTA', '"+nombre+"','"+lugar+"',to_date('"+fecha+"', 'DD/MM/YYYY HH24:MI:SS'),'"+hora+"','"+ordendia+"')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			///////////////////////////////////////////////
			
			query="insert into INFORREUN2 values("+sesion+",'"+m_o_anteriores+"','ACTA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
				
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN3 values("+sesion+",'"+ruegospreguntas+"','ACTA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;

			}
			/////////////////////////////////////////////
			
			this.Cnt.Close();
			return 1;


		}//Fin función inserta_acta


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int inserta_convocatoria(string ordendia, string ruegospreguntas, string nombre, string lugar, string fecha, string hora,string sesion)
		{
			int id_sesion;
			string query;
			
			id_sesion=check_max2("CONVOCATORIA")+1;


			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN values("+sesion+","+id_sesion+",'CONVOCATORIA', '"+nombre+"','"+lugar+"',to_date('"+fecha+"', 'DD/MM/YYYY HH24:MI:SS'),'"+hora+"','"+ordendia+"')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			///////////////////////////////////////////////
			
			query="insert into INFORREUN3 values("+sesion+",'"+ruegospreguntas+"','CONVOCATORIA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;

			}
			/////////////////////////////////////////////
			
			this.Cnt.Close();
			return 1;


		}//Fin función inserta_convocatoria

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int inserta_convocatoria2(string ordendia, string ruegospreguntas, string nombre, string lugar, string fecha, string hora,string sesion,string sesion2)
		{
			
			string query;
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN values("+sesion2+","+sesion+",'CONVOCATORIA', '"+nombre+"','"+lugar+"',to_date('"+fecha+"', 'DD/MM/YYYY HH24:MI:SS'),'"+hora+"','"+ordendia+"')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			///////////////////////////////////////////////
			
			query="insert into INFORREUN3 values("+sesion2+",'"+ruegospreguntas+"','CONVOCATORIA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;

			}
			/////////////////////////////////////////////
			
			this.Cnt.Close();
			return 1;


		}//Fin función inserta_convocatoria2



		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		public int volcar_listado(System.Windows.Forms.DataGrid dataGrid1)
		{
			try
			{
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
				//////////////////////////////////////////////////
				this.Cmd.Connection=this.Cnt;
				this.Cmd.CommandText="SELECT SESION,NOMBRE,TIPO,FECHA FROM INFORREUN";
				this.DA.SelectCommand=this.Cmd;
				DA.Fill(this.DS,"dINFORREUN");
				this.Cnt.Close();
				dataGrid1.DataSource= this.DS;			
				dataGrid1.DataMember="dINFORREUN";
				if(this.DS.Tables["dINFORREUN"].Rows!=null)
				{
					this.DS.Tables["dINFORREUN"].Clear();

				}
				this.Cmd.Connection=this.Cnt;
				this.Cmd.CommandText="SELECT SESION,NOMBRE,TIPO,FECHA FROM INFORREUN";
				this.DA.SelectCommand=this.Cmd;
				DA.Fill(this.DS,"dINFORREUN");
				this.Cnt.Close();
				dataGrid1.DataSource= this.DS;			
				dataGrid1.DataMember="dINFORREUN";
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString()+"\n\nImposible cargar el listado de documentos."); 
				this.DS.Tables["dINFORREUN"].Clear();
				return -1;
			}
			
			return 1;
		}//Fin función "volcar_listado".

		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////////////////

		public int filtrar_listado(System.Windows.Forms.DataGrid dataGrid1,string campo_filtrado)
		{
			System.Data.DataView odv = new System.Data.DataView();
			
			try
			{
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}

				odv.Table= this.DS.Tables["dINFORREUN"];
				odv.Sort= campo_filtrado;
				dataGrid1.DataSource=odv;
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString()); 
				return -1;
			}
			return 1;
		}//Fin función "Filtrar_listado"

		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////////////////

		public int filtrar_listado2(System.Windows.Forms.DataGrid dataGrid1,string fecha_filtrado, string filtrado_tipo)
		{
			System.Data.DataView odv = new System.Data.DataView();
			
			try
			{
				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
				}
				if(filtrado_tipo.ToString()=="ACTA+CONVOCATORIA")
				{
					odv.Table= this.DS.Tables["dINFORREUN"];
					odv.RowFilter= "(TIPO='ACTA' OR TIPO='CONVOCATORIA') AND FECHA='"+fecha_filtrado+"'";
					dataGrid1.DataSource=odv;
				}
				else
				{
					odv.Table= this.DS.Tables["dINFORREUN"];
					odv.RowFilter= "FECHA='"+fecha_filtrado+"' AND TIPO='"+filtrado_tipo+"'";
					dataGrid1.DataSource=odv;
				}
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString()); 
				return -1;
			}
			return 1;
		}//Fin Filtrar_listado2

		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int elimina (int sesion, string tipo)
		{
						
			string query1;
			string query2;
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}

			/////////////////////////////////////////////
			Cmd.Connection = Cnt;
			query1="select SESION from INFORREUN where (sesion="+sesion+")AND(tipo='"+tipo+"')";
			Cmd.CommandText = query1;			
			Cmd.CommandType = CommandType.Text;
			try
			{
				int id = int.Parse(Cmd.ExecuteScalar().ToString());
			

				/////////////////////////////////////////////
				query2="delete from INFORREUN where (sesion="+id+")and(tipo='"+tipo+"')";
				Cmd.CommandText = query2;
				Cmd.Connection = Cnt;
			
				Cmd.ExecuteNonQuery();
				return id;
				
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			
			

		}//Fin función "elimina"

		/*void actualiza_campos(int id_reunion,System.Windows.Forms.TextBox tbActasAnteriores, System.Windows.Forms.TextBox tbOrdenesDia, System.Windows.Forms.TextBox tbRuegosyPreguntas,System.Windows.Forms.TextBox tbNombre,System.Windows.Forms.TextBox tbLugar, System.Windows.Forms.DateTimePicker dtimepick2, System.Windows.Forms.ComboBox cbHora, System.Windows.Forms.ComboBox cbMinutos, System.Windows.Forms.ListBox)
		{


		}*/


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		public int inserta_acta2(string m_o_anteriores, string ordendia, string ruegospreguntas, string nombre, string lugar, string fecha, string hora,string sesion,string sesion2)
		{
			
			string query;
			
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN values("+sesion2+","+sesion+",'ACTA', '"+nombre+"','"+lugar+"',to_date('"+fecha+"', 'DD/MM/YYYY HH24:MI:SS'),'"+hora+"','"+ordendia+"')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			///////////////////////////////////////////////
			
			query="insert into INFORREUN2 values("+sesion2+",'"+m_o_anteriores+"','ACTA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
				
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;
			}
			/////////////////////////////////////////////
			query="insert into INFORREUN3 values("+sesion2+",'"+ruegospreguntas+"','ACTA')";                
			Cmd.CommandText = query;
			Cmd.Connection = Cnt;
			try
			{
				Cmd.ExecuteNonQuery();
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
				return -1;

			}
			/////////////////////////////////////////////
			
			this.Cnt.Close();
			return 1;


		}//Fin función inserta_acta2


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		

		public void carga_contenidos(System.Windows.Forms.ListBox listBox1,System.Windows.Forms.DateTimePicker dtpick,System.Windows.Forms.TextBox tbActasAnteriores, TextBox tbOrdenesDia, TextBox tbRuegosyPreguntas, TextBox tbNombre, TextBox tbLugar, System.Windows.Forms.ComboBox cbHora, ComboBox cbMinutos, string tipo, int sesion)
		{
			if (Cnt.State == System.Data.ConnectionState.Closed)
			{
				Cnt.ConnectionString = ConnectionString;
				Cnt.Open();
			}
				
				
			try
			{
				Cmd.CommandText = "SELECT nombre,lugar,fecha,hora,ordendia FROM INFORREUN WHERE (sesion =" + sesion.ToString()+ ")AND(tipo='"+tipo+"')";
				Cmd.Connection = Cnt;
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"d1");
				OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE

				listBox1.Text=sesion.ToString();
				tbNombre.Text=DS.Tables["d1"].Rows[0]["nombre"].ToString();
				tbLugar.Text=DS.Tables["d1"].Rows[0]["lugar"].ToString();
				dtpick.Text=DS.Tables["d1"].Rows[0]["fecha"].ToString();
				cbHora.Text=(DS.Tables["d1"].Rows[0]["hora"].ToString()).Substring(0,2);
				cbMinutos.Text=(DS.Tables["d1"].Rows[0]["hora"].ToString()).Substring(2,3);
				tbOrdenesDia.Text=DS.Tables["d1"].Rows[0]["ordendia"].ToString();

				if(tipo.ToString()=="ACTA")
				{
					Cmd.CommandText = "SELECT M_O_ANT FROM INFORREUN2 WHERE (num_sesion =" + sesion.ToString()+ ")AND(tipo='"+tipo+"')";
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"d2");
					OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
					tbActasAnteriores.Text=DS.Tables["d2"].Rows[0]["M_O_ANT"].ToString();
					this.DS.Tables["d2"].Clear();
				}

				Cmd.CommandText = "SELECT R_P FROM INFORREUN3 WHERE (num_sesion =" + sesion.ToString()+ ")AND(tipo='"+tipo+"')";
				Cmd.Connection = Cnt;
				DA.SelectCommand = Cmd;
				DA.Fill(DS,"d3");
				OracleCommandBuilder objBuilder3 = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE
				tbRuegosyPreguntas.Text=DS.Tables["d3"].Rows[0]["R_P"].ToString();				
				
				this.DS.Tables["d1"].Clear();				
				this.DS.Tables["d3"].Clear();			
			}
			catch(Exception x)
			{
				MessageBox.Show(x.Message.ToString());
			}

		}//Fin función "carga_contenidos"


		////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////

		public void genera_doc(string id_sesion,string tipo,System.Windows.Forms.Label encabezado, System.Windows.Forms.Label num_sesion, System.Windows.Forms.Label hora, System.Windows.Forms.Label fecha, System.Windows.Forms.Label lugar, Label lbContenidoConv,Label lbModif_observ_Actas, Label lbOrdenesdia_Actas, Label lbRuegosPreguntas_Actas)
		{

			if(tipo=="ACTA")
			{
				try
				{
					if (Cnt.State == System.Data.ConnectionState.Closed)
					{
						Cnt.ConnectionString = ConnectionString;
						Cnt.Open();
					
					}
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT DEPT_NOMBRE FROM CONFIG";
					Cmd.CommandType = CommandType.Text;
					encabezado.Text="Acta de Reunión de Departamento de "+this.Cmd.ExecuteScalar().ToString();

					Cmd.CommandText = "SELECT * FROM INFORREUN WHERE (TIPO='"+tipo+"') AND (NUM_SESION="+id_sesion+")";
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"VISOR_ACTAS");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE

					num_sesion.Text=DS.Tables["VISOR_ACTAS"].Rows[0]["SESION"].ToString();
					hora.Text=DS.Tables["VISOR_ACTAS"].Rows[0]["HORA"].ToString();
					fecha.Text=DS.Tables["VISOR_ACTAS"].Rows[0]["FECHA"].ToString().Substring(0,10);
					lugar.Text=DS.Tables["VISOR_ACTAS"].Rows[0]["LUGAR"].ToString();
					lbOrdenesdia_Actas.Text=DS.Tables["VISOR_ACTAS"].Rows[0]["ORDENDIA"].ToString();

					Cmd.CommandText = "SELECT * FROM INFORREUN2 WHERE (TIPO='"+tipo+"') AND (NUM_SESION="+id_sesion+")";
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"VISOR_ACTAS2");
					OracleCommandBuilder objBuilder1 = new OracleCommandBuilder(this.DA);

					Cmd.CommandText = "SELECT * FROM INFORREUN3 WHERE (TIPO='"+tipo+"') AND (NUM_SESION="+id_sesion+")";
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"VISOR_ACTAS3");
					OracleCommandBuilder objBuilder2 = new OracleCommandBuilder(this.DA);



					lbRuegosPreguntas_Actas.Text=DS.Tables["VISOR_ACTAS3"].Rows[0]["R_P"].ToString();					
					lbModif_observ_Actas.Text=DS.Tables["VISOR_ACTAS2"].Rows[0]["M_O_ANT"].ToString();
				
					DS.Tables["VISOR_ACTAS"].Clear();
					DS.Tables["VISOR_ACTAS2"].Clear();
					DS.Tables["VISOR_ACTAS3"].Clear();
						
					
					Cnt.Close();
					    
					
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}

			}//Fin if
			else if (tipo=="CONVOCATORIA")
			{
				try
				{
					if (Cnt.State == System.Data.ConnectionState.Closed)
					{
						Cnt.ConnectionString = ConnectionString;
						Cnt.Open();
					
					}
					Cmd.Connection = Cnt;
					Cmd.CommandText = "SELECT DEPT_NOMBRE FROM CONFIG";
					Cmd.CommandType = CommandType.Text;
					encabezado.Text="Convocatoria de Reunión del Departamento de "+this.Cmd.ExecuteScalar().ToString();

					Cmd.CommandText = "SELECT * FROM INFORREUN WHERE (TIPO='"+tipo+"') AND (NUM_SESION="+id_sesion+")";
					Cmd.Connection = Cnt;
					DA.SelectCommand = Cmd;
					DA.Fill(DS,"VISOR_CONV");
					OracleCommandBuilder objBuilder = new OracleCommandBuilder(this.DA); //Necesario para el UPDATE

					num_sesion.Text=DS.Tables["VISOR_CONV"].Rows[0]["SESION"].ToString();
					hora.Text=DS.Tables["VISOR_CONV"].Rows[0]["HORA"].ToString();
					fecha.Text=DS.Tables["VISOR_CONV"].Rows[0]["FECHA"].ToString().Substring(0,10);
					lugar.Text=DS.Tables["VISOR_CONV"].Rows[0]["LUGAR"].ToString();
					lbContenidoConv.Text=DS.Tables["VISOR_CONV"].Rows[0]["ORDENDIA"].ToString();
				
					DS.Tables["VISOR_CONV"].Clear();
					
						
					
					Cnt.Close();
					    
					
				}
				catch(Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}
			}

		}



		
	}
}







































////////////////////////////////////////////////////////////////////////////////
///
/*  Código de la antigua funcion check_max.
			try
			{

				if (Cnt.State == System.Data.ConnectionState.Closed)
				{
					Cnt.ConnectionString = ConnectionString;
					Cnt.Open();
					
				}
				Cmd.Connection = Cnt;
				Cmd.CommandText = "SELECT COUNT(ID_PROF)FROM "+ nombre_tabla.ToString();
				Cmd.CommandType = CommandType.Text;
				if (this.Cmd.ExecuteScalar().ToString() == "")
				{
					return 0;			
				}
				else
				{
					return int.Parse(this.Cmd.ExecuteScalar().ToString());
				}			
							
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
				
			}
 * */
