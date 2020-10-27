using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Rotate_center : MonoBehaviour
{

    private float speed2= 5.0f;
    private float b;
    public float minVertical = 45.0f;
    public float Vertical = -45.0f;
    joystickServer js;
    void pauseAudio()
    {
        if (!(js.stick=="e") && ! (js.stick == "f"))  //좌우키와 U/I키가 안눌러저있을때 즉 조종안할때 꺼라. 
        {  
            loadingArmSound.instance.pauseSE("machine2");
        }
    }
    void playAudio()
    {
        if ((js.stick == "e") || (js.stick == "f"))
        {
            loadingArmSound.instance.playSE("machine2");
          

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()                               //회전 각도 -45 45 제한 걸기 필요.
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;

        pauseAudio();
        playAudio();

        float angle = this.transform.eulerAngles.y;     //오일러 각이 우리가 아는 각이다. 
        float ang = this.transform.rotation.y;
        if (angle > 180f) angle -= 360f;
     
        if (angle<30f && angle >-30f)
        {
           


            if (js.stick == "e")
            {  
                this.transform.Rotate(0, speed2 * 6 * Time.deltaTime, 0);
                js.stick = "x";

            }

            if (js.stick == "f")
            {    
                this.transform.Rotate(0, -speed2 * 6 * Time.deltaTime, 0);
                js.stick = "x";
            }
            
        }
        else    //제한범위 밖이면 
        {
          
            if (angle > 30f)//왼쪽으로 30도가 넘으면 I 키를 눌러서 오른쪽으로 옮기게
            {
                pauseAudio();
                if (js.stick == "f")
                {
                    
                    this.transform.Rotate(0, -speed2 * 6 * Time.deltaTime, 0);
                    js.stick = "x";
                }
            }


            if (angle < -30f) //오른쪽으로 30도가 넘으면 U키를눌러서 왼쪽으로 옮기게
            {
                pauseAudio();
                if (js.stick == "e")
                {    //임시로 기둥 돌리기
                 
                    this.transform.Rotate(0, speed2 * 6 * Time.deltaTime, 0);
                    js.stick = "x";

                }

            }
           
           
        }
       

    }
}
