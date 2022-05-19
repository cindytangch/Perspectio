using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject PerspectiveCam;
    public GameObject OrthographicCam;
    public static int CamMode = 0;

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetButtonDown ("Camera")) {
            if(CamMode == 1) {
                CamMode = 0;
            }
            else {
                CamMode += 1;
            }
			StartCoroutine(CamChange());
        }
    }

    public IEnumerator CamChange () {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0) {
            PerspectiveCam.SetActive(true);
            OrthographicCam.SetActive(false);
            GameObject.Find("Button").transform.position = new Vector3(10, 10, 10);
        }
        if(CamMode == 1) {
            OrthographicCam.SetActive(true);
            PerspectiveCam.SetActive(false);
            GameObject.Find("Button").transform.position = new Vector3(3, 5.9f, -10);
        }
    }
}
