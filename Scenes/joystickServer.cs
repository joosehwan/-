using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.IO.Ports;
using UnityEngine;

public class joystickServer : MonoBehaviour
{   public bool btpower;
    public bool sp1_p;
    public bool sp2_p;
    public bool sp3_p;
    
    public string stick;
    public string mockup="1234";
    public string segment;
    public SerialPort sp1 = new SerialPort("COM6", 9600);      // 아두이노와 시리얼 통신.
    //SerialPort sp2 = new SerialPort("COM8", 9600);      // 아두이노와 시리얼 통신.
   //SerialPort sp3 = new SerialPort("COM4", 9600);      // 아두이노와 시리얼 통신.

    public void Start()
    {
        startBase();
       }
    public void Update()
    {
       // isConnect();
        getdata();
    }
    public void isConnect() //각 블루투스 통신이 연결되면 true적용
    {
        if (sp1.IsOpen)
        {
            sp1_p = true;
            btpower = true;
        }
        /* 
         else if (sp2.IsOpen)
        {
            sp2_p = true;
        }else if (sp3.IsOpen)
        {
            sp3_p = true;
        }
        if(sp1_p && sp2_p && sp3_p == true)
        {
            btpower = true;
        }
         */
    }

    public void startBase()
    {

        sp1.Open();
        sp1.ReadTimeout = 1;
      //  sp2.Open();
      //  sp2.ReadTimeout = 1;
      //  sp3.Open();
      //  sp3.ReadTimeout = 1;
    }

    public void getdata()
    {
        if (sp1.IsOpen)            //연결 됬는지.
        {   try
               
            {
              //  sp1.Write("123");
                //  Debug.Log("보내");
                stick = sp1.ReadLine();              //아두이노에서 string값을 받아옴
              //  mockup = sp2.ReadLine();
               // segment = sp3.ReadLine();
              
                // Debug.Log("mockup=" + mockup);
                // Debug.Log("segment=" + segment);
               
                sp1.BaseStream.Flush();      //버퍼 제공
               // sp2.BaseStream.Flush();      //버퍼 제공
               // sp3.BaseStream.Flush();      //버퍼 제공

            }

            catch (System.Exception)

            {
               // Debug.Log("연결안됨");
            }
        }
    }
   
}
