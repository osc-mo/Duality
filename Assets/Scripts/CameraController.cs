using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    
    [SerializeField] float turnSpeed = 3.0f;
    private Vector3 desiredCam;
    
    


    void Start()
    {
        desiredCam = (player.transform.position + transform.position);



    }

    void LateUpdate()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3 (direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
        transform.position = player.transform.position+desiredCam;//desiredCam*Time.deltaTime;
        //momentum = player.GetComponent<Rigidbody>().velocity.normalized;
        //  Vector3 desiredCamPos = (player.transform.position - offset);
        //transform.position = Vector3.SmoothDamp(transform.position,desiredCamPos, ref velocity, smoothing *Time.deltaTime) *desiredCamPos;

       
       /* Vector3 offset = rotates.eulerAngles;//+ momentum;
        transform.position = player.transform.position * Time.deltaTime;
        transform.LookAt(transform.rotation);*/


    }
}
