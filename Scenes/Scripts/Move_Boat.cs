using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Boat : MonoBehaviour
{
   
    Vector3 target = new Vector3(-1300, 7, 225);
    public void setTarget() {
        target.x = -205;
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Vector3 velo = Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);
        if (transform.position == target)
        {
            Debug.Log(transform.position.x);
        }


    }


}