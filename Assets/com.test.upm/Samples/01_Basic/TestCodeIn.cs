using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCodeIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestCodeIn Start");
        Debug.Log("1 + 2 = " + Test.Sum(1, 2));
        Debug.Log("1 - 2 = " + Test.Subtract(1, 2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
