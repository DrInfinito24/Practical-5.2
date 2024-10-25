using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public int ammo = 0;
    public GameObject bridge;

    public GameObject ammoBox;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && ammo > 0){
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
            RaycastHit result; 
            Physics.Raycast(ray, out result);
            GameObject g = result.collider.gameObject;
            if(g.gameObject.tag == "Target"){
                Animation a = bridge.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }
            ammo -= 1;
          
        }

        if(ammo == 0){
            ammoBox.gameObject.SetActive(true);
        }


        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Ammo"){
            ammo = 20;
            other.gameObject.SetActive(false);
        }
       
    }

}
