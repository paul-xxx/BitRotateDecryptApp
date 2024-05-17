using System;
using System.Text;
using System.Windows.Forms;

namespace BitRotateDecryptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shiftNumericUpDown.Minimum = 0;
            shiftNumericUpDown.Maximum = 10;
        }

        private void shiftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DecryptText();
        }

        private void rawHexTextBox_TextChanged(object sender, EventArgs e)
        {
            DecryptText();
        }

        private void DecryptText()
        {
            string rawHex = rawHexTextBox.Text.Replace(" ", "");
            byte[] rawBytes = StringToByteArray(rawHex);

            int shiftAmount = (int)shiftNumericUpDown.Value;

            byte[] decryptedBytes = new byte[rawBytes.Length];
            Array.Copy(rawBytes, decryptedBytes, rawBytes.Length);

            BitRotateDecrypt(decryptedBytes, decryptedBytes.Length, (byte)shiftAmount);

            string decryptedHex = BitConverter.ToString(decryptedBytes).Replace("-", " ");
            decryptedHexTextBox.Text = decryptedHex;

            string decryptedHexDump = HexDump(decryptedBytes);
            richTextBox1.Text = decryptedHexDump;
        }

        void BitRotateDecrypt(byte[] data, int length, byte shiftAmount)
        {
            byte previous = data[length - 1];

            for (int i = length - 1; i >= 0; --i)
            {
                byte current = (byte)(i <= 0 ? previous : data[i - 1]);
                byte shifted = (byte)(data[i] >> shiftAmount);
                data[i] = (byte)((current << (8 - shiftAmount)) | shifted);
                previous = data[i];
            }
        }

        private static byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                string byteString = hex.Substring(i, 2);
                bytes[i / 2] = Convert.ToByte(byteString, 16);
            }
            return bytes;
        }


        public static string HexDump(byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DecryptText();
        }
    }
}