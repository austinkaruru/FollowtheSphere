using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float timer = 5f;
    void Start()
    {
        cam2.SetActive(false);
        StartCoroutine(SwitchCamera());
    }
    private IEnumerator SwitchCamera()
    {
        yield return new WaitForSeconds(timer);
        cam1.SetActive(false);
        cam2.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SKey")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("AKey")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
