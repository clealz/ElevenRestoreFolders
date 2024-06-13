using System.Windows;
using System.Windows.Controls;

namespace ElevenRestoreFolders
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region -> METODOS
        private void RevisarCarpetas()
        {
            cRegistry oReg = new cRegistry();

            oReg.DetectFoldersEnabled();

            chkObjectsTD.IsChecked = oReg.ThreeDObjects;
            chkDesktop.IsChecked = oReg.Desktop;
            chkDocuments.IsChecked = oReg.Documents;
            chkDownloads.IsChecked = oReg.Downloads;
            chkPictures.IsChecked = oReg.Pictures;
            chkMusic.IsChecked = oReg.Music;
            chkVideos.IsChecked = oReg.Videos;
        } 
        #endregion -> METODOS

        #region -> EVENTOS
        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            RevisarCarpetas();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Eleven Restore Folders.\n\nRestaura o elimina las carpetas de acceso rápido en 'Este Equipo'.\n\n¡Advertencia!\nEste programa manipula el registro de Windows, usalo con responsabilidad."
                , Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Evento Generico para los botones de marcar/Desmarcar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarkUnmark_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            //MessageBox.Show(btn.Name, this.Name);

            switch (btn.Name.Replace("btn", string.Empty).Trim())
            {
                case "Todos":
                    {
                        foreach (var item in frmMain.GetChildren())
                        {
                            if (item is CheckBox)
                            {
                                ((CheckBox)item).IsChecked = true;
                            }
                        }
                    }
                    break;
                case "Ninguno":
                    {
                        foreach (var item in frmMain.GetChildren())
                        {
                            if (item is CheckBox)
                            {
                                ((CheckBox)item).IsChecked = false;
                            }
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Evento Genérico para detectar cambios en los checks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            cRegistry oReg = new cRegistry();
            oReg.SetFolderValue(chk.Name.Replace("chk", string.Empty).Trim(), chk.IsChecked);

            oReg.DetectFoldersEnabled();
        }
        #endregion -> EVENTOS
    }
}
