using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class NetworkMangerUDPserver : MonoBehaviour
{
    public int lisPort = 8000;


    public String msg = null;
    private String servIP = "127.0.0.1";
    private UdpClient socketConnection;

    //private void UDPListenForData()
    //{
    //    //msg = null;
    //    Debug.Log("UDP start listen");
    //    socketConnection = new UdpClient(lisPort);
    //    try
    //    {


    //        Debug.Log(servIP + ";" + lisPort);
    //        // Byte[] bytes = new Byte[1024];
    //        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
    //        // /*
    //        while (1 == 1)
    //        {
    //            Debug.Log("listening");
    //            // Get a stream object for reading 				
    //            Byte[] receiveBytes = socketConnection.Receive(ref RemoteIpEndPoint);
    //            msg = Encoding.ASCII.GetString(receiveBytes);
    //            // Debug.Log(msg + "msg");
    //        }
    //        //*/


    //    }
    //    catch (SocketException socketException)
    //    {
    //        Debug.Log("Socket exception: " + socketException);
    //    }
    //    Debug.Log("end funct");
    //}

    private void UDPSendMessage(String sndMsg)
    {
        try
        {
            socketConnection = new UdpClient(servIP, lisPort);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(sndMsg);
            Byte[] bytes = new Byte[1024];
            socketConnection.Send(sendBytes, sendBytes.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UDPSendMessage("Sending...");
    }

    // Update is called once per frame
    void Update()
    {
        UDPSendMessage("Sending...");
    }
}
