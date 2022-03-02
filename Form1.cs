using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //nye
using System.IO.Ports;                                  //for å koble på arduinoen
using System.IO;                                        //StramWriter and StreamReader
using System.Globalization;                             //DateTime info 
using System.Windows.Forms.DataVisualization.Charting;  //graf
using Microsoft.VisualBasic;                            //passord
using System.Data.SqlClient;
using System.Configuration;

namespace Arbeidskrav1
{

    public partial class Form1 : Form
    {
        string conSoftSensConf = ConfigurationManager.ConnectionStrings["conSoftSensConf"].ConnectionString;
        //listen grafen
        List<float> yValues = new List<float>();
        List<float> xValues = new List<float>();
        //rydde grafen
        float xval1 = 0;
        float yval1 = 0;
        String chartvar1 = "";
        String chartvar2 = "";
        //Samme variabel separert med ";"
        string[] separateParts = {};
        string melding;
        string sqlQuery;
        int timerhz;
        
        public Form1()
        {
            

            InitializeComponent();

            //hz
            comboBoxHz1.Items.AddRange(Enumerable.Range(1, 1000).Select(i => (object)i).ToArray());
            comboBoxHz1.SelectedIndex = 4;
            timerhz = comboBoxHz1.SelectedIndex;

            //til comboBoxCOM1 for å hente inn COM Portene som er i bruk
            comboBoxCOM1.Items.AddRange(SerialPort.GetPortNames());
            comboBoxCOM1.Text = "--Select--";

            //til comboBoxBitRate1 for å foreslå bit rates.
            string[] bitRate = new string[] { "1200", "2400", "4800", "9600",       //bit rate hentet fra google "søke ord: arduino bit rate"
                                              "19200", "38400", "57600", "115200" };
            comboBoxBitRate1.Items.AddRange(bitRate);
            comboBoxBitRate1.SelectedIndex = comboBoxBitRate1.Items.IndexOf("9600");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

            //Timer for å se lese av analog signaler automatisk
            timerChart1.Interval = 1000 * timerhz;
            timerChart1.Tick += new EventHandler(timer1_Tick);
            //Timer for connection status
            timerCon.Interval = 1000;

            


        }



        //serial
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            float iLightChart;
            string RecievedData = ((SerialPort)sender).ReadLine();
            //data mottatt
            if (!RecievedData.Contains(";"))
            {
                textBoxLog1.Invoke((MethodInvoker)delegate
                 {
                     textBoxLog1.AppendText("Recieved: " + RecievedData + ":" + "   " + DateTime.Now + "\r\n");
                 });
            }

            //separerer data mottatt
            else
            {
                separateParts = RecievedData.Split(';');

                textBoxLog1.Invoke((MethodInvoker)(() =>
                {
                    textBoxLog1.AppendText("Recieved: ");
                    
                        for (int i = 0; i < separateParts.Length; i++)
                        {
                            textBoxLog1.AppendText(separateParts[i] + " ");
                        }
                    
                    textBoxLog1.AppendText("   " + DateTime.Now + "\r\n");
                    
                }));
            }





            //lager grafen
            if (melding == "readraw" || melding == "readscaled" && timerChart1.Enabled)
            {
                float.TryParse(RecievedData, out iLightChart);
                string tag = textBoxName.Text;
                float timestamp = 0;


                try
                {
                    yval1 = iLightChart;
                    yValues.Add(yval1);
                    xValues.Add(xval1);
                    xval1 += timerhz;
                    chartLight1.Invoke((MethodInvoker)(() => { chartLight1.Series["LightChart"].Points.DataBindXY(xValues, yValues); })); //Invoke for å løse debugging problemet
                    chartLight1.Invoke((MethodInvoker)(() => { chartLight1.Invalidate(); }));                                             //function kan ikke bli kalt på inne i en thread...
                    textBoxLog2.Invoke((MethodInvoker)delegate
                    { textBoxLog2.AppendText("Recieved: " + iLightChart + " " + chartvar2 + "\r\n"); });




                        SqlConnection con = new SqlConnection(conSoftSensConf);
                        sqlQuery = String.Concat(@"INSERT INTO DataLog VALUES ('", tag, "', '", timestamp, "', '", xval1, "', '", yval1, "', '", chartvar1, "')"); //Setter variabelene inne i sql row
                        con.Open();
                        SqlCommand command = new SqlCommand(sqlQuery, con);
                        command.ExecuteNonQuery();
                        con.Close();
  
                    timestamp += 1;



                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


                //leser statusen til sensoren
                if (melding == "readstatus") 
            {
                float status;
                float.TryParse(RecievedData, out status);
                conf c = new conf();
                string g = c.Status(status);
                labelStatus1.Text = g;
                textBoxLog1.AppendText(g);
            }
            //leser konfigurasjon til arduinoen
            if (melding == "readconf")
            {
                Invoke((MethodInvoker)(() => {
                    textBoxName.Text = separateParts[0];
                    textBoxlrv.Text = separateParts[1];
                    textBoxurv.Text = separateParts[2];
                    textBoxalarmL.Text = separateParts[3];
                    textBoxalarmH.Text = separateParts[4];}));
            }
        }

            //connect
            private void buttonConnect1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxCOM1.Text;
                serialPort1.Open();
                textBoxLog1.AppendText("Tilkoblet!" + ":" + "   " + DateTime.Now + "\r\n");
                timerCon.Start();
            }


            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    MessageBox.Show("Er enheten koblet til?");
                }
            }


            finally
            {
                if (comboBoxCOM1.Text.Contains("COM") && !serialPort1.IsOpen)
                {
                    comboBoxCOM1.Text = "--Select--";
                    MessageBox.Show("Er enheten koblet til?");
                }
            }
        }


        //Disconnect
            private void buttonDisconnect1_Click(object sender, EventArgs e)
        {
  
                if (timerChart1.Enabled)
                {
                    DialogResult result = MessageBox.Show
                    ("Auto read er på! ønsker du avslutte?", "Krasj", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        serialPort1.Close();
                        textBoxLog1.AppendText("Frakoblet" + ":" + "   " + DateTime.Now + "\r\n");
                        Application.Exit();
                    }
                }


                else
                {
                    serialPort1.Close();
                    textBoxLog1.AppendText("Frakoblet!" + ":" + "   " + DateTime.Now + "\r\n");
                }
            
 
        }


        //send til arduino
            private void buttonSend1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(textBoxSend1.Text);
                }
                else
                {
                    MessageBox.Show("Er enheten koblet til?");
                }
            }
            catch
            {
                MessageBox.Show("Now gikk galt?");
            }
        }



        //Configuration change
        //sender informasjon med "writeconf" til arduino
        private void buttonSendArd1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string passord = Interaction.InputBox("Enter Password", "Enter Password");
                if (passord == "password")
                {
                    MessageBox.Show("Success");
                    string newconf = (textBoxName.Text + ";" + textBoxlrv.Text + ";" + textBoxurv.Text + ";" + textBoxalarmL.Text + ";" + textBoxalarmH.Text);
                    serialPort1.WriteLine("writeconf>"+ passord+ ">" + newconf);
                    melding = "writeconf";
                }

                else
                {
                    MessageBox.Show("Wrong Password");
                }
                
            }
            else
            {
                MessageBox.Show("Er enheten koblet til?");
            }
        }


        //henter informasjon med "readconf" fra arduino
        private void buttonRetrieveArd1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readconf");
                melding = "readconf";
            }
            else
            {
                MessageBox.Show("Er enheten koblet til?");
            }
        }


        //lagrer parameter til lokal bestemt fil "conf1.ssc"
        private void buttonSaveParameter_Click(object sender, EventArgs e)
        {
            string Description;
            float lrv, urv, alarmL, alarmH;


            try
                {
                    //Oppretter en connection mot databasen med string definert i App.config:
                SqlConnection con = new SqlConnection(conSoftSensConf);
                Description = textBoxName.Text; //Verdien som skal inn i databasen
                lrv = float.Parse(textBoxlrv.Text);
                urv = float.Parse(textBoxurv.Text);
                alarmL = float.Parse(textBoxalarmL.Text);
                alarmH = float.Parse(textBoxalarmH.Text);

                //hentes fra combobox og lagres i carMake-variabelen
                // Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen
                sqlQuery = String.Concat(@"INSERT INTO Configuration VALUES ('", lrv, "','", urv, "','", alarmL, "','", alarmH, "','", Description, "')"); //Setter variabelene i row inne i sql

                con.Open();    
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.ExecuteNonQuery();    
                con.Close();
                sqlQuery = @"SELECT * FROM  ORDER BY DataLog ASC";
                ViewSqlResultInDataGridView(sqlQuery);

            }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            
        }

        void ViewSqlResultInDataGridView(string sqlQuery)
        {
            try
            {
                SqlConnection con = new SqlConnection(conSoftSensConf);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Configuration", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                
                dataGridView1.DataSource = dt;
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //henter parameter fra databasen
        private void buttonRetrieveParameter_Click(object sender, EventArgs e)
        {

            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex; //henter row fra grid
                textBoxName.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(); // henter ut cellen fra utvalgt row
                textBoxlrv.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(); // 
                textBoxurv.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(); // 
                textBoxalarmL.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(); // 
                textBoxalarmH.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(); // 

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //lagrer parameter i filtype ".ssc" hvor du vil (eks: usbpinne)
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            saveFileDialog1.InitialDirectory = "C:\\tmp";
            saveFileDialog1.Filter = ("ssc Files | *.ssc");
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = "";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file  
                fileName = saveFileDialog1.FileName;
                StreamWriter outputFile = new StreamWriter(@fileName);
                outputFile.Write(textBoxName.Text + ";" + textBoxlrv.Text + ";" + textBoxurv.Text + ";" + textBoxalarmL.Text + ";" + textBoxalarmH.Text);
                outputFile.Close();
                textBoxLog1.AppendText("Lagret ny Parameter til local fil" + "\r\n");
            }
        }


        //henter parameter i filtype ".ssc" fra hvor du vil (eks: usbpinne)
        private void buttonViewFile1_Click(object sender, EventArgs e)
        {
                string fileName = string.Empty;
                openFileDialog1.InitialDirectory = "C:\\tmp";
                openFileDialog1.Filter = ("ssc Files | *.ssc"); //dette er også satt opp på selve openFileDialog1 inne Form1.cs[Design] 
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                { 
                fileName = openFileDialog1.FileName;
                StreamReader inputFile = new StreamReader(@fileName);
                string inputFileRead = inputFile.ReadToEnd();
                string[] list = inputFileRead.Split(';');
                textBoxName.Text = list[0];
                textBoxlrv.Text = list[1];
                textBoxurv.Text = list[2];
                textBoxalarmL.Text = list[3];
                textBoxalarmH.Text = list[4];
                inputFile.Close();
            }
        }
        

        //timer for grafens (5sekunder x-akse)
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.WriteLine(chartvar1);
                melding = chartvar1;
                
            }
            catch
            {
                MessageBox.Show("Grafen har stopet!");
                timerChart1.Stop();
            }
        }


        // stopper lesingen av grafen og spør om du vil lagre
        private void buttonManuelRead1_Click(object sender, EventArgs e)
        {
            textBoxSend1.ReadOnly = false;
            timerChart1.Stop();
            textBoxName.ReadOnly = false;
            textBoxlrv.ReadOnly = false;
            textBoxurv.ReadOnly = false;
            textBoxalarmL.ReadOnly = false;
            textBoxalarmH.ReadOnly = false;
            DialogResult result = MessageBox.Show
            ("Grafen har stoppet");

 
            /*if (result == DialogResult.Yes)
                
            {  
                StreamWriter outputFile = new StreamWriter(@"C:\tmp\Sensor1_" + chartvar1 + ".csv");
                for(int i = 0; i < xValues.Count; i++)
                { 
                    outputFile.Write("Timestamp{0}," + "Value[{1},{2}];", i, xValues[i], yValues[i]);
                }  
                outputFile.Close();
                }*/
        }
        

        // Starter timer og grafen
        private void buttonAutoRead1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (chartvar1 == "readraw" || chartvar1 == "readscaled")
                {
                    melding = chartvar1;
                    textBoxSend1.Text = "";
                    textBoxSend1.ReadOnly = true;
                    timerChart1.Start();
                    textBoxName.ReadOnly = true;
                    textBoxlrv.ReadOnly = true;
                    textBoxurv.ReadOnly = true;
                    textBoxalarmL.ReadOnly = true;
                    textBoxalarmH.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Har du valgt en måleenhet?", "Chart error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }


            else
            {
                MessageBox.Show("Porten er ikke åpen!");
            }
        }
        // Bestemer enhent til grafen
        private void radioButtonRaw1_CheckedChanged(object sender, EventArgs e)
        {
            if (chartvar1 == "readscaled" && timerChart1.Enabled)
            {
                radioButtonRaw1.Checked = false;
                radioButtonScaled1.Checked = true;
                DialogResult result = MessageBox.Show
                    ("Programet kjører", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                chartvar1 = "readraw";
                chartvar2 = "raw";
            }
        }

        private void radioButtonScaled1_CheckedChanged(object sender, EventArgs e)
        {
            if (chartvar1 == "readraw" && timerChart1.Enabled)
            {
                radioButtonScaled1.Checked = false;
                radioButtonRaw1.Checked = true;
                DialogResult result = MessageBox.Show
                    ("Programet gjører", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                chartvar1 = "readscaled";
                chartvar2 = "scaled";
            }
        }
        //restarter grafen
        private void buttonClearChart1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Ønsker du å slette grafen", "Chart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                textBoxSend1.ReadOnly = false;
                textBoxLog2.Text = "";
                timerChart1.Stop();
                xval1 = 0;
                yval1 = 0;
                yValues.Clear();
                xValues.Clear();
                chartLight1.Series["LightChart"].Points.Clear();
            }
            else
            {
                timerChart1.Stop();
            }
        }

        private void buttonUpdateStatus1_Click(object sender, EventArgs e)
        {
                try
                {
                if (!timerChart1.Enabled)
                {
                    serialPort1.WriteLine("readstatus");
                    melding = "readstatus";
                }
                else
                {
                    MessageBox.Show("Grafen leser");
                }
                }
                catch
                {
                    MessageBox.Show("Noe gikk galt");
                }
        }

        private void timerCon_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                labelConnect1.Text = "Connected";
                labelConnected2.Text = "Connected";
                labelConnected3.Text = "Connected";
            }
            else
            {
                labelConnect1.Text = "Disconnected";
                labelConnected2.Text = "Disconnected";
                labelConnected3.Text = "Disconnected";
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT * FROM  ORDER BY DataLog ASC";
            ViewSqlResultInDataGridView(sqlQuery);
           if (serialPort1.IsOpen && !timerChart1.Enabled)
            {
                serialPort1.WriteLine("readconf");
                melding = "readconf";
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string qu;
            float lrv, urv, alarmL, alarmH;
            string Description;

            try
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex; //henter row fra grid

                var s = float.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString()); // henter ut cellen fra griden med utvalgt celle // måtte gjøre den til string og så float, object kan ikke gjøres direkte til float
                lrv = float.Parse(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
                urv = float.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString()); 
                alarmL = lrv = float.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString()); 
                alarmH = lrv = float.Parse(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
                Description = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                
                SqlConnection con = new SqlConnection(conSoftSensConf);
                SqlDataAdapter adapter = new SqlDataAdapter();
                
                qu = "update Configuration set lrv='" + lrv + "', urv='" + urv + "', alarmL='" + alarmL + "', alarmH='" + alarmH + "', Description='" + Description + "' where ConffigId='" + s + "'"; //editer row i databasen der iden passer med iden fra datagrid.
                //qu = String.Concat(@"update Configuration set lrv='" + lrv + "',urv='" + urv + "',alarmL='" + alarmL + "',alarmH'" + alarmH + "',Description='" + Description + "' where ConffigId='" + s + "'");
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = qu;
                adapter.UpdateCommand.ExecuteNonQuery();

                //SqlCommand command = new SqlCommand(qu, con);

                //command.ExecuteNonQuery();
                con.Close();

                

                sqlQuery = @"SELECT * FROM  ORDER BY DataLog ASC"; //oppdaterer datagrid for å se endringen.
                ViewSqlResultInDataGridView(sqlQuery);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string qu;

            try
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex; //henter row fra grid
                //dataGridView1.Rows.RemoveAt(rowIndex); fjerner bare for datagrid, (byttes ut med oppdaterings koden under)
                var s = dataGridView1.Rows[rowIndex].Cells[0].Value; // henter ut cellen fra griden med id
                SqlConnection con = new SqlConnection(conSoftSensConf);
                qu = "DELETE FROM Configuration where ConffigId=" + s; //sletter row fra databasen der iden passer med iden fra datagrid.

                con.Open();
                SqlCommand command = new SqlCommand(qu, con);
                
                command.ExecuteNonQuery();
                con.Close();
                

                sqlQuery = @"SELECT * FROM  ORDER BY DataLog ASC"; //oppdaterer datagrid for å se endringen.
                ViewSqlResultInDataGridView(sqlQuery);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        
        }

        private void buttonUpdate2_Click(object sender, EventArgs e)
        {
            sqlQuery = @"SELECT * FROM  ORDER BY DataLog ASC";
            ViewSqlResultInDataGridView(sqlQuery);
        }
    }
}