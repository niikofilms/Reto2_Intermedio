using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CotinueButom : MonoBehaviour
{
    // Start is called before the first frame update
    public RaceManager playerPosition_1;
    int position;
    void Start()
    {
            }

    // Update is called once per frame
    void Update()
    {
        position = playerPosition_1.playerPosition;
    }

    public void SiguienteNivel()

    {
        Scene ActiveScene = SceneManager.GetActiveScene();


        if (position < 4)
        {

            switch (ActiveScene.name)
            {
                case "DayanaScenePrueba":


                    SceneManager.LoadScene("NicolasScene");

                    break;

                case "NicolasScene":

                    SceneManager.LoadScene("AlejandroScene");

                    break;

                case "AlejandroScene":

                    SceneManager.LoadScene("MenuPrincipal");

                    break;

                default:

                    SceneManager.LoadScene("MenuPrincipal");
                    break;
            }
            
        }
        else
        {
            SceneManager.LoadScene(ActiveScene.name);
        }
    }
}
