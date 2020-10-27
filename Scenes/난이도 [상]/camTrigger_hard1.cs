using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camTrigger_hard1 : MonoBehaviour
{
  
    public Animator anim;
    public void triggerHard1()
    {
        anim.SetTrigger("hard1");
    }
    // Start is called before the first frame update
    void Start()
    {
        triggerHard1();
    }

    // Update is called once per frame
   public void Update()
    {
        
    }
}
