using System.Collections;
using UnityEngine;

public class mm : MonoBehaviour
{
    public GameObject clonePF;
    void Start()
    {
      randNum = Random.Range(0, 5);
      if (randNum == 0)
      {
         obj1.SetActive(true);
      }
      if (randNum == 1)
      {
         obj2.SetActive(true);
      }
      if (randNum == 2)
      {
         obj3.SetActive(true);
      }
      if (randNum == 3)
      {
         obj4.SetActive(true);
      }
      if (randNum == 4)
      {
         obj5.SetActive(true);
      }
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
        GameObject cloneGO = Instantiate(clonePF,new Vector2(transform.position.x + 0.5f, transform.position.y),Quaternion.identity );
        yield return new WaitForSecondsRealtime(2);
        Destroy(cloneGO);
    }
        }

int randNum;
public GameObject obj1, obj2, obj3, obj4, obj5;
