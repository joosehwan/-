using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arm_p1_rotate_downVer : MonoBehaviour
{

    private float speed2 = 5.0f;
    private float b;
    private int partition_status_2 = 0;
    private int partition_status_all = 0;

    public Text SwitchButton_Text2;

    bool col=false;
    private float timeSpan = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timeSpan = 0f;
    }

  


    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan >= 2f)
        {
            Play();
        }

    }

    void Play()
    {
        b = Input.GetAxis("Vertical");
        /*     if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
         {
         this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
         }

         if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
         {
             this.transform.Translate(Vector3.back * speed * Time.deltaTime);
         }
         */
        // Debug.Log(partition_status_2);
        if (Input.GetKey(KeyCode.W))
        {
            partition_status_2 = 1;
            partition_status_all = 0;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            partition_status_2 = 0;
            partition_status_all = 0;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            partition_status_2 = 1;
            partition_status_all = 1;
        }


        

        if (partition_status_2 == 1 && partition_status_all == 0) //단순히 w만 누를시
        {
            SwitchButton_Text2.text = "2번 관절 사용중...키보드 [좌] [우] 를 누르세요";

            
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

        if (partition_status_2 == 1 && partition_status_all == 1)      //E를 누르고 두 관절 모두 사용할때는 2번관절의 방향키가 상하로 바뀐다. Obj_Rotation_1과의 연동을 위해
        {
            SwitchButton_Text2.text = "";

            if (Input.GetKey(KeyCode.DownArrow))    //뒤로, 이거 downArrow 가 uparrow랑 충돌나는거같아요. 같은방향으로만 움직여서 알파벳으로 해놓음 임시. 
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

            if (Input.GetKey(KeyCode.UpArrow))    //앞으로 uparrow
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

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
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

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))    //앞으로 uparrow
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

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
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

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))    //앞으로 uparrow
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
    }

}