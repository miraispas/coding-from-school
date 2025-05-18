using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleSpawner : MonoBehaviour
{
    public GameObject ballePrefab;
    public float positionY;
    public float minPositionX;
    public float maxPositionX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newBalle = Instantiate(ballePrefab);
            newBalle.transform.position = new Vector2(Random.Range(minPositionX, maxPositionX), positionY);
        }
    }
}
