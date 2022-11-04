using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject threeDCanvas;
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Get the Renderer component from the new cube
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
        
    */

    public void turnRed()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.red);
    }
    public void turnBlue()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.blue);
    }
    public void turnGreen()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.green);
    }
}

