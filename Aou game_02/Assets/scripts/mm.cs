using System.Collections;
using UnityEngine;

public class mm : MonoBehaviour
{
    public GameObject clonePF;
    int randNumX;
    int randNumY;
    public GameObject obj1, obj2, obj3, obj4, obj5;
    void Start()
    {
      
    }


    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            StartCoroutine(Cloning());
        }
        }
    IEnumerator Cloning()
    {
        randomPos();
        GameObject cloneGO = Instantiate(clonePF,new Vector2(randNumX + 0.5f, 5),Quaternion.identity);
        yield return new WaitForSecondsRealtime(2);
        Destroy(cloneGO);
    }

    void randomPos() 
    {

        randNumX = Random.Range(-14, 17);

    }
        


}

