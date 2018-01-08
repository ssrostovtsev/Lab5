﻿using System.Text;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public abstract class Mobile {
        public Mobile() { }
        public Mobile(ScreenBase screen, BatteryBase battery, CPUBase cpu, MessageStorage messageStorage) {
        }
        public abstract ScreenBase Screen { get; set; }
        public abstract BatteryBase Battery { get; set; }
        public abstract CPUBase CPU { get; set; }
        public SMSProvider SMSProvider { get; set; }
        internal abstract SMSProviderInt SMSProviderInt { get; set; }
        internal abstract SMSProviderIntThreadTask SMSProviderIntThreadTask { get; set; }
        public MessageStorage MessageStorage { get; set; }
        public abstract void StartGenerateSMS();
        public abstract void StopGenerateSMS();
        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }
        public string Description() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()} ({Screen.Width}X{Screen.Height})");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()} ({Battery.Capacity} mAh; {Battery.Voltage} V; {Battery.ChargeLevel} %)");
            descriptionBuilder.AppendLine($"CPU Type: {CPU.ToString()} ({CPU.Name}; {CPU.Frequency} GHz; {CPU.Cores} cores)");
            return descriptionBuilder.ToString();
        }
        public IPlayback PlaybackComponent { get; set; }
        public void Play(string data) {
            PlaybackComponent.Play(data);
        }
        public ICharger ChargeComponent { get; set; }
        public void Charge(double voltage, double amperage) {
            ChargeComponent.Charge(voltage, amperage);
        }
    }
}
