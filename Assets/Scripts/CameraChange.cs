using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject PerspectiveCam;
    public GameObject OrthographicCam;
    public static int CamMode = 1;

		// Start is called before the first frame update
    void Start()
    {
        CamMode = 1;
    }

    // Update is called once per frame
    void Update ()
    {
			StartCoroutine(CamChange());

	    if(Input.GetButtonDown ("Camera")) {
	      if(CamMode == 1) {
	          CamMode = 0;
	      }
	      else {
	          CamMode += 1;
	      }
	    }
    }

    public IEnumerator CamChange () {
        yield return new WaitForSeconds(0.01f);

        if(CamMode == 1) {
            PerspectiveCam.SetActive(true);
            OrthographicCam.SetActive(false);
            GameObject.Find("Button").transform.position = new Vector3(15, 15, 15);
        }

        if(CamMode == 0) {
            OrthographicCam.SetActive(true);
            PerspectiveCam.SetActive(false);
            GameObject.Find("Button").transform.position = new Vector3(3, 5.9f, -10);
        }
    }
}
