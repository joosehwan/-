using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_Oil_tanker : MonoBehaviour
{
    joystickServer js;
    private float GameTime = 11;
    public Text GameTimeText;
    bool pop = false;
    public string seg;
    void OnCollisionEnter(Collision collision)
    {

        float angle_p1 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z;
        float angle_p2 = GameObject.FindGameObjectWithTag("p2").transform.eulerAngles.z;
        float angle_pc = GameObject.FindGameObjectWithTag("pCenter").transform.eulerAngles.y;
        if (angle_p1 >= 180f)
        {
            angle_p1 -= 360f;
        }
        if (angle_p2 >= 180f)
        {
            angle_p2 -= 360f;
        }
        if (angle_pc >= 180f)
        {
            angle_pc -= 360f;
        }

        void close()
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
        }
        if (collision.collider.CompareTag("enemy")&& pop==false)
        {
            js.segment += (string.Format("{0:000}", angle_p1));
            js.segment += (string.Format("{0:000}", angle_p2));
            js.segment += (string.Format("{0:000}", angle_pc));
            seg = js.segment;
            js.sp1.Write(seg);
            //GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";

            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_connection_hard();
            pop = true;   
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
            if (js.stick=="i")
            {
                GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();       //팝업닫기
                Invoke("delay", 3);
            }
        }
    }

    void delay()
    {
        SceneManager.LoadScene("난이도상_연결");
    }
}