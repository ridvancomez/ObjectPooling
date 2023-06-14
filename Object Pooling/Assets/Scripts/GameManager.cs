using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField, Tooltip("Olu�turulacak Olan Objeler")]
    private GameObject[] createdObjects;
    [SerializeField, Tooltip("Do�ma Noktas�")]
    private Transform bornPoint;
    void Start()
    {
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            
            foreach(GameObject gameObject in createdObjects) 
            {
                if(!gameObject.activeSelf)
                {
                    gameObject.SetActive(true);
                    break;
                }

            }
        }
    }
}
