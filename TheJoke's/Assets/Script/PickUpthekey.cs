using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpthekey : MonoBehaviour
{
    public GameObject collectTextObj, intText, whiteclown, collectobjwin;
    public AudioSource pickupSound, laughJoker, ambianceLayer3, ambianceLayer5, ambianceLayer7 /*ambianceLayer10*/; 
        //ambianceLayer4, ambianceLayer5, ambianceLayer6, ambianceLayer7, ambianceLayer8, 
        //ambianceLayer9, ambianceLayer10;
    public bool interactable;
    public static int keyCollected;
    public Text collectText;

    public string SceneEndtogo;

    //public string MovesceneName;
    //public float WinnerTime;
    // Start is called before the first frame update
    void Start()
    {
        keyCollected = 0;
    }
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(interactable == true)
        {
            if(Input.GetKey(KeyCode.E))
            {
                keyCollected = keyCollected + 1;
                if(whiteclown.active == false)
                {
                    whiteclown.SetActive(true);
                }
                collectText.text = keyCollected + "/8 Key";
                collectTextObj.SetActive(true);
                pickupSound.Play();
                laughJoker.Play();
                if (keyCollected == 3)
                {
                    ambianceLayer3.Play();
                }
                if (keyCollected == 5)
                {
                    ambianceLayer5.Play();
                    ambianceLayer3.Stop();
                }
                if (keyCollected == 7)
                {
                    ambianceLayer7.Play();
                    ambianceLayer5.Stop();
                    ambianceLayer3.Stop();
                }
                if (keyCollected == 8)
                {
                    EnddingScene();
                    //collectobjwin.SetActive(true);
                    //whiteclown.SetActive(false);
                    //StartCoroutine(Endding());
                }
                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }
        //IEnumerator Endding()
        //{
        //    yield return new WaitForSeconds(WinnerTime);
        //    SceneManager.LoadScene(MovesceneName);
        //}
    }
    public void EnddingScene()
    {
        //StartCoroutine(waitwait());
        SceneManager.LoadScene(SceneEndtogo);
    }
    //IEnumerator waitwait()
    //{
    //    yield return new WaitForSeconds(3f);
    //    SceneManager.LoadScene(SceneEndtogo);
    //}
}
