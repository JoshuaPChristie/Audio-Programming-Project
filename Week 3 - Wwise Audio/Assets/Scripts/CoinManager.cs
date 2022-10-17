using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int CoinsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.SetState("CoinsCollected", "Zero");
    }

    // Update is called once per frame
    void Update()
    {
        switch(CoinsCollected)
        {
            case 0:
                AkSoundEngine.SetState("CoinsCollected", "Zero");
                break;
            case 1:
                AkSoundEngine.SetState("CoinsCollected", "One");
                break;
            case 2:
                AkSoundEngine.SetState("CoinsCollected", "Two");
                break;
            case 3:
                AkSoundEngine.SetState("CoinsCollected", "Three");
                break;
            case 4:
                AkSoundEngine.SetState("CoinsCollected", "Four");
                break;
            case 5:
                AkSoundEngine.SetState("CoinsCollected", "Five");
                break;
        }
    }

    public void Collect()
    {
        CoinsCollected++;
    }
}
