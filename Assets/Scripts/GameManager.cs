using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float minAttractionDistance = 5f;
    public float maxAttractionDistance = 5f;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(this);
    }


    // Update is called once per frame
    void Update()
    {
        TouchManager.Update();
    }
}
