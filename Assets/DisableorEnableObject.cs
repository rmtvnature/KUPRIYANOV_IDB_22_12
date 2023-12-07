using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableorEnableObject : MonoBehaviour
{
    public GameObject Sphere;

    public void whenButtonClicked()
    {
        if (Sphere.activeInHierarchy == true)
            Sphere.SetActive(false);
        else
            Sphere.SetActive(true);
    }
}
