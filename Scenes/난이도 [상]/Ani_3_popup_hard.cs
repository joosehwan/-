using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_3_popup_hard : MonoBehaviour
{

    public Animator anim;
    joystickServer js;
    void TriggerAni()
    {
        anim.SetTrigger("Active");
    }
    


    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in_hard()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In_hard();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   
    private void Start()
    {
       
        Invoke("popup_ani_in_hard", 1);     //하드모드 로딩암 연결장면 팝업 1 띄우기
    }
    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (popupcount == 0)
        {
            if (js.stick=="i")
        {  
            Invoke("close", 1);

                Invoke("TriggerAni",2);
               
                popupcount =1;
            
             }
        }
       
    }
}
