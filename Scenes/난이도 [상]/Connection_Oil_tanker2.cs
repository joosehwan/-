using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_Oil_tanker2 : MonoBehaviour
{
   public joystickServer js;
    public string seg;
    public Text GameTimeText;
    public string segment;
   
    public void OnCollisionEnter(Collision collision)
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
        if (collision.collider.CompareTag("enemy"))
        {
            js.segment += (string.Format("{0:000}", angle_p1));
            js.segment += (string.Format("{0:000}", angle_p2));
            js.segment += (string.Format("{0:000}", angle_pc));
            seg = js.segment;
            js.sp1.Write(seg);
            GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";
            Invoke("delay", 5);
        }
      
    }

   public void Start()
    {
      
    }

    // Update is called once per frame
    public  void Update()
    {

        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        float angle_p1 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z;
        float angle_p2 = GameObject.FindGameObjectWithTag("p2").transform.eulerAngles.z;
        
       

      

    }

    void delay()
    {
        SceneManager.LoadScene("난이도상_연결2");
    }
}