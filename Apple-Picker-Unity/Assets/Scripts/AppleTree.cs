using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Compiler attribute placing header 'Inscribed' above 
    // the following fields of this script
    // Inscribed means theses fields will not change
    [Header("Inscribed")]
    public GameObject applePrefab;
    public float speed = 1f; // apple movement speed
    public float leftAndRightEdge = 10f; // distances where AppleTree turns around
    public float changeDirChance = 0.1f; // chance tree changes direction (10%)
    public float appleDropDelay = 1f; // seconds between Apple instantiations

    void Start()
    {
        Invoke("DropApple", 2f); // command will execute function in the string after the delay specified by the second arg
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position; // initial position
        pos.x += 2 * speed * Time.deltaTime; // shifts to the right
        transform.position = pos; // update position

        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move left
        }
        // else if (Random.value < changeDirChance)
        // {
        //     speed *= -1; // Change direction
        // }
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1; //change direction
        }
    }
}
