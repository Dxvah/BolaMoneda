using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMoneda : MonoBehaviour
{
   
   public AudioSource Receptor;
   public AudioClip Sound;
   public float volumen = 1f;

    [SerializeField]

    float rotacionY;
    

    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {

        Receptor.PlayOneShot(Sound, volumen);


    }
    

}
