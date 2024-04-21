using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void openImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Налаштування вікна вибору файлу
            openFileDialog.Title = "Оберіть зображення";
            openFileDialog.Filter = "Зображення BMP (*.bmp)|*.bmp|Усі файли (*.*)|*.*";

            // Показати вікно вибору файлу та перевірити, чи користувач натиснув кнопку OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Завантажити зображення з вказаного шляху
                Bitmap image = new Bitmap(openFileDialog.FileName);
                label1.Text = openFileDialog.FileName;
                // Показати завантажене зображення на формі
                pictureBox1.Image = image;

            }

        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку завантажте зображення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Налаштування вікна збереження файлу
            saveFileDialog.Title = "Зберегти зображення";
            saveFileDialog.Filter = "Зображення BMP (*.bmp)|*.bmp|Усі файли (*.*)|*.*";

            // Показати вікно збереження файлу та перевірити, чи користувач натиснув кнопку OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Зберегти зображення за вказаним шляхом
                pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                label1.Text=saveFileDialog.FileName;

                MessageBox.Show("Зображення успішно збережено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void applyEffectButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку завантажте зображення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ColorMatrix colorMatrix = null;

            // Визначення матриці пригнічення відповідно до вибраної опції
            if (redRadioButton.Checked)
                colorMatrix = new ColorMatrix(new float[][] {
        new float[] {0, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, (float)0.02, 0},
        new float[] {0, 0, 0, 0, 1}});
            else if (greenRadioButton.Checked)
                colorMatrix = new ColorMatrix(new float[][] {
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 0, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, (float)0.02, 0},
        new float[] {0, 0, 0, 0, 1}});
            else if (blueRadioButton.Checked)
                colorMatrix = new ColorMatrix(new float[][] {
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 0, 0, 0},
        new float[] {0, 0, 0, (float)0.02, 0},
        new float[] {0, 0, 0, 0, 1}});


            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            // Пригнічення вибраної колірної складової
            Graphics graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height),
                0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            pictureBox1.Refresh();
        }
    }
}
    

