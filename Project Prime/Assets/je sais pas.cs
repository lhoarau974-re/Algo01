using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class jesaispas : MonoBehaviour
{
    public float playerage = 18;
    public Object cube;
    public float pose = 0;
    public Vector3 proceduralvector = Vector3.zero ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerage > 18)
        {
            Debug.Log("NUH HUH, little baby");
        }
        if (playerage < 18)
        {
            Debug.Log("welcome to the goon haven");
        }
        for (int i = 0; i < 100000; i++)
        {
            proceduralvector += new Vector3(Random.Range(-2f, 2f), Random.Range(-0.1f, 0.1f), Random.Range(-2f, 2f));
            Instantiate(cube, proceduralvector, transform.rotation);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            
            Instantiate(cube, new Vector3(pose,0,0), transform.rotation);
            
        }
    }
}
