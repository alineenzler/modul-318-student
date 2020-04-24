using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace MySwissTranport
{
    public partial class MySwissTransport : Form
    {
        private Stations stations;
        private Connections connections;
        private ITransport transport;
        private StationBoardRoot stationBoard;
        private Connection connection;
        private ConnectionPoint connectionpoint;

        public MySwissTransport()
        {
            InitializeComponent();

            stations = new Stations();
            connections = new Connections();
            transport = new Transport();
            stationBoard = new StationBoardRoot();
            connection = new Connection();
            connectionpoint = new ConnectionPoint();


            //Uhrzeiten der ComboBox
            comboBoxZeit.Items.Add("00:00");
            comboBoxZeit.Items.Add("01:00");
            comboBoxZeit.Items.Add("02:00");
            comboBoxZeit.Items.Add("03:00");
            comboBoxZeit.Items.Add("04:00");
            comboBoxZeit.Items.Add("05:00");
            comboBoxZeit.Items.Add("06:00");
            comboBoxZeit.Items.Add("07:00");
            comboBoxZeit.Items.Add("08:00");
            comboBoxZeit.Items.Add("09:00");
            comboBoxZeit.Items.Add("10:00");
            comboBoxZeit.Items.Add("11:00");
            comboBoxZeit.Items.Add("12:00");
            comboBoxZeit.Items.Add("13:00");
            comboBoxZeit.Items.Add("14:00");
            comboBoxZeit.Items.Add("15:00");
            comboBoxZeit.Items.Add("16:00");
            comboBoxZeit.Items.Add("17:00");
            comboBoxZeit.Items.Add("18:00");
            comboBoxZeit.Items.Add("19:00");
            comboBoxZeit.Items.Add("20:00");
            comboBoxZeit.Items.Add("21:00");
            comboBoxZeit.Items.Add("22:00");
            comboBoxZeit.Items.Add("23:00");

            comboBoxZeit.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void buttonSuchen_Click(object sender, EventArgs e)
        {

            Stations StartStation = transport.GetStations(textBoxVon.Text);
            Stations EndStation = transport.GetStations(textBoxNach.Text);

            if (StartStation.StationList.Count > 0 && EndStation.StationList.Count <= 0)
            {
                //Anzeige welcher Fahrplan gewählt wurde
                labelNach2.Text = " ";
                labelEnd.Text = " ";
                labelVon2.Text = "Station:";
                labelStart.Text = StartStation.StationList[0].Name;

                var stations = transport.GetStationBoard(StartStation.StationList[0].Name);
                foreach (var station in stations.Entries)
                {
                    //listBoxFahrplan.Items.Add();
                }
            }

            else
            {
                
                if(StartStation.StationList.Count > 0 && EndStation.StationList.Count > 0)
                {
                    //Label Änderungen
                    labelVon2.Text = "Von";
                    labelNach2.Text = "Nach";
                    labelStart.Text = StartStation.StationList[0].Name;
                    labelEnd.Text = EndStation.StationList[0].Name;

                    //Löschen von vorherigen ListBoxen
                    listBoxAbfahrt.Items.Clear();
                    listBoxAnkunft.Items.Clear();
                    listBoxDauer.Items.Clear();

                    Connections Departure = transport.GetConnections(StartStation.StationList[0].Name, EndStation.StationList[0].Name);
                    foreach (var connectionpoint in Departure.ConnectionList)
                    {
                        listBoxAbfahrt.Items.Add(connectionpoint.From.Departure);
                    }

                    Connections Arrival = transport.GetConnections(StartStation.StationList[0].Name, EndStation.StationList[0].Name);
                    foreach (var connectionpoint in Arrival.ConnectionList)
                    {
                        listBoxAnkunft.Items.Add(connectionpoint.To.Arrival);
                    }

                    Connections Duration = transport.GetConnections(StartStation.StationList[0].Name, EndStation.StationList[0].Name);
                    foreach (Connection connection in Duration.ConnectionList)
                    {
                        listBoxDauer.Items.Add(connection.Duration);
                    }
                }

                else
                {
                    MessageBox.Show("Bitte beachten Sie, dass der Startort immer angegeben werden muss!"); //Error Nachricht, wenn keine Stationen eingegeben wurden
                }
            }
            //Löschen von vorherigen Eingaben
            textBoxVon.Clear();
            textBoxNach.Clear();

        }

        private void textBoxVon_TextChanged(object sender, EventArgs e)
        {
            listBoxDropDownVon.Items.Clear();
            Stations Vorschlag = transport.GetStations(textBoxVon.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                listBoxDropDownVon.Items.Add(station.Name);
            }
        }


        private void textBoxNach_TextChanged(object sender, EventArgs e)
        {
            listBoxDropDownNach.Items.Clear();
            Stations Vorschlag = transport.GetStations(textBoxNach.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                listBoxDropDownNach.Items.Add(station.Name);
            }
        }

        private void buttonNormalMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.MidnightBlue;

            groupBoxApp.BackColor = Color.White;
            groupBoxApp.ForeColor = Color.Black;

            groupBoxVerbindungen.BackColor = Color.White;
            groupBoxVerbindungen.ForeColor = Color.Black;

            groupBoxFahrplan.BackColor = Color.White;
            groupBoxFahrplan.ForeColor = Color.Black;

            buttonSuchen.BackColor = Color.MidnightBlue;
            buttonSuchen.ForeColor = Color.White;

            buttonNormalMode.BackColor = Color.MidnightBlue;
            buttonNormalMode.ForeColor = Color.White;

            buttonPinkMode.BackColor = Color.MidnightBlue;
            buttonPinkMode.ForeColor = Color.White;

            buttonDarkMode.BackColor = Color.MidnightBlue;
            buttonDarkMode.ForeColor = Color.White;

            textBoxVon.BackColor = Color.White;
            textBoxVon.ForeColor = Color.Black;

            textBoxNach.BackColor = Color.White;
            textBoxNach.ForeColor = Color.Black;

            comboBoxZeit.BackColor = Color.White;
            comboBoxZeit.ForeColor = Color.Black;

            listBoxAbfahrt.BackColor = Color.White;
            listBoxAbfahrt.ForeColor = Color.Black;

            listBoxAnkunft.BackColor = Color.White;
            listBoxAnkunft.ForeColor = Color.Black;

            listBoxDauer.BackColor = Color.White;
            listBoxDauer.ForeColor = Color.Black;

            listBoxDropDownVon.BackColor = Color.White;
            listBoxDropDownVon.ForeColor = Color.Black;

            listBoxDropDownNach.BackColor = Color.White;
            listBoxDropDownNach.ForeColor = Color.Black;

            listBoxFahrplan.BackColor = Color.White;
            listBoxFahrplan.ForeColor = Color.Black;

            labelVon2.BackColor = Color.White;
            labelVon2.ForeColor = Color.Black;

            labelNach2.BackColor = Color.White;
            labelNach2.ForeColor = Color.Black;
        }

        private void buttonPinkMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 150, 197);

            groupBoxApp.BackColor = Color.FromArgb(255, 195, 216);
            groupBoxApp.ForeColor = Color.Black;

            groupBoxVerbindungen.BackColor = Color.FromArgb(255, 195, 216);
            groupBoxVerbindungen.ForeColor = Color.Black;

            groupBoxFahrplan.BackColor = Color.FromArgb(255, 195, 216);
            groupBoxFahrplan.ForeColor = Color.Black;

            buttonSuchen.BackColor = Color.FromArgb(255, 150, 197);
            buttonSuchen.ForeColor = Color.Black;

            buttonNormalMode.BackColor = Color.FromArgb(255, 150, 197);
            buttonNormalMode.ForeColor = Color.Black;

            buttonPinkMode.BackColor = Color.FromArgb(255, 150, 197);
            buttonPinkMode.ForeColor = Color.Black;

            buttonDarkMode.BackColor = Color.FromArgb(255, 150, 197);
            buttonDarkMode.ForeColor = Color.Black;

            textBoxVon.BackColor = Color.FromArgb(255, 195, 216);
            textBoxVon.ForeColor = Color.Black;

            textBoxNach.BackColor = Color.FromArgb(255, 195, 216);
            textBoxNach.ForeColor = Color.Black;

            comboBoxZeit.BackColor = Color.FromArgb(255, 195, 216);
            comboBoxZeit.ForeColor = Color.Black;

            listBoxAbfahrt.BackColor = Color.FromArgb(255, 195, 216);
            listBoxAbfahrt.ForeColor = Color.Black;

            listBoxAnkunft.BackColor = Color.FromArgb(255, 195, 216);
            listBoxAnkunft.ForeColor = Color.Black;

            listBoxDauer.BackColor = Color.FromArgb(255, 195, 216);
            listBoxDauer.ForeColor = Color.Black;

            listBoxDropDownVon.BackColor = Color.FromArgb(255, 195, 216);
            listBoxDropDownVon.ForeColor = Color.Black;

            listBoxDropDownNach.BackColor = Color.FromArgb(255, 195, 216);
            listBoxDropDownNach.ForeColor = Color.Black;

            listBoxFahrplan.BackColor = Color.FromArgb(255, 195, 216);
            listBoxFahrplan.ForeColor = Color.Black;

            labelVon2.BackColor = Color.FromArgb(255, 195, 216);
            labelVon2.ForeColor = Color.Black;

            labelNach2.BackColor = Color.FromArgb(255, 195, 216);
            labelNach2.ForeColor = Color.Black;
        }

        private void buttonDarkMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(41, 44, 49);

            groupBoxApp.BackColor = Color.FromArgb(30, 32, 36);
            groupBoxApp.ForeColor = Color.White;

            groupBoxVerbindungen.BackColor = Color.FromArgb(30, 32, 36);
            groupBoxVerbindungen.ForeColor = Color.White;

            groupBoxFahrplan.BackColor = Color.FromArgb(30, 32, 36);
            groupBoxFahrplan.ForeColor = Color.White;

            buttonSuchen.BackColor = Color.FromArgb(23, 24, 28);
            buttonSuchen.ForeColor = Color.White;

            buttonNormalMode.BackColor = Color.FromArgb(23, 24, 28);
            buttonNormalMode.ForeColor = Color.White;

            buttonPinkMode.BackColor = Color.FromArgb(23, 24, 28);
            buttonPinkMode.ForeColor = Color.White;

            buttonDarkMode.BackColor = Color.FromArgb(23, 24, 28);
            buttonDarkMode.ForeColor = Color.White;

            textBoxVon.BackColor = Color.FromArgb(23, 24, 28);
            textBoxVon.ForeColor = Color.White;

            textBoxNach.BackColor = Color.FromArgb(23, 24, 28);
            textBoxNach.ForeColor = Color.White;

            comboBoxZeit.BackColor = Color.FromArgb(23, 24, 28);
            comboBoxZeit.ForeColor = Color.White;

            listBoxAbfahrt.BackColor = Color.FromArgb(30, 32, 36);
            listBoxAbfahrt.ForeColor = Color.White;

            listBoxAnkunft.BackColor = Color.FromArgb(30, 32, 36);
            listBoxAnkunft.ForeColor = Color.White;

            listBoxDauer.BackColor = Color.FromArgb(30, 32, 36);
            listBoxDauer.ForeColor = Color.White;

            listBoxDropDownVon.BackColor = Color.FromArgb(30, 32, 36);
            listBoxDropDownVon.ForeColor = Color.White;

            listBoxDropDownNach.BackColor = Color.FromArgb(30, 32, 36);
            listBoxDropDownNach.ForeColor = Color.White;

            listBoxFahrplan.BackColor = Color.FromArgb(30, 32, 36);
            listBoxFahrplan.ForeColor = Color.White;

            labelVon2.BackColor = Color.FromArgb(30, 32, 36);
            labelVon2.ForeColor = Color.White;

            labelNach2.BackColor = Color.FromArgb(30, 32, 36);
            labelNach2.ForeColor = Color.White;
        }

        private void listBoxDropDownVon_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxVon.Text = Convert.ToString(listBoxDropDownVon.SelectedItem);
        }

        private void listBoxDropDownNach_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNach.Text = Convert.ToString(listBoxDropDownNach.SelectedItem);
        }
    }
}
