using System.Windows;

namespace nightfallMUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            personajeInicial = new PJ();

            SolicitarNombre();
        }

        PJ personajeInicial;

        private void btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtB_ComandosUsuario.Text.Length != 0)
            {
                lsB_Display.Items.Add(txtB_ComandosUsuario.Text);
                txtB_ComandosUsuario.Clear();
                txtB_ComandosUsuario.Focus();
            }
        }

        private void SolicitarNombre()
        {
            lsB_Display.Items.Add(MensajesPersonaje.ObtenerNombre);
        }
    }
}
