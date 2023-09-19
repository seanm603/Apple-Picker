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

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(applePrefab);
    }
}
