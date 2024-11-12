using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource radio = gameObject.GetComponent<AudioSource>();
        radio.Play();
    }
}
