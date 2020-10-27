using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_shipside : MonoBehaviour
{
    public joystickServer js;
    public string seg;
    private float GameTime = 11;

    bool pop = false;
  
    void OnCollisionEnter(Collision collision)
    {

        void close()
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
        }
        if (collision.collider.CompareTag("p3") && pop == false)
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_shipside();
            pop = true;
           
            Debug.Log("충돌");
        }


    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;



        if (pop == true)
        {
           

            GameObject.FindGameObjectWithTag("p1").GetComponent<p1>().enabled = false;
            GameObject.FindGameObjectWithTag("p2").GetComponent<p2>().enabled = false;
            if (js.stick=="i")
            {
               
                GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();       //팝업닫기
                pop = false;
                
                GameObject.FindGameObjectWithTag("p1").transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
                GameObject.FindGameObjectWithTag("p2").transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));

                if (pop == false)
                {
                    GameObject.FindGameObjectWithTag("p1").GetComponent<p1>().enabled = true;
                    GameObject.FindGameObjectWithTag("p2").GetComponent<p2>().enabled = true;
                }
            }
        }
    }


}