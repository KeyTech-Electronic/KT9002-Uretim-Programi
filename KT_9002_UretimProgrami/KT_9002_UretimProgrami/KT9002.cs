using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;

namespace KT_9002_UretimProgrami
{
    public partial class KT9002 : Form
    {
        private KeyTechLib ComPort;
        private Process cmdProcess;
        private bool BaglantiDurumu = false;
        private List<string> serialPorts;

        public KT9002()
        {
            InitializeComponent();
        }

        private void KT9002_Load(object sender, EventArgs e)
        {
            InitializeCmd();
            mtxtPublicKey.Mask = "AA:AA:AA:AA:AA:AA";
            SetPlaceholder(txtSeriNo, "Seri numarası 10 haneli olmalıdır");

            serialPorts = KeyTechLib.LoadSerialPortNames();
            cbComPort.Items.Clear();
            cbComPort.Items.AddRange(serialPorts.ToArray());
        }

        private void InitializeCmd()
        {
            cmdProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8

                }
            };

           

            cmdProcess.OutputDataReceived += CmdProcess_OutputDataReceived;
            cmdProcess.ErrorDataReceived += CmdProcess_OutputDataReceived;

            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.BeginErrorReadLine();
        }

        private void CmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                //string correctedData = Encoding.UTF8.GetString(Encoding.Default.GetBytes(e.Data));
                Invoke(new Action(() =>
                {
                    cmdKonsol.AppendText(e.Data + Environment.NewLine);
                    cmdKonsol.SelectionStart = cmdKonsol.Text.Length;
                    cmdKonsol.ScrollToCaret();
                }));
            }
        }

        //private void cbComPort_DropDown(object sender, EventArgs e)
        //{
        //    var serialPorts = KeyTechLib.LoadSerialPortNames();
        //    cbComPort.Items.Clear();
        //    cbComPort.Items.AddRange(serialPorts.ToArray());
        //}

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbComPort.Text))
            {
                MessageBox.Show("Lütfen bir COM port seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnBaglan.Text == "Bağlan")
            {
                try
                {
                    ComPort = new KeyTechLib(cbComPort.Text, 115200);

                    if (ComPort.OpenConnection())
                    {
                        btnBaglan.Text = "Bağlantıyı Kes";
                        BaglantiDurumu = true;
                        MessageBox.Show("Bağlantı başarıyla sağlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComPort.mSerial.DataReceived += SerialPort_DataReceived;
                    }
                    else
                    {
                        throw new Exception("Bağlantı sağlanamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı sağlanılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort?.CloseConnection();
                    btnBaglan.Text = "Bağlan";
                    BaglantiDurumu = false;
                    MessageBox.Show("Bağlantı başarıyla kesildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı kesilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isDataReceivedHandlerAttached = false;

        private void SendCommandToComPort(string cmd)
        {
            if (!BaglantiDurumu || ComPort == null)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Lütfen önce bağlantı kurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ComPort.mSerial.WriteLine(cmd);
                rtxtKonsol.AppendText($"Komut gönderildi: {cmd.Trim()} \n");
               
                /*
                if (!isDataReceivedHandlerAttached)
                {
                   
                    isDataReceivedHandlerAttached = true;
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Komut gönderilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string response = sp.ReadExisting(); // Gelen veriyi oku

                // Hem rtxtKonsol hem de cmd ekranına yaz
                Invoke(new Action(() =>
                {
                    // rtxtKonsol içinde göster
                    rtxtKonsol.AppendText($"[SERİ PORT] Gelen Veri: {response}\n");
                    /*
                    // CMD'ye yaz
                    if (cmdProcess != null && !cmdProcess.HasExited)
                    {
                        cmdProcess.StandardInput.WriteLine($"[SERİ PORT] {response}");
                    }
                    */
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    rtxtKonsol.AppendText($"Hata: {ex.Message}\n");
                    /*
                    // CMD'ye hata mesajını yaz
                    if (cmdProcess != null && !cmdProcess.HasExited)
                    {
                        cmdProcess.StandardInput.WriteLine($"[HATA] {ex.Message}");
                    }
                    */
                }));
            }
        }

        private void btnAktivasyonIptalEt_Click(object sender, EventArgs e)
        {
            if (!BaglantiDurumu || ComPort == null)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Lütfen önce bağlantı kurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SendCommandToComPort("DEAC\n");
        }

        private void btnFabrikaAyarlarinaGeriDon_Click(object sender, EventArgs e)
        {
            if (!BaglantiDurumu || ComPort == null)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Lütfen önce bağlantı kurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SendCommandToComPort("FACR\n");
        }

        private void btnSeriNoGonder_Click(object sender, EventArgs e)
        {
            if (!BaglantiDurumu || ComPort == null)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Lütfen önce bağlantı kurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSeriNo.Text) || !int.TryParse(txtSeriNo.Text, out int seriNo) )
            {
                MessageBox.Show("Geçerli bir seri numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSeriNo.Text.Length != 10)
            {
                MessageBox.Show("Seri Numarası 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SendCommandToComPort("SSNO" + txtSeriNo.Text + "\n");
            txtSeriNo.Text = (seriNo + 1).ToString().PadLeft(10, '0');
        }

        private void btnPublicKeyGonder_Click(object sender, EventArgs e)
        {
            if (!BaglantiDurumu || ComPort == null)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Lütfen önce bağlantı kurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(mtxtPublicKey.Text))
            {
                MessageBox.Show("Lütfen bir public key girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SendCommandToComPort("PKEY"+mtxtPublicKey.Text + "\n");
        }

        private void btnKonsolTemizle_Click(object sender, EventArgs e)
        {
            rtxtKonsol.Clear();
            cmdKonsol.Clear();

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdProcess.StandardInput.WriteLine("cls");
                cmdProcess.StandardInput.Flush();
            }
        }

        private void btnFWyukle_Click(object sender, EventArgs e)
        {
            try
            {
                ComPort.CloseConnection();
            }
            catch (Exception ex)
            {

            }

            string filePath = @"Firmware\Firmware.bat";

            string fileContent = File.ReadAllText(filePath);

            if (cbComPort.Text != "")
            {
                fileContent = fileContent.Replace("#COM_PORT#", cbComPort.Text);
            }
            else
            {
                MessageBox.Show("Com Port Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            cmdProcess.StandardInput.WriteLine(fileContent);
            cmdProcess.StandardInput.Flush();
        }

        public void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        public void RemovePlaceholder(TextBox textBox)
        {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;

        }

        private void txtSeriNo_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtSeriNo);
        }
    }
}
