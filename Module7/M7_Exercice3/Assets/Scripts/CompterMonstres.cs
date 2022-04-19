using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompterMonstres : MonoBehaviour
{

    private GameObject[] monstres;
    // Start is called before the first frame update

    private int nombreMonstres;


    void Start()
    {
        monstres = GameObject.FindGameObjectsWithTag("Monstre");
        nombreMonstres = monstres.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //int nombreAttrapes = 0;

        //for (int i = 0; i < monstres.Length; i++)
        //{
        //    if (monstres[i] == null)
        //    {
        //        nombreAttrapes++;
        //    }
        //}

        //if (nombreAttrapes == monstres.Length)
        //{
        //    SceneManager.LoadScene("Victoire");
        //}
    }

    public void RetirerMonstre()
    {
        nombreMonstres--;
        if (nombreMonstres == 0)
        {
            SceneManager.LoadScene("Victoire");
        }
    }


}
