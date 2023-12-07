using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public void ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        
    }


}
