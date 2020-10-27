using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_mode : MonoBehaviour
{
   public void enable_T_p1()
    {
        GameObject.FindGameObjectWithTag("p1").GetComponent<tutorial_Arm_p1>().enabled = true;
    }
    public void enable_T_p2()
    {
        GameObject.FindGameObjectWithTag("p2").GetComponent<tutorial_Arm_p1>().enabled = true;
    }
    
    public void gotutorial()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<popup_description>().enabled = true;

    }

    public void gohardmode()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<popup_description_hard>().enabled = true;

    }


}

