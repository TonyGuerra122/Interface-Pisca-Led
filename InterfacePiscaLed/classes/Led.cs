using System;
using System.IO.Ports;
namespace InterfacePiscaLed.classes {
    class Led {
        private bool LedOn;
        //private SerialPort serialPort;
        public Led() {
            LedOn = false;
            //this.serialPort = new SerialPort("COM3", 9600);
            //this.serialPort.Write("OFF");
        }
        //public bool Connect() {
        //    try {
        //        this.serialPort.Open();
        //        return true;
        //    }catch(Exception e) {
        //        Console.WriteLine("Erro: " + e);
        //        return false;
        //    }
        //}
        //public bool CloseConnection() {
        //    try {
        //        this.serialPort.Close();
        //        return true;
        //    }catch(Exception e) {
        //        Console.WriteLine("Erro: " + e);
        //        return false;
        //    }
        //}
        public void TurnOn() {
            SetLed(true);
            //if(this.serialPort.IsOpen) {
            //    this.serialPort.Write("ON");
            //}
        }
        public void TurnOff() {
            SetLed(false);
            //if (this.serialPort.IsOpen) {
            //    this.serialPort.Write("OFF");
            //}
        }
        public bool IsLedOn() {
            return this.LedOn;  
        }
        public void SetLed(bool LedStatus) {
            this.LedOn = LedStatus;
        }
    }
}