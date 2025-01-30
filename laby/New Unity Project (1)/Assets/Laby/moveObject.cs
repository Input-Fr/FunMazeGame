using System;
using UnityEngine;


public class moveObject : MonoBehaviour
{ 
    public GameObject Wall;

    public GameObject notWall;

    private GameObject joueur;

    private char[,] test;

    private int columns;

    private int rows;

    public float ecart = 1.987291f;

    private int L = 20;

    private int l = 20;

    private int dernier = 19;

    private int item;

    private int item2;

    private int i = 1;

    private int i2 = 1;

    private int interieur = 19;

    private int pourcentage = 70;

    private void aleatoireInterieur()
    { 
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

    private void Start()
    { 
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
}
