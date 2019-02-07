using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Block : MonoBehaviour {
    public float health = 10;

    void OnCollisionEnter(Collision collision) {
        health -= collision.relativeVelocity.magnitude;

        if(health <= 0) {
            Destroy(gameObject);
        }

        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        if (boxes.Length <= 1) {
            SceneManager.LoadScene("Main");
        }
    }



}
