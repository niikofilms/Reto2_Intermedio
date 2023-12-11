using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CotinueButom : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerPosition_1;


    void Start()
    {

       playerPosition_1 = RaceManager.playerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        SiguienteNivel();
    }

    public void SiguienteNivel()

    {
        Scene ActiveScene = SceneManager.GetActiveScene();


        if (playerPosition_1 != 0 && playerPosition_1 < 4)
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
                    break;
            }

        }
    }
}
