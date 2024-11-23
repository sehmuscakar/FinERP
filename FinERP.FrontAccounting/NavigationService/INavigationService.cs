using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinERP.FrontAccounting.NavigationService
{
    public interface INavigationService
    {
        bool Navigate(Page page);           // Sayfa nesnesiyle geçiş
        bool Navigate(Type pageType);       // Sayfa tipiyle geçiş
        void GoBack();                      // Geri git
        void GoForward();                   // İleri git
    }
}
