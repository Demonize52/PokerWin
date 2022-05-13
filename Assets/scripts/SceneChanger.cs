using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // позволяет нам работать со сценами

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(int ID)//функция проверки ID сцены
    {
        SceneManager.LoadScene(ID);//загрузка сценв с нужным нам ID
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
