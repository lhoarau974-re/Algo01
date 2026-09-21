using UnityEngine;

public class Tourne : MonoBehaviour
{

    private void Awake()
        {
        Debug.Log("Awake");
        }

    private void OnEnable()
    {
        Debug.Log("Je suis Enabled");
    }
        


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Je suis dans l'update");
    }

    private void OnDestroy()
    {
        Debug.Log("Je suis mort");
    }
}
