using System;
using Android.Bluetooth;


namespace Plugin.BluetoothLE.Internals
{
    public class GattRssiEventArgs : GattEventArgs
    {
        public GattRssiEventArgs(int rssi, BluetoothGatt gatt, GattStatus status) : base(gatt, status)
            => this.Rssi = rssi;

        public int Rssi { get; }
    }
}
