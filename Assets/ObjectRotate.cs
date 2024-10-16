using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start objet");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update objet");
        transform.Rotate(new Vector3(15, 20, 12) * Time.deltaTime);
    }
}
