using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace usr_sap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text == "")
            {
                MessageBox.Show("Seleccione ruta");
                return;
            }

            var ruta = txtRuta.Text;
            if (!File.Exists(ruta + "\\B CMPC-SP-CCS (Colaboradores por plataforma, V1, 20-07-15).csv"))
            {
                MessageBox.Show("No se encontro el la carpeta");
                return;
            }
            if (!File.Exists(ruta + "\\B CMPC-SP-CCS (Registro de cuentas SAP, V1, 20-07-15).csv"))
            {
                MessageBox.Show("No se encontro el la carpeta");
                return;
            }
            if (!File.Exists(ruta + "\\B CMPC-SP-CCS (Usuario por rol y modulo, V1, 20-08-11).csv"))
            {
                MessageBox.Show("No se encontro el la carpeta");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Desea procesar la informacion?", "Usuarios SAP", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }



            var fileName = ruta + "\\B CMPC-SP-CCS (Colaboradores por plataforma, V1, 20-07-15).csv";
            var fileName1 = ruta + "\\B CMPC-SP-CCS (Registro de cuentas SAP, V1, 20-07-15).csv";
            var fileName2 = ruta + "\\B CMPC-SP-CCS (Usuario por rol y modulo, V1, 20-08-11).csv";
            //var fileName3 = ruta + "\\Capacitaciones_SAP_Culminadas_20201019_05_47_25_PM.csv";

            var datos = ConvertCsvToDataTable(fileName);
            var datos1 = ConvertCsvToDataTable(fileName1);
            var datos2 = ConvertCsvToDataTable(fileName2);
            //var datos3 = ConvertCsvToDataTable(fileName3);




            //Declare without initializing.
            string columnas = "";

            DataTable CrearTabla = new DataTable();

            //foreach (var item in datos.Columns)
            //{
            //    columnas += item.ToString() + "_cp~";
            //}

            foreach (var item in datos1.Columns)
            {
                Application.DoEvents();
                columnas += item.ToString() + "_rcs~";

            }

            foreach (var item in datos2.Columns)
            {
                Application.DoEvents();
                columnas += item.ToString() + "_urm~";
            }

            string[] split = columnas.Split('~');

            foreach (var item in split) //item = donde se localiza
            {
                Application.DoEvents();
                datos.Columns.Add(item);
            }

            //eliminar datos
            datos.Columns.Remove("column1");
            ////AGREGAR COLUMNAS
            //datos.Columns.Add("CO");
            //datos.Columns.Add("FI");
            //datos.Columns.Add("MM");
            //datos.Columns.Add("PM");
            //datos.Columns.Add("PP");
            //datos.Columns.Add("PS");
            //datos.Columns.Add("SD");
            //datos.Columns.Add("Otras");            //datos.Columns.Add("CO");
            //datos.Columns.Add("FI");
            //datos.Columns.Add("MM");
            //datos.Columns.Add("PM");
            //datos.Columns.Add("PP");
            //datos.Columns.Add("PS");
            //datos.Columns.Add("SD");
            //datos.Columns.Add("Otras");

            //poner barra de carga
            barrita.Maximum = datos.Rows.Count;
            barrita.Minimum = 0;
            int vuelta = 0;


            foreach (DataRow item in datos.Rows)
            {
                Application.DoEvents();
                vuelta++;
                barrita.Value = vuelta;
                string dni = item["DNI"].ToString();

                //Segundo campo para buscar 
                string correo = item["Correo electrónico de usuario"].ToString();

                string usuario = item["NOMBRE DE USUARIO"].ToString();

                string nombre = item["Nombre completo de usuario"].ToString();


                //Si no viene en blanco el DNI, busco algo 
                if (dni != "")
                {
                    //Busca en datos 1 
                    var results = from myRow in datos1.AsEnumerable()
                                  where myRow.Field<String>("RUT") == dni
                                  select myRow;

                    //rescatar la info de datos 1 
                    foreach (var resultado in results)
                    {
                        Application.DoEvents();
                        var a = resultado;


                        item["RUT_rcs"] = a["RUT"];
                        item["Ap.Paterno_rcs"] = a["Ap.Paterno"];
                        item["Ap.Materno_rcs"] = a["Ap.Materno"];

                        item["Nombres_rcs"] = a["Nombres"];//Nombres
                        item["Fecha Baja_rcs"] = a["Fecha Baja"];//FechaBaja
                        item["Sociedad_rcs"] = a["Sociedad"];//Sociedad
                        item["Nombre Sociedad_rcs"] = a["Nombre Sociedad"];//NombreSociedad
                        item["Division_rcs"] = a["Division"];//Division
                        item["Desc. Division_rcs"] = a["Desc. Division"];//Desc.Division
                        item["Anexo_rcs"] = a["Anexo"];//Anexo
                        item["USR SSFF_rcs"] = a["USR SSFF"];//USRSSFF
                        item["Email_rcs"] = a["Email"];//Email
                        item["Cargo_rcs"] = a["Cargo"];//Cargo
                        item["U.Org._rcs"] = a["U.Org."];//U.Org.
                        item["Usuario_rcs"] = a["Usuario"];//Usuario
                        item["Status_rcs"] = a["Status"];//Status
                        item["Grp.aut._rcs"] = a["Grp.aut."];//Grp.aut.
                        item["Alerta_rcs"] = a["Alerta"];//Alerta

                        item.AcceptChanges();

                        //Obligo a salir del forreach 
                        break;

                    }
                }
                else if (correo != "")
                {
                    //Busca en datos 1 
                    var results = from myRow in datos1.AsEnumerable()
                                  where myRow.Field<String>("Email") == correo
                                  select myRow;

                    //rescatar la info de datos 1 
                    foreach (var resultado in results)
                    {
                        Application.DoEvents();
                        var a = resultado;


                        item["RUT_rcs"] = a["RUT"];
                        item["Ap.Paterno_rcs"] = a["Ap.Paterno"];
                        item["Ap.Materno_rcs"] = a["Ap.Materno"];

                        item["Nombres_rcs"] = a["Nombres"];//Nombres
                        item["Fecha Baja_rcs"] = a["Fecha Baja"];//FechaBaja
                        item["Sociedad_rcs"] = a["Sociedad"];//Sociedad
                        item["Nombre Sociedad_rcs"] = a["Nombre Sociedad"];//NombreSociedad
                        item["Division_rcs"] = a["Division"];//Division
                        item["Desc. Division_rcs"] = a["Desc. Division"];//Desc.Division
                        item["Anexo_rcs"] = a["Anexo"];//Anexo
                        item["USR SSFF_rcs"] = a["USR SSFF"];//USRSSFF
                        item["Email_rcs"] = a["Email"];//Email
                        item["Cargo_rcs"] = a["Cargo"];//Cargo
                        item["U.Org._rcs"] = a["U.Org."];//U.Org.
                        item["Usuario_rcs"] = a["Usuario"];//Usuario
                        item["Status_rcs"] = a["Status"];//Status
                        item["Grp.aut._rcs"] = a["Grp.aut."];//Grp.aut.
                        item["Alerta_rcs"] = a["Alerta"];//Alerta

                        item.AcceptChanges();

                        //Obligo a salir del forreach 
                        break;
                    }
                }
                if (usuario != "")
                {
                    //recorre cada caracter y elimina si encuentra un numero
                    foreach (char c in usuario)
                    {
                        string texto = c.ToString();
                        int num = 0;
                        int.TryParse(texto, out num);

                        if (num > 0)
                        {
                            usuario = usuario.Replace(texto, "");
                        }
                    }

                    var results = from myRow in datos2.AsEnumerable()
                                  where myRow.Field<String>("Usuarios") == usuario
                                  select myRow;
                    //var CO = "";
                    //var FI= "";
                    //var MM = "";
                    //var PM = "";
                    //var PP = "";
                    //var PS = "";
                    //var SD = "";
                    //var Otras = "";

                    //int cuentaCO = 0;
                    //int cuentaFI = 0;
                    //int cuentaMM = 0;
                    //int cuentaPM = 0;
                    //int cuentaPP = 0;
                    //int cuentaPS = 0;
                    //int cuentaSD = 0;
                    //int cuentaOtras = 0;


                    //var buscaCO = from myRow in datos2.AsEnumerable()
                    //              where (myRow.Field<String>("Usuarios") == usuario && myRow.Field<String>("Módulo-R") == CO)
                    //              select myRow;

                    //foreach (var i in buscaCO)
                    //{
                    //    cuentaCO++;
                    //}

                    //item["CO"] = buscaCO.ToString();



                    //rescatar la info de datos 1 
                    foreach (var resultado in results)
                    {
                        Application.DoEvents();
                        var a = resultado;


                        item["Usuarios_urm"] = a["Usuarios"];
                        item["Nombre_urm"] = a["Nombre"];
                        item["Rol_urm"] = a["Rol"];
                        item["NG o LG_urm"] = a["NG o LG"];
                        item["Función-R_urm"] = a["Función-R"];
                        item["Módulo-R_urm"] = a["Módulo-R"];
                        item["Grp. Usuario_urm"] = a["Grp. Usuario"];
                        item["Grp. Usuario 2_urm"] = a["Grp. Usuario 2"];
                        item["Departamento_urm"] = a["Departamento"];
                        item["Función-Negocio_urm"] = a["Función-Negocio"];
                        item["Fecha de inicio_urm"] = a["Fecha de inicio"];
                        item["Fecha fin_urm"] = a["Fecha fin"];
                        item["Fecha_urm"] = a["Fecha"];
                        item["Hora_urm"] = a["Hora"];


                        item.AcceptChanges();

                        //Obligo a salir del forreach 
                        break;
                    }
                }
                else if (nombre != "")
                {
                    var results = from myRow in datos2.AsEnumerable()
                                  where myRow.Field<String>("Nombre") == nombre
                                  select myRow;
                    foreach (var resultado in results)
                    {
                        Application.DoEvents();
                        var a = resultado;


                        item["Usuarios_urm"] = a["Usuarios"];
                        item["Nombre_urm"] = a["Nombre"];
                        item["Rol_urm"] = a["Rol"];
                        item["NG o LG_urm"] = a["NG o LG"];
                        item["Función-R_urm"] = a["Función-R"];
                        item["Módulo-R_urm"] = a["Módulo-R"];
                        item["Grp. Usuario_urm"] = a["Grp. Usuario"];
                        item["Grp. Usuario 2_urm"] = a["Grp. Usuario 2"];
                        item["Departamento_urm"] = a["Departamento"];
                        item["Función-Negocio_urm"] = a["Función-Negocio"];
                        item["Fecha de inicio_urm"] = a["Fecha de inicio"];
                        item["Fecha fin_urm"] = a["Fecha fin"];
                        item["Fecha_urm"] = a["Fecha"];
                        item["Hora_urm"] = a["Hora"];


                        item.AcceptChanges();

                        //Obligo a salir del forreach 
                        break;
                    }
                }

            }
            datos.AcceptChanges();
            barrita.Value = 0;

            grdCuartoExcel.DataSource = datos;
            grdCuartoExcel.Columns[13].Visible = false;
            grdCuartoExcel.Columns[18].Visible = false;
            grdCuartoExcel.Columns[19].Visible = false;
            grdCuartoExcel.Columns[20].Visible = false;
            grdCuartoExcel.Columns[21].Visible = false;
            grdCuartoExcel.Columns[22].Visible = false;
            grdCuartoExcel.Columns[23].Visible = false;
            grdCuartoExcel.Columns[24].Visible = false;
            grdCuartoExcel.Columns[27].Visible = false;
            grdCuartoExcel.Columns[28].Visible = false;
            grdCuartoExcel.Columns[29].Visible = false;
            grdCuartoExcel.Columns[32].Visible = false;
            grdCuartoExcel.Columns[33].Visible = false;
            grdCuartoExcel.Columns[34].Visible = false;
            grdCuartoExcel.Columns[36].Visible = false;
            grdCuartoExcel.Columns[37].Visible = false;
            grdCuartoExcel.Columns[38].Visible = false;
            grdCuartoExcel.Columns[39].Visible = false;
            grdCuartoExcel.Columns[41].Visible = false;
            grdCuartoExcel.Columns[42].Visible = false;
            grdCuartoExcel.Columns[43].Visible = false;
            grdCuartoExcel.Columns[44].Visible = false;
            grdCuartoExcel.Columns[45].Visible = false;
            grdCuartoExcel.Columns[46].Visible = false;
            grdCuartoExcel.Columns[47].Visible = false;
            grdCuartoExcel.Columns[48].Visible = false;
            MessageBox.Show("La informacion ha sido procesada");

            buscarUsuarioRCS.Enabled = true;
            buscarPlataforma.Enabled = true;
            buscarUsuarioURM.Enabled = true;
            buscarDni.Enabled = true;
            buscarCorreo.Enabled = true;
            buscarNombre.Enabled = true;
            buscarUnidadOrg.Enabled = true;
            buscarCargo.Enabled = true;
            buscarUnidadN.Enabled = true;
            buscarFilial.Enabled = true;

        }

        public DataTable ConvertCsvToDataTable(string filePath)
        {
            //reading all the lines(rows) from the file.
            try
            {
                string[] rows = File.ReadAllLines(filePath);
            
            DataTable dtData = new DataTable();
            string[] rowValues = null;
            DataRow dr = dtData.NewRow();

            //Creating columns
            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(';'))
                    dtData.Columns.Add(columnName);
            }

            //Creating row for each line.(except the first line, which contain column names)
            for (int row = 1; row < rows.Length; row++)
            {
                rowValues = rows[row].Split(';');
                dr = dtData.NewRow();
                dr.ItemArray = rowValues;
                dtData.Rows.Add(dr);
            }

                return dtData;
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("El proceso no puede obtener acceso al archivo"))
                {
                    MessageBox.Show("Para procesar la informacion, debe cerrar ");
                    Application.Exit();
                }
                DataTable dtData = new DataTable();
                return dtData;
            }
        }

        private void grdCuartoExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //grdCuartoExcel.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                DataGridViewRow row = this.grdCuartoExcel.Rows[e.RowIndex];
                txtUsuarioRCS.Text = row.Cells["Usuario_rcs"].Value.ToString();
                txtPlataforma.Text = row.Cells["Plataforma"].Value.ToString();
                txtUsuarioURM.Text = row.Cells["Usuarios_urm"].Value.ToString();
                txtDni.Text = row.Cells["DNI"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo electrónico de usuario"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre completo de usuario"].Value.ToString();
                txtUnidad.Text = row.Cells["Unidad de Negocio"].Value.ToString();
                txtCargo.Text = row.Cells["Cargo"].Value.ToString();
                txtUnidadO.Text = row.Cells["U.Org._rcs"].Value.ToString();
                txtFilial.Text = row.Cells["Filial"].Value.ToString();

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select Folder";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = fbd.SelectedPath;
            }

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea exportar la informacion?", "Usuarios SAP", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            exportarExcel();

        }

        private void exportarExcel()
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "UsuarioSAP.csv";
            bool fileError = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("No se pudo exportar." + ex.Message);
                    }
                }
                if (!fileError)
                {

                    if (grdCuartoExcel.RowCount > 0)
                    {
                        string value = "";
                        DataGridViewRow dr = new DataGridViewRow();
                        StreamWriter swOut = new StreamWriter(sfd.FileName);

                        //write header rows to csv
                        for (int i = 0; i <= grdCuartoExcel.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                swOut.Write(";");
                            }
                            swOut.Write(grdCuartoExcel.Columns[i].HeaderText);
                        }

                        swOut.WriteLine();

                        //write DataGridView rows to csv
                        for (int j = 0; j <= grdCuartoExcel.Rows.Count - 2; j++)
                        {
                            if (j > 0)
                            {
                                swOut.WriteLine();
                            }

                            dr = grdCuartoExcel.Rows[j];

                            for (int i = 0; i <= grdCuartoExcel.Columns.Count - 1; i++)
                            {
                                if (i > 0)
                                {
                                    swOut.Write(";");
                                }

                                value = dr.Cells[i].Value.ToString();
                                //replace comma's with spaces
                                value = value.Replace(';', ' ');
                                //replace embedded newlines with spaces
                                value = value.Replace(Environment.NewLine, " ");

                                swOut.Write(value);
                            }
                        }
                        swOut.Close();
                        MessageBox.Show("Se exporto correctamente");

                    }
                }
            }

        }
        private void buscarUsuarioRCS_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla(); 

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Usuario_rcs] LIKE '%{0}%'", buscarUsuarioRCS.Text);
        }

        
        private void buscarPlataforma_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
            
            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("Plataforma LIKE '%{0}%'", buscarPlataforma.Text);
        }

        private void buscarUsuarioURM_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
            
            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Usuarios_urm] LIKE '%{0}%'", buscarUsuarioURM.Text);
        }

        private void buscarDni_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("DNI LIKE '%{0}%'", buscarDni.Text);
        }

        private void buscarCorreo_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Correo electrónico de usuario] LIKE '%{0}%'", buscarCorreo.Text);
        }

        private void buscarNombre_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre completo de usuario] LIKE '%{0}%'", buscarNombre.Text);
        }

        private void buscarUnidadN_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Unidad de Negocio] LIKE '%{0}%'", buscarUnidadN.Text);
        }

        private void buscarCargo_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cargo LIKE '%{0}%'", buscarCargo.Text);
        }

        private void buscarUnidadOrg_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();

            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[U.Org._rcs] LIKE '%{0}%'", buscarUnidadOrg.Text);
        }

        private void buscarFilial_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
            //(grdCuartoExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("Filial LIKE '%{0}%' and [Usuario_rcs] like '%" + buscarUsuarioRCS.Text + "%'", buscarFilial.Text);
        }

        private void llenarGrilla()
        {
            string consulta = "";

            BindingSource bs = new BindingSource();
            bs.DataSource = grdCuartoExcel.DataSource;

            if (buscarUsuarioRCS.Text != "")
            {

                if (consulta == "")
                {
                    consulta += "[Usuario_rcs] like '%" + buscarUsuarioRCS.Text + "%'";
                }
                else
                {
                    consulta += " and [Usuario_rcs] like '%" + buscarUsuarioRCS.Text + "%'";
                }
            }
            if (buscarPlataforma.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "Plataforma like '%" + buscarPlataforma.Text + "%'";
                }
                else
                {
                    consulta += " and Plataforma like '%" + buscarPlataforma.Text + "%'";
                }

            }
            if (buscarUsuarioURM.Text != "")
            {

                if (consulta =="")
                {
                    consulta += "[Usuarios_urm] like '%" + buscarUsuarioURM.Text + "%'";
                }
                else
                {
                    consulta += " and [Usuarios_urm] like '%" + buscarUsuarioURM.Text + "%'";
                }

            }
            if (buscarDni.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "DNI like '%" + buscarDni.Text + "%'";
                }
                else
                {
                    consulta += "and  DNI like '%" + buscarDni.Text + "%'";
                }
            }
            if (buscarCorreo.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "[Correo electrónico de usuario] like '%" + buscarCorreo.Text + "%'";
                }
                else
                {
                    consulta += "and  [Correo electrónico de usuario] like '%" + buscarCorreo.Text + "%'";
                }
            }
            if (buscarNombre.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "[Nombre completo de usuario] like '%" + buscarNombre.Text + "%'";
                }
                else
                {
                    consulta += "and  [Nombre completo de usuario] like '%" + buscarNombre.Text + "%'";
                }
            }
            if (buscarUnidadN.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "[Unidad de Negocio] like '%" + buscarUnidadN.Text + "%'";
                }
                else
                {
                    consulta += "and  [Unidad de Negocio] like '%" + buscarUnidadN.Text + "%'";
                }
            }
            if (buscarCargo.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "Cargo like '%" + buscarCargo.Text + "%'";
                }
                else
                {
                    consulta += "and  Cargo like '%" + buscarCargo.Text + "%'";
                }
            }
            if (buscarUnidadOrg.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "[U.Org._rcs] like '%" + buscarUnidadOrg.Text + "%'";
                }
                else
                {
                    consulta += "and  [U.Org._rcs] like '%" + buscarUnidadOrg.Text + "%'";
                }
            }
            if (buscarFilial.Text != "")
            {
                if (consulta == "")
                {
                    consulta += "Filial like '%" + buscarFilial.Text + "%'";
                }
                else
                {
                    consulta += "and  Filial like '%" + buscarFilial.Text + "%'";
                }
            }


            bs.Filter = consulta; 
            grdCuartoExcel.DataSource = bs;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            buscarUsuarioRCS.Enabled = false;
            buscarUsuarioURM.Enabled = false;
            buscarDni.Enabled = false;
            buscarCorreo.Enabled = false;
            buscarNombre.Enabled = false;
            buscarPlataforma.Enabled = false;
            buscarUnidadOrg.Enabled = false;
            buscarCargo.Enabled = false;
            buscarUnidadN.Enabled = false;
            buscarFilial.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Desea cerrar el programa?", "Usuarios SAP", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return;
            }
            if (dialogResult == DialogResult.No)
            {
                e.Cancel=true;
            }
        }


    }
}
