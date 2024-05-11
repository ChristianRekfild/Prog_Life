using ProgSim.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSim.ViewModels
{
    internal class MainWindow_ViewModel : ViewModel_Base
    {
        #region Заголовок
        private string _title = "Prog_Life 0.000002";
        /// <summary>
        /// Заголовок Окна
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        } 
        #endregion


    }
}
