using TwinCAT.Ads;
using System;

namespace ADSDemo
{
    public class AdsHelper : IDisposable
    {
        private readonly AdsClient _client = new AdsClient();

        public bool IsConnected { get => _client.IsConnected; }

        public void Connect(string amsNetId, int port)
        {
            _client.Connect(AmsNetId.Parse(amsNetId), port);
        }

        public void Disconnect()
        {
            if (_client.IsConnected)
                _client.Disconnect();
        }

        public T ReadValue<T>(string varName) where T : new()
        {
            T valueToRead = new T();

            if (_client.IsConnected)
                valueToRead = (T) _client.ReadValue(varName, typeof(T));

            return valueToRead;
        }

        public void WriteValue<T>(string varName, T value) where T: notnull
        {
            if (!_client.IsConnected)
                return;

            _client.WriteValue(varName, value);
        }

        public uint SetNotification<T>(string name, EventHandler<AdsNotificationExEventArgs> handler)
        {
            if (!_client.IsConnected)
                return 0;

            NotificationSettings ns = new NotificationSettings(AdsTransMode.OnChange, 200, 0);
            
            _client.AdsNotificationEx += handler;
            uint ntHandle = _client.AddDeviceNotificationEx(name, ns, null, typeof(T));

            return ntHandle;
        }

        public void UnsetNotification(uint notificationHandle, EventHandler<AdsNotificationExEventArgs> handler)
        {
            if (!_client.IsConnected)
                return;

            _client.DeleteDeviceNotification(notificationHandle);
            _client.AdsNotificationEx -= handler;
        }


        public void Dispose()
        {
            _client.Disconnect();
            _client.Dispose();
        }
    }
}
