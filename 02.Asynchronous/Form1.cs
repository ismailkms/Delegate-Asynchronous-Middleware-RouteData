using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Asynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            Carp(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private async void btnCarpAsync_Click(object sender, EventArgs e)
        {
            await CarpAsync(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            //await yanındaki işlem sonuçlanana kadar alttaki işlemlere geçmeyi engeller. Sonuçlandıktan sonra bir sonraki satıra geçer.
            MessageBox.Show("İşlem tamamlandı");
        }

        private void Topla(int number1, int number2)
        {
            MessageBox.Show($"Toplam = {number1 + number2}");
        }

        private void Carp(int number1, int number2)
        {
            Thread.Sleep(5000);
            MessageBox.Show($"Çarpım = {number1 * number2}");
        }

        private Task CarpAsync(int number1, int number2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show($"Çarpım = {number1 * number2}");
            });
        }

    }
}
