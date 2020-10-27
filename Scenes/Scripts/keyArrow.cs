using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyArrow : MonoBehaviour
{
    public GameObject left1;
    public GameObject right1;
    public GameObject left2;
    public GameObject right2;
   
    joystickServer js;
    // Start is called before the first frame update
    void Start()
    {
        left1.SetActive(true);
        right1.SetActive(true);

    }
    void defaultstick()
    {
        if (!(js.stick == "b" || js.stick == "d") || !(js.stick == "a" || js.stick == "c"))
        {
            
        }
    }
    void inputLeft()
    {
        if (js.stick=="a"|| js.stick == "c")
        {
            left1.SetActive(false);
            left2.SetActive(true);
        }
    }
    void inputRight()
    {
        if (js.stick == "b" || js.stick == "d")
        {
            right1.SetActive(false);
            right2.SetActive(true);
        }
    }
    void defaultKey()
    {
        if (! (js.stick == "b" || js.stick == "d" ) || !(js.stick == "a" || js.stick == "c"))
        {
            left1.SetActive(true);
            right1.SetActive(true);
            left2.SetActive(false);
            right2.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;

        inputLeft();
        inputRight();
        defaultKey();
    }
}
