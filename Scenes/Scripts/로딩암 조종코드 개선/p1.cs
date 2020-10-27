using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1 : MonoBehaviour
{

    private float speed2 = 5.0f;
    private float b;
   
    public Text SwitchButton_Text;
    public Text angle_p1Text;
    public Text angle_p2Text;
    public Text angle_pcText;
    // public Text isactive_Text;
    bool Active_Q=false;
    joystickServer js;
   
    
    void pauseAudio()
    {
        if (js.stick!="a" && js.stick!="b")
        {
            loadingArmSound.instance.pauseSE("machine");
        }
    }
    void playAudio()
    {
        if(js.stick=="a" || js.stick == "b")
        {
            loadingArmSound.instance.playSE("machine");
        }
    }
   
  
   public void inputLeft()
    {   
        if (js.stick=="a" )
        {
            SwitchButton_Text.text = "로딩암전신 기울기조종";
            loadingArmSound.instance.playSE("machine");
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
    void inputRight()
    {
       
        if ( js.stick == "b")
        {
            SwitchButton_Text.text = "로딩암전신 기울기조종";
            loadingArmSound.instance.playSE("machine");

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

    void controlP1()
    {
        inputLeft();
        inputRight();
    }

    void Start()
    {
      
       
    }

    


    // Update is called once per frame
    void Update()
    {
        
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;

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
        angle_p1Text.text ="관절1 각도 :"+ angle_p1.ToString();
        angle_p2Text.text = "관절2 각도 :"+ angle_p2.ToString();
        angle_pcText.text = " 기둥각도 :" + angle_pc.ToString();
     
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

        if(angle_p1 < 10 && angle_p1 > -50)
        {
            controlP1();
        }else if (angle_p1 > 10)        //왼쪽기울때. 
        {
            inputRight();
        }else if (angle_p1 < -50)
        {
            inputLeft();
        }
        
        
       
      
       

    }

}