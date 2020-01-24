using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSAUtillity
{
    public enum KEYTYPE
    {
        NONE = 0,
        MODULUS,
        EXPONENT,
        P,
        Q
    }
    public partial class FormUtillity : Form
    {
        public FormUtillity()
        {
            InitializeComponent();
            //! key size default 128
            this.textBoxKey.Text = "384";
            this.checkBoxBin.Checked = true;
            this.checkBoxXml.Checked = true;
        }

        System.Security.Cryptography.RSAParameters keyinfo;
        string xml_format;


        void GenerateRSAKEY(int dwKyeSize)
        {
            try {
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(dwKyeSize);
                xml_format = rsa.ToXmlString(true);
                keyinfo = rsa.ExportParameters(true);
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void WriteXML()
        {
            if (xml_format == string.Empty) return;
            if (this.checkBoxXml.Checked == false) return;
            using (System.IO.Stream fileStream = new System.IO.FileStream("Keyinfo.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                using (System.IO.StreamWriter streamwrite = new System.IO.StreamWriter(fileStream))
                {
                    streamwrite.Write(xml_format);
                    streamwrite.Flush();
                    streamwrite.Close();
                }
            }
        }

        byte[] streamkey(KEYTYPE type)
        {
            switch (type) 
            {
                case KEYTYPE.MODULUS: return keyinfo.Modulus;
                case KEYTYPE.EXPONENT: return keyinfo.D;
                case KEYTYPE.P: return keyinfo.P;
                case KEYTYPE.Q: return keyinfo.Q;
                default: return new byte[] { };
            }
        }

        void WriteBin(KEYTYPE type)
        {
            if (!this.checkBoxBin.Checked) return;
            string filename = Enum.GetName(typeof(KEYTYPE), type).ToLower() + ".bin";
            using (System.IO.Stream stream = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                using (System.IO.BinaryWriter writing = new System.IO.BinaryWriter(stream))
                {
                    writing.Write(streamkey(type));
                    writing.Flush();
                    writing.Close();
                }
            }
        }

        string HexToString(byte[] b)
        {
            StringBuilder builded = new StringBuilder();
            for (int i = 0; i < b.Length; ++i)
            {
                builded.AppendFormat("{0:x2}", b[i]);
            }
            return builded.ToString().ToUpper();
        }

        void ShowOnBox()
        {
            //! modulus
            this.textBoxN.Text = HexToString(keyinfo.Modulus);
            //! exponent
            this.textBoxD.Text = HexToString(keyinfo.D);
            //! prime P or 1st
            this.textBoxP.Text = HexToString(keyinfo.P);
            //! prime Q or 2nd
            this.textBoxQ.Text = HexToString(keyinfo.Q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int keysize = 0;
            int.TryParse(this.textBoxKey.Text.Trim(),out keysize);

            if (keysize < 384) 
            {
                MessageBox.Show(string.Format(" keysize not supported. should be greather than {0}", keysize));
                return;
            }
            
            GenerateRSAKEY(keysize);
            ShowOnBox();
            WriteXML();
            WriteBin(KEYTYPE.MODULUS);
            WriteBin(KEYTYPE.EXPONENT);
            WriteBin(KEYTYPE.P);
            WriteBin(KEYTYPE.Q);

        }
    }
}
