using Unity.VisualScripting;
using UnityEngine;

public class Serp : MonoBehaviour // genere proceduralement des triforces en prennant 3 cubes positionés en forme de triangles
{
    public GameObject A; // j'ai juste besoin de ca pour leurs positions qui seront stockée différement ensuite pour rendre l'ecriture plus facile
    public GameObject B;
    public GameObject C;
    public GameObject Instance; // block a instancier
    private Vector3 Apos; // positions tirées des GameObjects
    private Vector3 Bpos;
    private Vector3 Cpos;
    Vector3 Inpos; // Point ou l'instancié sera généré, sert aussi pour definir le "préféré"

    Vector3 favourite;
    float randomnumber = Random.Range(0, 3); // variable pour stocké le nombre aleatoire, choisi le premier nombre dés sa creation, ce nombre sert a determiner A B ou C


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Apos = A.transform.position; Bpos = B.transform.position; Cpos = C.transform.position; // application de leurs valeurs au [lettre]pos
        if (randomnumber == 0) { Inpos = Apos; } // conditionels par rapport au random
        else if (randomnumber == 1) { Inpos = Bpos; }
        else if (randomnumber == 2) { Inpos = Cpos; }
        
        
        
        
        
        for (int i = 0; i < 100000; i++) // boucles
        {
            
            randomnumber = Random.Range(0, 3); // choix entre (A,B,C)
            if (randomnumber == 0)
            {
                Inpos = Vector3.Lerp(Inpos, Bpos, 0.5f); // le milieux entre Inpos et  la position du cube choisi.
                Instantiate(Instance,Inpos,Quaternion.identity); // creation du cube sur Inpos.
                
            }
            if (randomnumber == 1)
            {
                Inpos = Vector3.Lerp(Inpos, Cpos, 0.5f);
                Instantiate(Instance, Inpos, Quaternion.identity);
                
            }
            if (randomnumber == 2)
            {
                Inpos = Vector3.Lerp(Inpos, Apos, 0.5f);
                Instantiate(Instance, Inpos, Quaternion.identity);
                
            }
            // explication finie.

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
