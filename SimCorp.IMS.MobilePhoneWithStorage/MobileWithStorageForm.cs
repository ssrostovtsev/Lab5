﻿using System.Collections.Generic;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneWithStorage {
    public partial class MobileWithStorageForm : Form {
        public MobileWithStorageForm() {
            InitializeComponent();
            SimCorpMobile = InitSimCorpMobile();
            MsgStorage = SimCorpMobile.MessageStorage;
            MsgStorage.MessageAdded += ShowAddedMessage;
            MsgStorage.MessageDeleted += ShowDeletedMessages;
            InitSMSNumberComboBox(MsgStorage);
        }
        private MessageStorage MsgStorage;
        private SimCorpMobile SimCorpMobile;
        private void InitSMSNumberComboBox(MessageStorage messageStorage) {
            List<MobilePhoneClassLib.Message> messages = messageStorage.GetAllMessages();
            MessageFilter messageFilter = new MessageFilter();
            List<MobilePhoneClassLib.Message> filteredMessages = messageFilter.UniqueNumbers(messages);
            foreach (MobilePhoneClassLib.Message message in filteredMessages) {
                SMSNumberComboBox.Items.Add(message.SenderNumber);
            }
        }
        private SimCorpMobile InitSimCorpMobile() {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 83);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            MessageStorage messageStorage = InitMessageStorage("+380971994730");
            SimCorpMobile scmobile = new SimCorpMobile(OLEDScreen, liPoBattery, multiCoreCPU, messageStorage);
            scmobile.MessageStorage = messageStorage;
            return scmobile;
        }
        private MessageStorage InitMessageStorage(string phoneNo) {
            MessageStorage messageStorage = new MessageStorage(phoneNo);
            for (int i = 0; i < 1000; i++) {
                MobilePhoneClassLib.Message message = new MobilePhoneClassLib.Message($"+38{i}", phoneNo, $"Message #{i}");
                messageStorage.AddMessage(message);
            }
            return messageStorage;
        }
        private void ShowMessages(List<MobilePhoneClassLib.Message> messages) {
            MessageListBox.Items.Clear();
            foreach (MobilePhoneClassLib.Message message in messages) {
                MessageListBox.Items.Add("From: " + message.SenderNumber + ", Date: " + message.ReceivingTime.ToString() + ", Text: " + message.Text);
            }
        }

        private void ApplyFilterButton_Click(object sender, System.EventArgs e) {
            List<MobilePhoneClassLib.Message> messages = MsgStorage.GetAllMessages();
            List<MobilePhoneClassLib.Message> filteredMessages;
            MessageFilter messageFilter = new MessageFilter();
            if (OrCheckBox.Checked) {
                filteredMessages = messageFilter.OrAllFilters(messages, SMSNumberComboBox.Text.ToUpper(), SMSTextTextBox.Text.ToUpper(), FromDateTimePicker.Value, ToDateTimePicker.Value);
                ShowMessages(filteredMessages);
            } else {
                filteredMessages = messageFilter.AndAllFilters(messages, SMSNumberComboBox.Text.ToUpper(), SMSTextTextBox.Text.ToUpper(), FromDateTimePicker.Value, ToDateTimePicker.Value);
                ShowMessages(filteredMessages);
            }
        }
        private static void ShowAddedMessage(object sender, MessageEventArgs e) {
            MessageBox.Show("Text: " + e.Message.Text + " From: " + e.Message.SenderNumber);
        }
        private static void ShowDeletedMessages(object sender, MessageEventArgs e) {
            MessageBox.Show("Message from: " + e.Message.SenderNumber + " has been deleted");
        }
    }
}
