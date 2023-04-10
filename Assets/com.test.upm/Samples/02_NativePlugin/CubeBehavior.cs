using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    IEnumerator CubeMove()
    {
        yield return new WaitForSeconds(0.1f);
        transform.position = new Vector3(0, NativeAPI.CountUp() % 10, 0);
        StartCoroutine(CubeMove());
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeMove());
    }

    // Update is called once per frame
    void Update()
    {
    }
}
