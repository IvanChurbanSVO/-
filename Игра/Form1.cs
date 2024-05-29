namespace Игра
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<Point> points = new();
            Point point = new Point(100, 100);
            points.Add(point);

            Random animal_random_x = new Random();
            Random animal_random_y = new Random();

            Random random_apple_x = new Random();
            Random random_apple_y = new Random();

            Bitmap animal = Resource1.animal;
            Bitmap apple = Resource1.apple;

            for (int i = 0; i < 50;  i++)
            {
                int animal_X = pictureBox1.Location.X + animal_random_x.Next(0, pictureBox1.Size.Width-50);
                int animal_Y = pictureBox1.Location.Y + animal_random_y.Next(0, pictureBox1.Size.Height-50);

                e.Graphics.DrawImage(animal, new Point(animal_X, animal_Y));

                int apple_X = random_apple_x.Next(-50, 50);
                int apple_Y = random_apple_y.Next(-50, 50);

                if (apple_X != pictureBox1.Size.Height && apple_Y != pictureBox1.Size.Width)
                {
                    e.Graphics.DrawImage(apple, new Point(animal_X + apple_X,
                        animal_Y + apple_Y));
                }
            }
        }
    }
}
