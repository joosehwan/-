using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1_mockup : MonoBehaviour
{
    //joystickServer js;
    private float speed2 = 5.0f;
    private float b;

    public Text SwitchButton_Text;
    public Text angle_p1Text;
    public Text angle_p2Text;
    public Text isactive_Text;
    bool Active_Q = false;
    private float timeSpan = 0f;

   

    public void isActiveQ()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Active_Q = true;
            SwitchButton_Text.text = "Q누름. P1활성화";
            //GameObject.FindGameObjectWithTag("soundMgr").GetComponent<loadingArmSound>().playSE("machine");
          
        }
    }
    public void stopQ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Active_Q = false;
            SwitchButton_Text.text = "W누름. P1비활성화 / P2활성화.";
            //loadingArmSound.instance.pauseSE("machine");
        }

    }

    public void inputLeft()
    {

      
        if (Input.GetKey(KeyCode.LeftArrow))
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
    public void inputRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
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
    void pauseAudio()
    {
        if(!(Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.RightArrow))){
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
  
    void controlP1()
    {
        inputLeft();
        inputRight();
    }

  public  void Start()
    {
        //   js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;
        timeSpan = 0f;
    }




    // Update is called once per frame
    public void Update()
    {
       // Debug.Log("key" + js.getKey);
        //Debug.Log("control" + js.getControl);
        
        timeSpan += Time.deltaTime;

        if (timeSpan >= 1f)
        {
            stopQ();
            isActiveQ();                // q를 눌럿니
            if (Active_Q == true)
            {
                Play();

            }

        }

    }

    public void Play()
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

        if (angle_p1 < 10 && angle_p1 > -50)
        {
            controlP1();
        }
        else if (angle_p1 > 10)        //왼쪽기울때. 
        {
            inputRight();
        }
        else if (angle_p1 < -50)
        {
            inputLeft();
        }






    }

}