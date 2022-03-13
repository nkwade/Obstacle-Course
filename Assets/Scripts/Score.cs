using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 0;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag != "Hit") {
            score++;
        }
    }
}   
