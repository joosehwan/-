using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ani_3_popup_hard2 : MonoBehaviour
{
    joystickServer js;
    public Animator anim;
    
    void go()
    {
        SceneManager.LoadScene("난이도상_해제");
    }

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in_hard2()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In_hard2();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   
    private void Start()
    {
       
        Invoke("popup_ani_in_hard2", 1);  //연결후 팝업창2 설명
    }
    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (popupcount == 0)
        {
            if (js.stick=="i")
        {  
            Invoke("close", 1);         //팝업닫고
                
                popupcount =1;
            
             }
        }else if (popupcount == 1)
        {
            Invoke("go", 3);
        }
       
    }
}
