using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.UI.ViewModel
{
    class ApplicationViewModel : ViewModel
    {
        #region Fields
        List<ViewModel> _staticViewModels;
        List<ViewModel> _dynamicViewModels;
        #endregion

        #region Properties
        List<ViewModel> StaticViewModels => _staticViewModels;
        #endregion

        #region Methods
        public ViewModel StaticViewModel(Type type)
        {
            return _staticViewModels.FirstOrDefault(vm => (vm as ViewModel).GetType().Equals(type));
        }
        #endregion

        #region ViewModel Manager

        #endregion

    }
}
