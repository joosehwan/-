using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2_mockup : MonoBehaviour
{
   // joystickServer js;
    private float speed2 = 5.0f;
    private float b;

    public Text SwitchButton_Text;
    public Text angle_p1Text;
    public Text angle_p2Text;
    public Text isactive_Text;

    bool Active_W = false;
    private float timeSpan = 0f;



    void isActiveW()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Active_W = true;
            SwitchButton_Text.text = "W누름. P2활성화";
        }
    }
    void stopW()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Active_W = false;
            SwitchButton_Text.text = "Q누름. P1활성화 / P2비활성화.";
           
        } //loadingArmSound.instance.pauseSE("machine");

    }

    void inputLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if (b >= 0)
            {
                this.transform.Rotate(0, 0, -speed2 * 3 * Time.deltaTime);
            }
            else
            {
                this.transform.Rotate(0, 0, speed2 * 3 * Time.deltaTime);
            }

        }
    }
    void inputRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            if (b >= 0)
            {
                this.transform.Rotate(0, 0, speed2 * 3 * Time.deltaTime);
            }
            else
            {
                this.transform.Rotate(0, 0, -speed2 * 3 * Time.deltaTime);
            }


        }
    }

    void controlP2()
    {
        inputLeft();
        inputRight();
    }

    void pauseAudio()
    {
        if (!(Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            loadingArmSound.instance.pauseSE("machine");
        }
    }
    void playAudio()
    {
        if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            loadingArmSound.instance.playSE("machine");

        }
    }
    void Start()
    {timeSpan = 0f;
      //  js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;  //서버연결
    }
   
    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan >= 1f)
        {
            stopW();
            isActiveW();                // w를 눌럿니
            if (Active_W == true)
            {
                Play();
            }

        }

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

      angle_p1Text.text = angle_p1.ToString();
      angle_p2Text.text = angle_p2.ToString();

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