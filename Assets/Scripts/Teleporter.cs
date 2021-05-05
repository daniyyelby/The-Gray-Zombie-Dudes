using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleporter : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject Text;
    AudioSource source;

    // Start is called before the first frame update
    private void Start()
    {
        Text.SetActive(false);
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        StartCoroutine(checkIt());
        source.Play();

    }

    IEnumerator checkIt()
    {

        if (thePlayer.transform.position == teleportTarget.transform.position)
        {
            Text.SetActive(true); // Enable the text so it shows
            yield return new WaitForSeconds(3);
            Text.SetActive(false);
        }
    }
}
