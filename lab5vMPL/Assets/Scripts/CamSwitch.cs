using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{

        public GameObject cam ;
        private vMPLMovementArbiter arbiter = null;
        public float speed = 10;
        public float rotationSpeed = 20;

    void Start()
    {
        cam = GameObject.Find("Camera");
        arbiter = GameObject.Find("vMPLMovementArbiter").GetComponent<vMPLMovementArbiter>();

    }
    void Update()
        {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.C))
        { arbiter.SetMovementState(vMPLMovementArbiter.MOVEMENT_STATE_CYLINDER_GRASP); };

        if (Input.GetKey(KeyCode.O))
        { arbiter.SetMovementState(vMPLMovementArbiter.MOVEMENT_STATE_HAND_OPEN); };


            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        if (Input.GetMouseButton(0))
        {
            cam.transform.eulerAngles += new Vector3(-mouseY, mouseX, 0);
            Vector3 currentRotation = cam.transform.eulerAngles;

            //keep angle in -180 to 180
            if (currentRotation.x >= 180) currentRotation.x -= 360;
            //limit camera
            if (currentRotation.x < 180 && currentRotation.x > 70)
            {
                currentRotation.x = 70;
                cam.transform.eulerAngles = currentRotation;
            }
            if (currentRotation.x > -180 && currentRotation.x < -70)
            {
                currentRotation.x = -70;
                cam.transform.eulerAngles = currentRotation;
            }
        }
    }
 

}
