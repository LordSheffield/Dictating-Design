using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskHeight : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - (float) 1.30, camera.transform.position.z);
        transform.rotation = Quaternion.Euler(camera.transform.rotation.x, camera.transform.rotation.y +90, camera.transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
