using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffsetFix : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(FixCamera());
    }

    IEnumerator FixCamera()
    {
        yield return new WaitForSeconds(0.275f);
        transform.localPosition = new Vector3(transform.localPosition.x, 1.25f, transform.localPosition.z);
    }
}