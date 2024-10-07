using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && Time.timeScale == 0)
        {
            Resume();
        }
    }
    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void Relodlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}