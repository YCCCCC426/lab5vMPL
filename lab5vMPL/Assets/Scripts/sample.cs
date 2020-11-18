using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{
    
    private GameObject camera = null;
    private vMPLMovementArbiter arbiter = null;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Camera");
        arbiter = GameObject.Find("vMPLMovementArbiter").GetComponent<vMPLMovementArbiter>();
    }

    // Update is called once per frame
    void Update()
    {
       
        // camera position control 

        // camera rotation control
       
        // hand close

        //hand open
        

    }
}
