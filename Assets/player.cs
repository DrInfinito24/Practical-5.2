using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public int ammo = 0;
    public GameObject bridge;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public GameObject ammoBox;
    public AudioSource playerAudio;

    public  bool ammoCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerAudio = gameObject.GetComponent<AudioSource>();
        playerAudio.clip = clip1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(ammo > 0){

                Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
                RaycastHit result; 
                Physics.Raycast(ray, out result);
                GameObject g = result.collider.gameObject;
                if(g.gameObject.tag == "Target"){
                    Animation a = bridge.transform.parent.GetComponent<Animation>();
                    a.Play("LowerBridge");
                }
                ammo -= 1;
                StartCoroutine(loadedShoot());
            }
            else{ 
                playerAudio.clip = clip1;
                playerAudio.Play();
            }  

        }

        if(ammo == 0){
            ammoBox.gameObject.SetActive(true);
        }
         
    

       


        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Ammo"){
            ammo = 20;
            other.gameObject.SetActive(false);
            playerAudio.clip = clip2;
            playerAudio.Play();
            ammoCollected = true;
        }
       
    }

    IEnumerator loadedShoot(){
        playerAudio.clip = clip3;
        playerAudio.Play();
        yield return new WaitForSeconds(clip3.length);
        playerAudio.clip = clip2;
        playerAudio.Play();

    }

}
