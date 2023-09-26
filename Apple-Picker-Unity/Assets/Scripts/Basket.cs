using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // current mouse position
        Vector3 mousePos2D = Input.mousePosition;

        // instructs how far to push mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;

        // convert point from 2D screen to 3D world
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }

    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Apple")) {
            Destroy(collidedWith);
        }
    }
}