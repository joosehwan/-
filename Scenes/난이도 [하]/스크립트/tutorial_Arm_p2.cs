using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_Arm_p2 : MonoBehaviour
{
    joystickServer js;
    public Text SwitchButton_Text;
    bool anglematch = false;
    int ifput_w = 0;
    private int dontpop = 1;
    private float speed2 = 5.0f;
    private float b;
    bool col = false;
    float invokeSpeed = 0.5f;
    private float timeSpan = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //  PopupSystem pop = new PopupSystem();
    }

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void invoke_popupgood2()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good2();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void popup3()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_3();
    }
    void popupcenter()
    {
        GameObject.FindGameObjectWithTag("pCenter").GetComponent<tutorial_Arm_center>().enabled = true;
    }

    // Update is called once per frame
    public void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        //30도 이상이 움직이면 튜토리얼 1이 시작된다. 

        float angle = GameObject.FindGameObjectWithTag("p2").transform.eulerAngles.z;
        float angle_p1 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z;

        //오일러 각이 우리가 아는 각이다. 
        if (js.stick == "c" || js.stick == "d")
        {
            SwitchButton_Text.text = "로딩암 파이프기울기 조종";
            ifput_w = 1;
        }

        if (angle >= 180f)
        {
            angle -= 360f;
        }
        //  Debug.Log(angle + "p2");
        if (dontpop == 1)
        {
            popup3();// GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_3();
            if (js.stick == "i")
            {
                close();

                dontpop = 2;
                js.stick = "x";
            }
        }

        //Debug.Log("p2==>" + angle);
        if (dontpop == 2 && ifput_w == 1 && anglematch == false)
        {
            if (angle_p1 >= 180f)
            {
                angle_p1 -= 360f;
            }
            Play();
            // Debug.Log(angle_p1 + "==>p1의 부호는");
            if (angle_p1 > 0)   //p1이 왼쪽으로 기울었다. 10도. p2상속값도 10.
            {
                if (angle < 10 || angle > 30) { anglematch = true; }  //7~40도까지 제한
            }
            else if (angle_p1 < 0)             //p1이 음수. 오른쪽으로 기울엇다. -20도. p2상속값도-20
            {
                if (angle < -15 || angle > 5) { anglematch = true; }
            }
          
        }

        if (dontpop == 2 && ifput_w == 1 && anglematch == true)   //플레이 성공조건을 만족시
        {
            pauseAudio();   //로딩암 소리 한번 꺼주기.
            invoke_popupgood2();
          
            if (js.stick == "i")
            {
                Invoke("close", invokeSpeed); //  GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();

                ifput_w = 2;
                js.stick = "x";

            }
        }
        else if (ifput_w == 2)
        {
            Invoke("popupcenter", 1);

            GameObject.FindGameObjectWithTag("p2").GetComponent<tutorial_Arm_p2>().enabled = false;     //팝업 끝내고 비활성화. 

            //  GameObject.FindGameObjectWithTag("pCenter").GetComponent<tutorial_Arm_center>().enabled = true;

        }

        //  Debug.Log(angle);

    }
    void pauseAudio()
    {
        if (!(js.stick == "c") && !(js.stick == "d"))
        {
            loadingArmSound.instance.pauseSE("machine");
        }
    }
    void playAudio()
    {
        if ((js.stick == "c") || (js.stick == "d"))
        {
            loadingArmSound.instance.playSE("machine");

        }
    }
    void Play()
    {
        pauseAudio();
        playAudio();
        b = Input.GetAxis("Vertical");
        float z1 = speed2 * 3 * Time.deltaTime;
        float z2 = -speed2 * 3 * Time.deltaTime;


        if (js.stick == "d")
        {

            if (b >= 0)
            {
                this.transform.Rotate(0, 0, z1);
                js.stick = "x";
            }
            else
            {
                this.transform.Rotate(0, 0, z2);
                js.stick = "x";
            }

        }

        if (js.stick == "c")
        {

            if (b >= 0)
            {
                this.transform.Rotate(0, 0, z2);
                js.stick = "x";
            }
            else
            {
                this.transform.Rotate(0, 0, z1);
                js.stick = "x";
            }


        }



    }


}


