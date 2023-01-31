using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using Zen.Barcode;

namespace Barcode-QR-CodePrint
{
    public partial class Barcode-QR-CodePrint : Form
    {
        public Barcode-QR-CodePrint()
        {
            InitializeComponent();
        }

        BarcodeLib.Barcode barCode = new BarcodeLib.Barcode();
        private object textBarcode;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Trim() == "")
            {
                MessageBox.Show("Input Barcode", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtWidth.Text.Trim() == "")
            {
                MessageBox.Show("Input Width", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtHeight.Text.Trim() == "")
            {
                MessageBox.Show("Input Height", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            errorProvider1.Clear();
            int nW = Convert.ToInt32(txtWidth.Text.Trim());
            int nH = Convert.ToInt32(txtHeight.Text.Trim());
            barCode.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            type = BarcodeLib.TYPE.CODE128;
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    barCode.IncludeLabel = true;
                    barCode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType),
                        "RotateNoneFlipNone", true);
                    barcode.Image = barCode.Encode(type, txtBarcode.Text, Color.Black, Color.White, nW, nH);
                }

                barcode.Width = barcode.Image.Width;
                barcode.Height = barcode.Image.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics graph = e.Graphics)
            {
                int rowY = 0;
                for (int nJ = 0; nJ < 5; nJ++)
                {
                    int rowX = 0;
                    for (int nI = 0; nI < 8; nI++)
                    {
                        graph.DrawImage(barcode.Image, rowY + 10, 5 + rowX);
                        rowX = rowX + barcode.Height + 32;
                    }
                    rowY = rowY + barcode.Width + 22;
                }
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            printDoc.Print();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            barcode.Image = qrcode.Draw(txtBarcode.Text, 100);
        }
    }
}
