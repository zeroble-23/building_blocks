using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if (Input.GetButtonDown("Fire1")) {
            GameObject cannonball = Instantiate(cannonballPrefab, transform.position, transform.rotation) as GameObject;
            cannonball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 2000));

        }
    }

    void LateUpdate() {
        float x = Input.GetAxis("Mouse X") * 2;
        float y = -Input.GetAxis("Mouse Y");

        // vertical tilting
        float yClamped = transform.eulerAngles.x + y;
        transform.rotation = Quaternion.Euler(yClamped, transform.eulerAngles.y, transform.eulerAngles.z);

        // horizontal orbiting
        transform.RotateAround(new Vector3(0, 3, 0), Vector3.up, x);
    }
}
