using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_description : MonoBehaviour
{
    joystickServer js;
    private int dontpop = 1;
   
   void dontpopinvoke()
    {
        dontpop = 3;
    }
    void getpopup_1()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_1();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void startp1()
    {
        GameObject.FindGameObjectWithTag("p1").GetComponent<tutorial_Arm_p1>().enabled = true;  //튜토리얼 조종 시작
    }
    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (dontpop == 1)
        {
            
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_explane();   //로딩암 설명창 먼저 띄우고
            if (js.stick=="i")
            {
                close();        //팝업닫기
                dontpop = 2;        //딜레이 시간동안 popup_explane이 다시 시작 못하게. 
                Invoke("dontpopinvoke", 1);     //2초후 튜토리얼 시작하게 함. 
                js.stick = "x";

            }
        }
      else  if (dontpop == 3)       //튜토리얼 시작. 
        {
            getpopup_1();
            if (js.stick=="i")
            {

                close();                        // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
                dontpop = 4;
                js.stick = "x";
            }

        }
       else if (dontpop == 4)
        {
            Invoke("startp1",1);  //튜토리얼 조종 시작

            GameObject.FindGameObjectWithTag("popupSys").GetComponent<popup_description>().enabled = false;
        }
    }
}
