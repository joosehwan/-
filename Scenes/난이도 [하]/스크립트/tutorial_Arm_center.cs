using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_Arm_center : MonoBehaviour
{
    joystickServer js;
    private float speed2 = 5.0f;
    private float b;
    public float minVertical = 45.0f;
    public float Vertical = -45.0f;
    private int dontpop = 1;
    bool col = false;
    private float timeSpan = 0f;


    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void popcamera()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<tutorial_SceanChange>().enabled = true;
    }
    void pauseAudio()
    {
        if (!(js.stick == "e") && !(js.stick == "f"))  //좌우키와 U/I키가 안눌러저있을때 즉 조종안할때 꺼라. 
        {
            loadingArmSound.instance.pauseSE("machine2");
        }
    }
    void playAudio()
    {
        if ((js.stick == "e") || (js.stick == "f"))
        {
            loadingArmSound.instance.playSE("machine2");


        }
    }
    // Update is called once per frame
    public void Update()

    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;

        //30도 이상이 움직이면 튜토리얼 1이 시작된다. 
        float angle = GameObject.FindGameObjectWithTag("pCenter").transform.eulerAngles.y;
            //오일러 각이 우리가 아는 각이다. 
      
        if (angle >= 180f)
        {
            angle -= 360f;  Debug.Log(angle + "center");
        }
        if (dontpop == 1)
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_4();
            if (js.stick=="i")
            {
                close();
                dontpop += 1;
                js.stick ="x";
            }
        }


        if (angle <= 30 && angle>=-30)
       {
            Play();
       }
        else
        {
            pauseAudio();
            if (dontpop == 2)   //플레이 성공조건을 만족시
            {
                invoke_popupgood();// GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();

                if (js.stick == "i")
                {
                    Invoke("close", 0.5f);             //GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
                    dontpop = 3;
                    js.stick = "x";



                }
            }else if (dontpop == 3)
            {
                Invoke("popcamera", 0.5f);
                //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<tutorial_SceanChange>().enabled = true;     //카메라 튜토리얼 키기.
               
                GameObject.FindGameObjectWithTag("pCenter").GetComponent<Obj_Rotate_center>().enabled = true;
                GameObject.FindGameObjectWithTag("pCenter").GetComponent<tutorial_Arm_center>().enabled = false;
            }


        }

        Debug.Log(angle);

    }

    void Play()
    {
        pauseAudio();
        playAudio();
        b = Input.GetAxis("Vertical");
        float z1 = speed2 * 3 * Time.deltaTime;
        float z2 = -speed2 * 3 * Time.deltaTime;

        if (js.stick == "e")
        {    //기둥 왼쪽으로 30도 

            this.transform.Rotate(0, speed2 * 3 * Time.deltaTime, 0);
            js.stick = "x";

        }

        if (js.stick == "f")
        {    //기둥 오른쪽으로 -30도

            this.transform.Rotate(0, -speed2 * 3 * Time.deltaTime, 0);
            js.stick = "x";
        }





    }


}


