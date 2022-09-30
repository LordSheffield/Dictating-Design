using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommands : MonoBehaviour
{
    public void Bigger()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y * 2, transform.localScale.z * 2);
    }
    public void Smaller()
    {
        //gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
    }
    public void IncreaseY()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
    }
    public void IncreaseZ()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z *2);
    }
    public void IncreaseX()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
    }
    public void DecreaseY()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
    }
    public void DecreaseZ()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z / 2);
    }
    public void DecreaseX()
    {
        // gets the local scale of an object
        Vector3 local = transform.localScale;

        //sets the local scale of an object
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
    }
}
