using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Este metodo carga la proxima escena del juego.
    public void loadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //aqui inizializamos la escena actual
        SceneManager.LoadScene(currentSceneIndex+1); //aqui cargamos la siguiente escena
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    //quits the game
    public void Quit()
    {
        Application.Quit();
    }
}
