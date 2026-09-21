using UnityEngine;

public class jesaispas : MonoBehaviour
{
    public float playerage = 18;
    public Object cube;
    public float pose = 0;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(cube, new Vector3(pose,0,0), transform.rotation);
            pose += 1;
        }
    }
}
