using System;
using System.Reactive.Linq;


namespace Plugin.BluetoothLE
{
    public class NotSupportedAdapterScanner : IAdapterScanner
    {
        public bool IsSupported => false;
        public IObservable<IAdapter> FindAdapters() => Observable.Return(CrossBleAdapter.Current);
    }
}
