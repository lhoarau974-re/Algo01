using UnityEngine;

public class exercice1 : MonoBehaviour
{
    int age_Joueur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        Debug.Log("Bienvenue sur le jeu");

        age_Joueur = 10;
        if(age_Joueur <= 18)


        Debug.Log("Bye");

        
            else

        {
            Debug.Log("Bienvenue en jeu");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
