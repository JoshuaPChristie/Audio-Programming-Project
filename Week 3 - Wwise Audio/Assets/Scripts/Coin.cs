using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public AK.Wwise.Event sparkleSound = new AK.Wwise.Event();
    public AK.Wwise.Event pickupSound = new AK.Wwise.Event();

    public CoinManager manager;

    private float rotSpeed = 40.0f;
    private bool collected = false;

    // Start is called before the first frame update
    void Start()
    {
        sparkleSound.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!collected && other.gameObject.name == "Player")
        {
            sparkleSound.Stop(gameObject);
            pickupSound.Post(gameObject, (uint)AkCallbackType.AK_EndOfEvent, CoinCallBack);
            GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void CoinCallBack(object in_cookie, AkCallbackType in_type, object in_info)
    {
        manager.Collect();
        gameObject.SetActive(false);
    }
}

