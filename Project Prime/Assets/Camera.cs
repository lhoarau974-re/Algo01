using UnityEditor.Experimental.GraphView;
using UnityEditor.UI;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Camera : MonoBehaviour
{
    public float rotationSpeed = 1500.0f; // vitesse de rotation, sera alterrable selon les preferences
    public float sensibility = 20.0f; // sensibilitée du zoom


    public Transform self; // position du point de focus

    public Transform zoom; // position de la camera par rapport au point de focus
    
    

    

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ObjMv.position = Playerpos.position;
        //ObjMv.Move(Playerpos.position, Quaternion.identity);
        
        if (Input.GetKey(KeyCode.Mouse1))// regarde si le click droit de la souris est activement maintenu
        {
            CamOrbit();
            
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0f) // systeme de zoom
        {
            zoom.position = zoom.position + transform.forward * Input.GetAxis("Mouse ScrollWheel") * sensibility;
            if (zoom.position.z > transform.position.z)
            {
                zoom.position = transform.position;
            }
        }






    }


    private void CamOrbit()
    {
        
        
        

        

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * -rotationSpeed * Time.deltaTime;// delta time met une restriction sur le nombre de fois par seconde ou ca s'aplique pour eviter une vitesse demesurée
            float HorizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, verticalInput); // pas besoins ici on tourne sur l'obj
            transform.Rotate(Vector3.up, HorizontalInput, Space.World); // space world est l'axe en y

        }
        // prend la rotation par rapport a l'axe de la souris
        
    }
}
