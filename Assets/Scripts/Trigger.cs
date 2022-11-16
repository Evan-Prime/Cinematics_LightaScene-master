using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //timeline.Play();

            // only use if you want to have an event that only triggers once
            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
