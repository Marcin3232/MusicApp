using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Forms;

namespace MusicApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _folderNameWithPath;
        public string FolderNameWithPath
        {
            get { return _folderNameWithPath; }
        }

        public MainViewModel()
        {

        }


        public ICommand OpenFolderDialog
        {
            get { return new RelayCommand(OpenDialogFolder); }
        }

        public void OpenDialogFolder()
        {
            var openDialog = new FolderBrowserDialog();
            openDialog.ShowDialog();
        }


        private string _soundName;
        private const string SoundPropertyName = "SoundName";
        public string SoundName
        {
            get { return _soundName; }
            set
            {
                Set(SoundPropertyName, ref _soundName, value);
            }
        }
        public void OnCloseAll()
        {

        }
    }
}