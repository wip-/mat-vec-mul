using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mat_vec_mul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Update_Result()
        {
            if (R0 is null || R1 is null || R2 is null || R3 is null)
                return;

            R0.Text = "";
            R1.Text = "";
            R2.Text = "";
            R3.Text = "";

            try
            {
                R0.Text = (float.Parse(M00.Text) * float.Parse(V0.Text) + float.Parse(M10.Text) * float.Parse(V1.Text) + float.Parse(M20.Text) * float.Parse(V2.Text) + float.Parse(M30.Text) * float.Parse(V3.Text)).ToString();
                R1.Text = (float.Parse(M01.Text) * float.Parse(V0.Text) + float.Parse(M11.Text) * float.Parse(V1.Text) + float.Parse(M21.Text) * float.Parse(V2.Text) + float.Parse(M31.Text) * float.Parse(V3.Text)).ToString();
                R2.Text = (float.Parse(M02.Text) * float.Parse(V0.Text) + float.Parse(M12.Text) * float.Parse(V1.Text) + float.Parse(M22.Text) * float.Parse(V2.Text) + float.Parse(M32.Text) * float.Parse(V3.Text)).ToString();
                R3.Text = (float.Parse(M03.Text) * float.Parse(V0.Text) + float.Parse(M13.Text) * float.Parse(V1.Text) + float.Parse(M23.Text) * float.Parse(V2.Text) + float.Parse(M33.Text) * float.Parse(V3.Text)).ToString();
            }
            catch
            {   
                // Don't update result until inputs are in correct number format
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Update_Result();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_Result();
        }
    }
}

