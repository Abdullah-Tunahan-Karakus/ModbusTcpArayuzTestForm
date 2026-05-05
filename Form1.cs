using ModbusTcpKutuphanesi.ModbusMaster;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ModbusTcpArayüzTest1
{
    public partial class Form1 : Form
    {
        private ModbusTcpMaster plc = new ModbusTcpMaster();
        public Form1()
        {
            InitializeComponent();
        }
        //Bağlantı Ayarları
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIp.Text;
                int port = Convert.ToInt32(txtPort.Text);

                plc.Connect(ip, port);
                txtLog.AppendText($"[SYSTEM] {ip}:{port} adresine bağlandı \r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            plc.Disconnect();
            txtLog.AppendText("[SYSTEM] bağlantı kesildi");
        }

        //Veri Okuma Function03
        private async void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int startAddress = Convert.ToInt32(txtReadAddress.Text);
                int quantity = Convert.ToInt32(txtReadQuantity.Text);

                int[] receiveData = await plc.ReadHoldingRegistersAsync(1, startAddress, quantity);
                txtLog.AppendText($"[READ SUCCES] Adres: {startAddress}, Adet: {quantity} \r\n");
                for (int i = 0; i < receiveData.Length; i++)
                {
                    txtLog.AppendText($"--> {startAddress + i} : {receiveData[i]} \r\n ");
                }
                txtLog.AppendText("--------- \r\n");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"[READ ERROR] {ex.Message}\r\n");
            }
        }

        //Tekli Veri Yazma Function06
        private async void btnWriteSingle_Click(object sender, EventArgs e)
        {
            try
            {
                int address = Convert.ToInt32(txtWriteSingleAddress.Text);
                int value = Convert.ToInt32(txtWriteSingleValue.Text);

                bool success = await plc.WriteSingleRegistersAsync(1, address, value);

                if (success)
                    txtLog.AppendText($"[WRİTE SUCCES] Adres: {address}, Yazılan Değer: {value}\r\n");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"[WRİTE ERROR] {ex.Message} \r\n");
            }
        }
        //Çoklu Veri Yazma Function16
        private async void btnWriteMulti_Click(object sender, EventArgs e)
        {
            try
            {
                int startAddress = Convert.ToInt32(txtWriteMultiAddress.Text);
                string rawText = txtWriteMultiValues.Text;
                int[] valuesToWrite = rawText.Split(",")
                                             .Select(val => Convert .ToInt32(val.Trim()))
                                             .ToArray();
                bool success = await plc.WriteMultipleRegistersAsync(1, startAddress, valuesToWrite);
                if (success)
                    txtLog.AppendText($"[MULTI WRİTE SUCCESS] Başlangıç Adresi: {startAddress}, Gönderilen Veri: [{rawText}]\r\n");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"[MULTİ WRİTE ERROR] {ex.Message} \r\n");
            }
           
        }
    }
}