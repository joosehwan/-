using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camTrigger_easy : MonoBehaviour
{
  
    public Animator anim;
    public void triggerEasy()
    {
        anim.SetTrigger("easy");
    }
    // Start is called before the first frame update
    void Start()
    {
        triggerEasy();
    }

    // Update is called once per frame
   public void Update()
    {
        
    }
}
