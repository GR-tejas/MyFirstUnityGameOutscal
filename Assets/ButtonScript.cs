using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public Button Button;
    public string SceneName;
    public void Start()
    {
        Button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        //Debug.Log("Button Clicked");
        SceneManager.LoadScene(SceneName);
    }

}
