//MADE BY:
//SERGI VAN RAVENSWAAY - IKBENSERGI.COM - CONTACT@IKBENSERGI.COM
//

using System.Collections;
using System.IO.Ports;
using UnityEngine;
using UnityEngine.UI;
public class ArduinoInput : MonoBehaviour
{
    //Opens serial port
    SerialPort serialPort = new SerialPort("COM3", 9600);
    // Use this for initialization
    void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                Debug.Log("Port Open");
            }
            catch (System.Exception)
            {
                Debug.Log("Can't Find port");               
            }
        }
        string value = serialPort.ReadLine();
        Debug.Log(value);
    }
}
