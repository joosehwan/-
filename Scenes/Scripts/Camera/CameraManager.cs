using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    joystickServer js;
    public Camera[] arrCam; //카메라 요소들을 추가한다.

    int nCamCount = 3;//카메라 갯수

    int nNowCam = 0;    //현재 활성화된 카메라
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (js.stick=="g")

        {

            ++nNowCam;



            if (nNowCam >= nCamCount)

            {

                nNowCam = 0;

            }



            for (int i = 0; i < arrCam.Length; ++i)

            {

                arrCam[i].enabled = (i == nNowCam);
                js.stick = "h";
            }

        }
    }
}
