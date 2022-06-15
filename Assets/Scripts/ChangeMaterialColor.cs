using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    [SerializeField] private Material newMaterial;
    [SerializeField] private Material StartMaterial;

    void Start()
    {
        myMaterial.color = StartMaterial.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("color change");
            myMaterial.color = newMaterial.color;
        }
    }

    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         myMaterial.color = Color.red;
    //     }
    // }
}
