using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveship_target : MonoBehaviour
{
    public void target()
    {
        GameObject.Find("Oil_tanker").GetComponent<Move_Boat>().setTarget();
      //  GameObject.Find("Oil_tanker").GetComponent<Move_Boat>().enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
