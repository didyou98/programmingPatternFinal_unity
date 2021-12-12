using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCollision : MonoBehaviour
{
    Renderer sr;
    public Image img;
    private void Start()
    {
        sr = transform.GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        sr.material.color = Color.blue;
         img.GetComponent<Image>().color = Color.blue;
    }

    private void OnTriggerEnter(Collider other)
    {
        sr.material.color = Color.red;
        img.GetComponent<Image>().color = Color.red;
    }
}
