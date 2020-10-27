using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PopupSystem : MonoBehaviour
{
    public GameObject popup;
    Animator anim;

    public static PopupSystem instance { get; private set; }

    public Text txtTitle, txtContent;
    


    public void Awake()
    {
        instance = this;
       anim= popup.GetComponent<Animator>();
    }
    public void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("close"))        //ani 끝남?

        {
            if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                popup.SetActive(false);
            }
        }
    }
    public void OpenPopUp( string title,string content)
    {
        txtTitle.text = title;
        txtContent.text = content;
        
       popup.SetActive(true);
    }


    

    public void ClosePopup()
    {
       
            anim.SetTrigger("close");
        
    }

}
