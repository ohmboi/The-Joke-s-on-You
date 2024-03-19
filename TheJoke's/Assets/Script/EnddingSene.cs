using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnddingSene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(Endandback());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Endandback()
    {
        yield return new WaitForSeconds(18f);
        SceneManager.LoadScene("StartMainMenu");
    }
}
