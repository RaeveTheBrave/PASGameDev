using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScor : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision)
    {
        Scor.score++;
    }
}
