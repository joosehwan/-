using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2 : MonoBehaviour
{

    private float speed2 = 5.0f;
    private float b;

    public Text SwitchButton_Text;

    joystickServer js;
    void inputLeft()
    {
        if (js.stick=="c")
        {
            SwitchButton_Text.text = "로딩암 파이프 기울기 조종";
            if (b >= 0)
            {
                this.transform.Rotate(0, 0, -speed2 * 3 * Time.deltaTime);
                js.stick = "x";
            }
            else
            {
                this.transform.Rotate(0, 0, speed2 * 3 * Time.deltaTime);
                js.stick = "x";
            }

        }
    }
    void inputRight()
    {
        if (js.stick=="d")
        {
            SwitchButton_Text.text = "로딩암 파이프 기울기 조종";

            if (b >= 0)
            {
                this.transform.Rotate(0, 0, speed2 * 3 * Time.deltaTime);
                js.stick = "x";
            }
            else
            {
                this.transform.Rotate(0, 0, -speed2 * 3 * Time.deltaTime);
                js.stick = "x";
            }


        }
    }

    void controlP2()
    {
        inputLeft();
        inputRight();
    }

    void Start()
    {

       
    }



    void pauseAudio()
    {
        if (js.stick != "c" && js.stick != "d")
        {
            loadingArmSound.instance.pauseSE("machine");
        }
    }
    void playAudio()
    {
        if (js.stick=="c"|| js.stick=="d")
        {
            loadingArmSound.instance.playSE("machine");

        }
    }

    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;

        Play();
    }

    void Play()
    {
        pauseAudio();
        playAudio();
        float angle_p1 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z;
        float angle_p2 = GameObject.FindGameObjectWithTag("p2").transform.eulerAngles.z;

        if (angle_p1 >= 180f)
        {
            angle_p1 -= 360f;
        }
        if (angle_p2 >= 180f)
        {
            angle_p2 -= 360f;
        }

        b = Input.GetAxis("Vertical");

       if(angle_p2-angle_p1 >= 4 && angle_p2 - angle_p1 < 70)
        {
            controlP2();
            
        }else if(angle_p2 - angle_p1 >= 4 && angle_p2 - angle_p1 >= 70)
        {
            inputLeft();
        }
      
        else if (angle_p2 - angle_p1 < 4) 
        {
            inputRight();
        }

    }

}