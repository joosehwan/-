using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_control : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "shipside")
        {
           
            ParticleSystem instance = Instantiate(explosion, transform.position, Quaternion.identity);
           // loadingArmSound.instance.playSE("explosion");
            instance.Play();
            audioSource.Play();
            
        }
        else if (col.gameObject.tag == "plane")
        {
           // loadingArmSound.instance.playSE("explosion");
            ParticleSystem instance = Instantiate(explosion, transform.position, Quaternion.identity);
            instance.Play();
            audioSource.Play();


        }

    }
    void Update()
    {
        
    }
}
