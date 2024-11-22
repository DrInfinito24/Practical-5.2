using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintText : MonoBehaviour
{
    public int hintTimer;
    public player p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Text text = GetComponent<Text>();
            //text.text = Time.timeSinceLevelLoad.ToString();
            if  (p.ammoCollected==false&&Time.timeSinceLevelLoad  >=  5){
                text.text = "I wonder if there’s any ammo in that shack?";
            }
            else if(p.ammoCollected){
                text.text = "";
            }
    }
}
