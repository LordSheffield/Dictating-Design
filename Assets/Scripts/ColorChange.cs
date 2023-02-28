using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit;
public class ColorChange : MonoBehaviour
{

    public GameObject threeDCanvas;

    private EyeTrackingTarget myEyeTrackingTarget = null;

    private void Start()
    {
        myEyeTrackingTarget = this.GetComponent<EyeTrackingTarget>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Get the Renderer component from the new cube
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }

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
    public void turnYellow()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.yellow);

    }
    public void turnBlack()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.black);

    }
    public void turnGray()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.gray);

    }
    public void turnWhite()
    {
        var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.white);

    }


}

