using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Test.x++;
    }
}
