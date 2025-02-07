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
            if (M00 is null || M10 is null || M20 is null || M30 is null ||
                M01 is null || M11 is null || M21 is null || M31 is null ||
                M02 is null || M12 is null || M22 is null || M32 is null ||
                M03 is null || M13 is null || M23 is null || M33 is null ||
                R0  is null || R1  is null || R2  is null || R3  is null )
                return;

            R0.Text = (float.Parse(M00.Text) * float.Parse(V0.Text) + float.Parse(M10.Text) * float.Parse(V1.Text) + float.Parse(M20.Text) * float.Parse(V2.Text) + float.Parse(M30.Text) * float.Parse(V3.Text)).ToString();
            R1.Text = (float.Parse(M01.Text) * float.Parse(V0.Text) + float.Parse(M11.Text) * float.Parse(V1.Text) + float.Parse(M21.Text) * float.Parse(V2.Text) + float.Parse(M31.Text) * float.Parse(V3.Text)).ToString();
            R2.Text = (float.Parse(M02.Text) * float.Parse(V0.Text) + float.Parse(M12.Text) * float.Parse(V1.Text) + float.Parse(M22.Text) * float.Parse(V2.Text) + float.Parse(M32.Text) * float.Parse(V3.Text)).ToString();
            R3.Text = (float.Parse(M03.Text) * float.Parse(V0.Text) + float.Parse(M13.Text) * float.Parse(V1.Text) + float.Parse(M23.Text) * float.Parse(V2.Text) + float.Parse(M33.Text) * float.Parse(V3.Text)).ToString();
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

