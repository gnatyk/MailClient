﻿using System;
using System.Windows.Forms;

namespace MailClient.CryptoPlugin
{
    public partial class KeyphrasePromptWindow : Form
    {
        public KeyphrasePromptWindow()
        {
            InitializeComponent();
        }

        public String PromptForPassPhrase()
        {
            ShowDialog();
            if (textBox1.Text.Trim().Length == 0)
                return null;
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) 
                Close();
            if (textBox1.Text.Length < 6)
                MessageBox.Show("Key should be at least 6 characters long");
            else
                Close();
        }
    }
}