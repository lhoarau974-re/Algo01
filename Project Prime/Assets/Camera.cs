using UnityEditor.UI;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Camera : MonoBehaviour
{
    private float rotationSpeed = 1500.0f;


    public Transform self;
    
    

    

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ObjMv.position = Playerpos.position;
        //ObjMv.Move(Playerpos.position, Quaternion.identity);
        
        if (Input.GetKey(KeyCode.Mouse1))
        {
            CamOrbit();
            
        }
        
        
        
        
        
        
        
    }


    private void CamOrbit()
    {
        
        
        

        

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * -rotationSpeed * Time.deltaTime;
            float HorizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, verticalInput);
            transform.Rotate(Vector3.up, HorizontalInput, Space.World);

        }
        
    }
}
