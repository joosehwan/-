using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani_3_Active : MonoBehaviour
{
    void setpop2()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<Ani_3_popup_hard2>().enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
