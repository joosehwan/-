using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 목업connection : MonoBehaviour
{
    joystickServer js;
    string seg;
    public Text GameTimeText;
    void OnCollisionEnter(Collision collision)
    {   float angle_p1 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z;
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
        if (collision.collider.CompareTag("enemy"))
        {
            GameTimeText.text = "매치되었습니다.";

            js.segment += (string.Format("{0:000}", angle_p1));
            js.segment += (string.Format("{0:000}", angle_p2));
            js.segment += (string.Format("{0:000}", angle_pc));
            seg = js.segment;
            js.sp1.Write(seg);
        }
      
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
       
     
    }

}