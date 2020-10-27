using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_description_hard : MonoBehaviour
{
    public joystickServer js;
    private int dontpop = 1;
   
   void dontpopinvoke3()
    {
        dontpop = 3;
    }
    void dontpopinvoke4()
    {
        dontpop = 4;
    }
    void dontpopinvoke5()
    {
        dontpop = 5;
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void startArm()
    {
        GameObject.FindGameObjectWithTag("p1").GetComponent<p1>().enabled = true;  //로딩암 조종 시작
        GameObject.FindGameObjectWithTag("p2").GetComponent<p2>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (dontpop == 1)
        {
            
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_1_hard();   //로딩암 설명창 먼저 띄우고
            if (js.stick=="i")
            {
                close();        //팝업닫기
                dontpop = 0;     //딜레이 시간동안 popup_explane이 다시 시작 못하게. 
                Invoke("dontpopinvoke3", 1);     
               

            }
        }
      else  if (dontpop == 3)       //튜토리얼 시작. 
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_2_hard();
            if (js.stick == "i")
            {

                close();                        // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
                dontpop = 0;
                Invoke("dontpopinvoke4", 1);

            }

        }else if(dontpop==4)
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_3_hard();
            if (js.stick == "i")
            {

                close();                        // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
                dontpop = 0;
                Invoke("dontpopinvoke5", 1);

            }

        }
        else if (dontpop == 5)
        {
            Invoke("startArm",1);  //튜토리얼 조종 시작

            GameObject.FindGameObjectWithTag("popupSys").GetComponent<popup_description_hard>().enabled = false;
        }
    }
}
