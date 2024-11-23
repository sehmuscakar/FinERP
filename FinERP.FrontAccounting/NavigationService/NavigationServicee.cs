using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinERP.FrontAccounting.NavigationService
{
    public class NavigationServicee : INavigationService
    {
        private readonly Frame _frame;

        public NavigationServicee(Frame frame)
        {
            _frame = frame ?? throw new ArgumentNullException(nameof(frame));
        }

        // Sayfa nesnesiyle geçiş yapar
        public bool Navigate(Page page)
        {
            if (page == null)
                return false;

            return _frame.Navigate(page);
        }

        // Sayfa tipiyle geçiş yapar
        public bool Navigate(Type pageType)
        {
            if (pageType == null || !typeof(Page).IsAssignableFrom(pageType))
                return false;

            var page = Activator.CreateInstance(pageType) as Page;
            return _frame.Navigate(page);
        }

        // Geri git
        public void GoBack()
        {
            if (_frame.CanGoBack)
                _frame.GoBack();
        }

        // İleri git
        public void GoForward()
        {
            if (_frame.CanGoForward)
                _frame.GoForward();
        }
    }
}

