using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateThenDeactivate : MonoBehaviour
{
    public GameObject message;
    public GameObject camera;
    void Start()
    {
        transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        transform.rotation = Quaternion.Euler(camera.transform.rotation.x, camera.transform.rotation.y, camera.transform.rotation.z);
    }

    public void OnAndOff()
    {
        if(message.active == true)
        {
            message.SetActive(false);
        }
        else
        {
            message.SetActive(true);
        }
    }
}
