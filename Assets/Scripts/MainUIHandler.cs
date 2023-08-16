using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TextMeshProUGUI highscore;
    // Start is called before the first frame update
    void Start()
    {
        userName.text = DataManager.Instance.Username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
