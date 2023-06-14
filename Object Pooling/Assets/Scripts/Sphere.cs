using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Vector3 startPosition;
    // Start is called before the first frame 
    private void OnEnable()
    {
        startPosition = gameObject.transform.position;
        StartCoroutine(ObjectDisabled());
    }
    private IEnumerator ObjectDisabled()
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
        gameObject.SetActive(false);
    }
}
