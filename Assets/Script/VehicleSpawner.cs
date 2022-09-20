using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public float speed = 15;
    int numCars = 5;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numCars; i++)
        {
            Debug.Log("Is it working yet?" + i);
        }

        Instantiate(Prefab, new Vector3(5, 0, 178), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
