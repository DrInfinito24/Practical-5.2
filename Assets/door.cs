using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update

    bool opened = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        AudioSource doorSound = gameObject.GetComponent<AudioSource>();
        if(!opened){
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();       
        animation.Play("OpenDoor");
        doorSound.Play();
        opened = true;
        }
       
    }

    void OnTriggerExit(Collider other){
        // if(opened){
        //     opened = false;
        // }
    }
}
