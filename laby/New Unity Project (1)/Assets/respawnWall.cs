using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnWall : MonoBehaviour
{
    public GameObject Wall;

    public GameObject notWall;

    public Transform spawn;

    public GameObject joueur;

    private char[,] test;

    public float ecart = 1.987291f;

    private int L = 20;

    private int l = 20;

    private int dernier = 19;

    private int interieur = 19;

    private int pourcentage = 70;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void supprimerVieuxMurs ()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("mur");
        foreach (GameObject go in gameObjects)
        {
            Destroy(go);
        }
    }

    private void aleatoireInterieur()
    { 
        int i2 = 1;
        int item2 = 0;
        while (item2 != L)
        { 
            while (i2 != interieur)
            { 
                int num = UnityEngine.Random.Range(1, interieur);
                if (UnityEngine.Random.Range(0, 100) <= pourcentage)
                { 
                    test[i2, num] = ' ';
                    i2++;
                }
                else
                { 
                    test[i2, num] = '■';
                    i2++;
                }
            }
            i2 = 0;
            item2++;
        }
        
    }

    private void creerPortes()
    { 
        int num = UnityEngine.Random.Range(10, 10);
        int num2 = UnityEngine.Random.Range(1, 19);
        test[num, 0] = '■';
        test[num, 1] = ' ';
        test[num2, 19] = ' ';
        test[num2, 18] = ' ';
    }

    void creerLaby ()
    {
        int item = 0;
        int i = 1;
        test = new char[,]{ 
{' ',' ',' ',' ',' ',' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
},
{ 
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' ',
' '
}
};

        aleatoireInterieur();
        while (item != L)
        { 
            test[0, item] = '■';
            test[dernier, item] = '■';
            item++;
        }
        while (i != dernier)
        { 
            test[i, 0] = '■';
            test[i, dernier] = '■';
            i++;
        }
        creerPortes();
        
        int columns = 0;

        int rows = 0;
        
        while (columns != 20)
        { 
            while (rows != 20)
            { 
                if (test[columns, rows] == '■')
                { 
                    UnityEngine.Object.Instantiate<GameObject>(Wall, new Vector3((float)rows * ecart * 2f, 0f, (float)columns * ecart * 2f), Quaternion.identity);
                }
                else
                { 
                    UnityEngine.Object.Instantiate<GameObject>(notWall, new Vector3((float)rows * ecart * 2f, 0f, (float)columns * ecart * 2f), Quaternion.identity);
                }
                rows++;
            }
            columns++;
            rows = 0;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player") {
            supprimerVieuxMurs();
            creerLaby();
            joueur.transform.position = spawn.transform.position;
         }
    }
}
