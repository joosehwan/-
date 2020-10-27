using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Arm_p2_rotate_downVer : MonoBehaviour
{
    private float speed2 = 5.0f;
    private float b;
    private int partition_status_1 = 0;
    private int partition_status_all = 0;

    public Text SwitchButton_Text1;

    private float timeSpan = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timeSpan = 0f;
    }
   
    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan >= 2.0f)
        {
            Play();
        }

    }
    // Update is called once per frame
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
        // Debug.Log(partition_status_1);
        if (Input.GetKey(KeyCode.Q))
        {
            partition_status_1 = 1;
            partition_status_all = 0;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            partition_status_1 = 0;
            partition_status_all = 0;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            partition_status_1 = 1;
            partition_status_all = 1;
        }



        if (partition_status_1 == 1)
        {
            SwitchButton_Text1.text = "1번 관절 사용중...키보드 [좌] [우] 를 누르세요";
            if (partition_status_all == 1)
            {
                SwitchButton_Text1.text = "1번 & 2번 관절 사용중...상하좌우키 사용.";
            }


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
    }
}