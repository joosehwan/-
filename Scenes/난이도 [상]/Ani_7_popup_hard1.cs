using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_7_popup_hard1 : MonoBehaviour
{
    joystickServer js;
    public Animator anim;
    public Animator Cam;
    public Animator Oiltanker;

    void TriggerAni()
    {
        anim.SetTrigger("Active4");
    }
    void TriggerAniCam()
    {
        Cam.SetTrigger("ActiveCam3");
    }
    void TriggerAni_oiltanker()
    {
        Oiltanker.SetTrigger("Active_oiltanker");
    }
    void destoryP3()
    {
        GameObject.FindGameObjectWithTag("p3").SetActive(false);
    }

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_out_hard()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_out_hard3();
    }
    void popup_endSimul()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_endSimul();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }

    int popupcount = 0;

    private void Start()
    {

        Invoke("popup_ani_out_hard", 1);
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
                Invoke("TriggerAni", 2);
               // Invoke("TriggerAniCam", 2);
                //Invoke("TriggerAni_oiltanker", 2);
                popupcount = 1;

            }
        }

    }
}
