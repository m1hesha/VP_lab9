using System;
using System.Collections.Generic;
using System.Text;

namespace VP_lab9.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private FilesPageViewModel? _files;

        public FilesPageViewModel Files
        {
            get => _files ??= new FilesPageViewModel();
        }
    }
}
