using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.SetState("GameState", "Puzzle");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameState(int newState)
    {
        switch (newState)
        {
            case 0:
                AkSoundEngine.SetState("GameState", "None");
                break;
            case 1:
                AkSoundEngine.SetState("GameState", "Puzzle");
                break;
            case 2:
                AkSoundEngine.SetState("GameState", "Discovery");
                break;
            case 3:
                AkSoundEngine.SetState("GameState", "Victory");
                break;
        }
    }
}
