using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : MonoBehaviour
{
    public float maxDistance = 50.0f;
    public GameObject bullet;
    public float bulletSpeed = 20.0f;

    public float minFOV = 15.0f;
    public float maxFOV = 60.0f;
    public float sensitivity = 90.0f;
    public AudioSource audioSource1;
    public AudioClip clip1;
    public AudioSource audioSource2;
    public AudioClip clip2;
    public AudioSource audioSource3;
    public AudioClip clip3;
    public float volume = 0.5f;

    EnemyHealthController enemyHealthController;
    ScoreController scoreController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFOV, maxFOV);
        Camera.main.fieldOfView = fov;
        //RaycastHit hit;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * maxDistance, Color.red);

        if (Input.GetButtonDown("Fire1") || Input.GetKey(KeyCode.Keypad1))
        {
            GameObject b = Instantiate(bullet, Camera.main.transform.position, Camera.main.transform.rotation);
            Rigidbody rb = b.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * bulletSpeed;
        }

        if (gameObject.tag == "Ethan" && enemyHealthController.enemyHealth <= 0)
        {
            gameObject.SendMessage("increaseScore", 2);
        }
  

        //if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward * maxDistance, out hit, maxDistance))
        //{
        //    Debug.Log(hit.transform.gameObject.tag + " at " + hit.distance + " meters.");
        //}  
        //else
        //{
        //    Debug.Log("Nothing hit");
        //}
    }

    private void OnTriggerEnter(Collider other)
    {


         if (other.gameObject.tag == "HealthIncrease")
        {
            audioSource1.PlayOneShot(audioSource1.clip, volume);
            gameObject.SendMessage("increase", 5);
            Destroy(other.gameObject);
            
        }

        if (other.gameObject.tag == "Ethan")
        {
            audioSource2.PlayOneShot(audioSource2.clip, volume);
            gameObject.SendMessage("damage", 2);
            
        }

        if (other.gameObject.tag == "CollectionCube")
        {
            audioSource3.PlayOneShot(audioSource3.clip, volume);
            gameObject.SendMessage("increaseScore", 5);
            Destroy(other.gameObject);

        }

    }


}
