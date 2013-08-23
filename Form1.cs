using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RandomKeyGenerator
{
    public partial class RkgForm : Form
    {
        public RkgForm() {
            InitializeComponent();
            txtNumberOfCharacters.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtResultsBox.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            int numberOfCharacters;
            if (!int.TryParse(txtNumberOfCharacters.Text, out numberOfCharacters))
                throw new Exception(string.Format("Unable to parse {0} to a number.", txtNumberOfCharacters.Text));
            string result = GetRandomAlphanumericString(numberOfCharacters);
            Clipboard.SetText(result);
            txtResultsBox.Text = result + Environment.NewLine + txtResultsBox.Text; ;
        }

        /// <summary>
        /// Stolen from http://stackoverflow.com/questions/1344221/how-can-i-generate-random-8-character-alphanumeric-strings-in-c
        /// </summary>
        public string GetRandomAlphanumericString(int length) {
            string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz";
            if (chkIncludeSpecial.Checked)
                alphanumericCharacters = alphanumericCharacters + "0123456789,./;'[]`~!@#$%^&*()_+-=<>?:\"{}|\\";
            return GetRandomString(length, alphanumericCharacters);
        }
        public string GetRandomString(int length, IEnumerable<char> characterSet) {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 4) // 500 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 4];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            var result = new char[length];
            for (int i = 0; i < length; i++) {
                uint value = BitConverter.ToUInt32(bytes, i * 4);
                result[i] = characterArray[value % characterArray.Length];
            }
            return new string(result);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            base.Close();
        }
    }
}
