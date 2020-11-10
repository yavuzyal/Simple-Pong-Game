using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInteract : MonoBehaviour
{

    public GameObject ball;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            Debug.Log("topa paddle degdi");
        }      
    }
}