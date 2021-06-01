using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bddfrance : MonoBehaviour
{

    public List<string> lst_question = new List<string>();
    void Start()
    {
        lst_question.Add("En quelle année le quartier a ouvert ses portes ?, 1990, 1994, 2002, 1982");
        lst_question.Add("Quelle est l’attraction principale du quartier ?, Silver Star, Magic Cinema 4D, Madame Freudenreich Curiosités, Studio78");
        lst_question.Add("En quelle année L’attraction Eurosat - CanCan Coaster a-t-elle changé de thème ?, 2018, 2013, 2003, 1989");
        lst_question.Add("De quelle année L’attraction Eurosat - CanCan Coaster s'inspire-t-elle ?, 1900, 2000, 1400, 1700");
        lst_question.Add("Où se trouve le robot qui était à l’entrée de L’attraction Eurosat ?, Dans la file d’attente, Dans une autre attraction, Dans une boutique, Dans le circuit de l’attraction Eurosat CanCan Coaster");
        lst_question.Add("Quel est le sponsor officiel de l’attraction Silver Star?, Mercedes-Benz, BMW, Ferrari, Renault");
        lst_question.Add("En quelle année l’attraction Silver Star a ouvert?, 2002, 2005, 1990, 2000");
        lst_question.Add("Quel est la vitesse maximale du Silver star ?, 130 km/h, 127 km/h, 150 km/h, 143 km/h");
    } 

    public string ligneAleatoire()
    {

        if (lst_question.Count > 0)
        {
            int nr = Random.Range(0, lst_question.Count);
            string question = lst_question[nr];
            lst_question.RemoveAt(nr);
            return question;
        }
        return null;
    }
}
        