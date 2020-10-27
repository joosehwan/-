using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_3_popup : MonoBehaviour
{
    joystickServer js;
    public Animator anim;

    void TriggerAni()
    {
        anim.SetTrigger("Active");
    }
    


    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   
    private void Start()
    {
       
        Invoke("popup_ani_in", 1);  
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
                js.stick = "x";
             }
        }
       
    }
}
