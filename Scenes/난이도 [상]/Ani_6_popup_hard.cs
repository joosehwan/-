using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_6_popup_hard : MonoBehaviour
{
    joystickServer js;
    public Animator anim;

    void TriggerAni()
    {
        anim.SetTrigger("Active3");
    }
    


    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in_hard()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In_hard3();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   
    private void Start()
    {
       
        Invoke("popup_ani_in_hard", 1);  
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
