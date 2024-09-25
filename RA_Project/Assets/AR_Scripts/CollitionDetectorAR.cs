using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetectorAR : MonoBehaviour
{
    //private GameObject DescriptionSelected;

    //private void OnTriggerEnter(Collider other)
    //{

    //}

    void OnCollisionEnter(Collision collision)
    {
        // Obtiene el objeto que ha colisionado
        GameObject otherObject = collision.gameObject;

        // Calcula la diferencia de posiciones entre este objeto (gameObject) y el objeto colisionado
        Vector3 direction = otherObject.transform.position - transform.position;

        // Determinar si la colisión fue por la derecha o la izquierda
        if (direction.x > 0)
        {
            Debug.Log("La colisión fue desde la derecha.");
        }
        else if (direction.x < 0)
        {
            Debug.Log("La colisión fue desde la izquierda.");
        }
    }
}
