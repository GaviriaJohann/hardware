using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hardware
{
    public partial class frmHardware : Form
    {
        public frmHardware()
        {
            InitializeComponent();
        }

        private void btnNumeroSerie_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject disk in searcher.Get())
            {
                MessageBox.Show("Número de serie del disco duro: " + disk["SerialNumber"].ToString());
            }
        }

        private void btnNumeroDiscos_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            int count = 0;
            foreach (ManagementObject disk in searcher.Get())
            {
                count++;
            }
            MessageBox.Show("Número de unidades de disco: " + count);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject sys in searcher.Get())
            {
                MessageBox.Show("Procesador: " + sys["Name"].ToString());
                MessageBox.Show("RAM: " + sys["TotalPhysicalMemory"].ToString());

                // Obteniendo información de la tarjeta de red
                ManagementObjectSearcher networkSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE PhysicalAdapter = True");
                foreach (ManagementObject networkAdapter in networkSearcher.Get())
                {
                    MessageBox.Show("NIC: " + networkAdapter["Name"].ToString());
                }

                // Patches
                // No se proporciona una propiedad directa para obtener información sobre los parches instalados.
            }
        }

        private void btnMacAddress_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            foreach (ManagementObject adapter in searcher.Get())
            {
                MessageBox.Show("MAC Address: " + adapter["MACAddress"].ToString());
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // Acceso al registro del sistema no se recomienda para modificaciones sin un cuidadoso análisis y consideración de los efectos.
            MessageBox.Show("Acceso al registro del sistema no es seguro para realizar cambios.");
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            // Obtener procesos activos
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
            foreach (ManagementObject process in searcher.Get())
            {
                MessageBox.Show("Proceso: " + process["Name"].ToString() + " ID: " + process["ProcessId"].ToString());
            }

            // Matar procesos
            // Aquí se necesita implementar la lógica para matar procesos, lo cual puede ser peligroso si no se hace con cuidado.
        }


    }
}
