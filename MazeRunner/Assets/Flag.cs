using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
         Rabbit controller = other.GetComponent<Rabbit>();

            controller.trueVictory();
        }
    
    }
