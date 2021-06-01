using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text txt;
    public Sprite im_normal, im_vrai, im_faux;
    public AudioClip sound_win, sound_wrong;

    public void UpdateTxt(string str_text)
    {
        txt.text = str_text;
        GetComponent<Image>().sprite = im_normal;
    }

    public void SelectButton()
    {
        if(GameObject.Find("Canvas").GetComponent<QuizzManager>().canPlay)
        {
            GameObject.Find("Canvas").GetComponent<QuizzManager>().canPlay = false;
        }
        string reponse = GameObject.Find("Canvas").GetComponent<QuizzManager>().reponse;

        if (transform.Find("Text").GetComponent<Text>().text == reponse)
        {
            //bon
            GetComponent<AudioSource>().PlayOneShot(sound_win);
            UpdateTrue();
            StartCoroutine(Next_question());
        }
        else
        {
            //faux 
            GetComponent<AudioSource>().PlayOneShot(sound_wrong);
            UpdateFalse();
        }

    }



    IEnumerator Next_question()
    {
        yield return new WaitForSeconds(2f);
        GameObject.Find("Canvas").GetComponent<QuizzManager>().tirage();

    }
    public void UpdateTrue()
    {
        GetComponent<Image>().sprite = im_vrai;
    }
    public void UpdateFalse()
    {
        GetComponent<Image>().sprite = im_faux;
    }

}
