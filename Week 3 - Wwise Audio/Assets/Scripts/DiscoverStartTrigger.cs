using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoverStartTrigger : MonoBehaviour
{
    public MusicManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            manager.SetGameState(2);
            gameObject.SetActive(false);
        }
    }

}
