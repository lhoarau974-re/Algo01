using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public KeyCode spawn = KeyCode.E;
    public int colision = 0;
    public GameObject mob;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(spawn))
            Instantiate(mob, new Vector3(1, 1, colision), Quaternion.identity);
            colision = colision + 1;


    }
}
