using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelectButtonClicked()
    {
        SceneManager.LoadScene(2);
    }

    public void OnNewGameButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
