using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_4_popup : MonoBehaviour
{
    joystickServer js;
    public Animator anim;
    public Animator Cam;
    public Animator Oiltanker;
    //public Animator camAnimator;
   

    void TriggerAni()
    {
        anim.SetTrigger("Active2");
    }
  public  void TriggerAniCam()
    {// camAnimator = GameObject.Find("MainCamera").GetComponent<Animator>();
       Cam.SetTrigger("ActiveCam");
    }
    public void TriggerAniOiltanker()
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
    void popup_ani_out()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_out();
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
       
        Invoke("popup_ani_out", 1);  
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
             
                popupcount =1;
                js.stick = "x";
             }
        }
       
    }
}
