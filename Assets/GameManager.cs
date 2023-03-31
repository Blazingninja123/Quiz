using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        GameManager.instance.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text myText = GetComponent<Text>();
        myText.text = GameManager.instance.score + "";
    }

}
