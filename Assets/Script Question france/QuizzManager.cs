using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizzManager : MonoBehaviour {

    public Text txtquestion;
    bddfrance bdd_quizz;
    public string p1, p2, p3, p4, reponse;
    public bool canPlay;

    void Start() {
        bdd_quizz = GetComponent<bddfrance>();
        tirage();

    }

    public void tirage()
    {
        canPlay = true;
        string temp = bdd_quizz.ligneAleatoire();
        if (temp != null)
        {
            string[] tab_temp = temp.Split(',');
            txtquestion.text = tab_temp[0];
            reponse = tab_temp[1];

            Melange(tab_temp);

            p1 = tab_temp[1];
            p2 = tab_temp[2];
            p3 = tab_temp[3];
            p4 = tab_temp[4];

            //afichage des propositions dans les boutons
            GameObject.Find("B1").GetComponent<ButtonScript>().UpdateTxt(p1);
            GameObject.Find("B2").GetComponent<ButtonScript>().UpdateTxt(p2);
            GameObject.Find("B3").GetComponent<ButtonScript>().UpdateTxt(p3);
            GameObject.Find("B4").GetComponent<ButtonScript>().UpdateTxt(p4);
        }
        else
        {
            SceneManager.LoadScene("Menu Epquizz");
        }
    }

    void Melange(string[] tableau)

    {
        for (int i=1; i<tableau.Length; i++) 
        {
            string tmp = tableau[i];
            int r = Random.Range(i, tableau.Length);
            tableau[i] = tableau[r];
            tableau[r] = tmp;
        }
    }

    private void Update() {
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
            tirage();
            }

        } 
    } 
}



    
