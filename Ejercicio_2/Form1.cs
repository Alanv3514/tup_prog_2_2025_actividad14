using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Ejercicio_1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Sistema miSistema = new Sistema();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto (*.csv)|*.csv";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                // Aquí puedes agregar el código para procesar el archivo seleccionado
                MessageBox.Show("Archivo seleccionado: " + filePath);

                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string? line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] partes = line.Split(';');

                        if (partes.Length == 3)
                        {
                            // Avión
                            Transporte avion = new Avion
                            (
                                double.Parse(partes[0]),
                                partes[1],
                                partes[2]
                            );
                            miSistema.AgregarTransporte(avion);
                        }
                        else if (partes.Length == 4)
                        {
                            // Bus
                            Transporte bus = new Bus(
                                double.Parse(partes[0]),
                                partes[1],
                                partes[2],
                                int.Parse(partes[3])
                            );
                            miSistema.AgregarTransporte(bus);

                        }
                    }
                }
                cbDestino.Items.Clear();
                cbDestino.Items.AddRange(miSistema.destinoList.ToArray());

            }
            else
            {
                //lo levanto del serializado .bin
                MessageBox.Show("No se seleccionó ningún archivo.");
                FileStream fs = new FileStream("sistema.bin", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                miSistema = (Sistema)formatter.Deserialize(fs);

                cbDestino.Items.AddRange(miSistema.destinoList.ToArray());
                cbDestino.SelectedIndex = 0;

                fs.Close();


            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //guardamos un sistema.bin
            FileStream fs = new FileStream("sistema.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, miSistema);
            fs.Close();
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            //Genero un ticket y lo agrego al sistema
            string destinoSeleccionado = cbDestino.SelectedItem.ToString();
            double precioBase = double.Parse(tbPrecio.Text);
            string patente = cbTransporte.Text;
            string cuil = tbCUIT.Text;
            string nombre = tbNombre.Text;
            string telefono = tbTelefono.Text;
            string nroTarjeta = tbNumeroTarjeta.Text;

            Transporte p = miSistema.transporteList.Find(t => t.Patente == patente && t.Destino == destinoSeleccionado);
            Pasajero pasajero = new Pasajero(cuil, nombre, telefono, nroTarjeta);
            if (p != null && destinoSeleccionado != null)
            {

                miSistema.CrearTicket(destinoSeleccionado, p, pasajero);
            }
            else
            {
                MessageBox.Show("Transporte o destino no válido.");
            }




        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            //Muestro la lista de tickets en un MessageBox
            string[] listaTickets = miSistema.VerListaTickets();
            string mensaje = "Lista de Tickets:\n";
            foreach (string ticket in listaTickets)
            {
                mensaje += ticket + "\n";
            }
            MessageBox.Show(mensaje);



        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTransporte.Items.Clear();
            string d = cbDestino.SelectedItem.ToString();
            string[] res = miSistema.VerListaTransporte(d);
            MessageBox.Show(res[1]);
            cbTransporte.Items.AddRange(res);

        }
    }
}
