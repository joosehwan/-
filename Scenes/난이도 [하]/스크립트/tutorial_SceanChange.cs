using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_SceanChange : MonoBehaviour
{
    joystickServer js;
    int countFire3 = 0;
    private int dontpop = 1;

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void popup5()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_5();
    }
    void popupend()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_end();
    }


    // Update is called once per frame
    public void Update()

    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        //30도 이상이 움직이면 튜토리얼 1이 시작된다. 
        if (js.stick=="i" && countFire3 == 4)
        {
            close();            // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();

        }

        if (dontpop == 1)
        {
            Invoke("popup5", 0.5f);      // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_5();
            if (js.stick == "i")
            {
                Invoke("close", 0.5f);
                dontpop = 2;
            }
        }


        if (js.stick=="g")  //조건
        {
            countFire3 += 1;
            js.stick = "x";
            if (countFire3 == 3)
            {
                Invoke("popupend", 0.5f); // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_end();

                GameObject.FindGameObjectWithTag("p1").GetComponent<p1>().enabled = true;
                GameObject.FindGameObjectWithTag("p2").GetComponent<p2>().enabled = true;
                // GameObject.FindGameObjectWithTag("MainCamera").GetComponent<tutorial_SceanChange>().enabled = false;
                countFire3 = 4;
            }
        }


        //  GameObject.FindGameObjectWithTag("p2").GetComponent<tutorial_Arm_p2>().enabled = false;     //팝업 끝내고 비활성화. 그럼 1번은 작업이 끝이겟죠?
    }



}


