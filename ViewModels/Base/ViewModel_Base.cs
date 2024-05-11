using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgSim.ViewModels.Base
{
    public abstract class ViewModel_Base : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyChanged = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyChanged);
            return true;
        }

        // на всякий реализую, потом если что - переопределю.
        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _disposed) return;
            _disposed = true;
            // тут типа освобождение управляемых ресурсов. Может пригодится.
        }
    }
}
