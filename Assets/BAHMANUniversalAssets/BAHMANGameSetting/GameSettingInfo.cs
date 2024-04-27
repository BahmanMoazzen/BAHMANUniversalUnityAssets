using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
public class GameSettingInfo : ScriptableObject
{
    public static event UnityAction<bool> OnMusicChange;
    public static event UnityAction<bool> OnSoundFXChange;
    public bool SoundFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
