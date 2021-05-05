using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOpeningCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("OpeningCutscene");
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SceneManager.LoadScene(0);
        }
    }
}
