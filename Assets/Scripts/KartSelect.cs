using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KartSelect : MonoBehaviour {

    private GameObject[] karts;
    private int kartIndex = 0;

    private void Start() {
        kartIndex = PlayerPrefs.GetInt("KartSelected");
        karts = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
            karts[i] = transform.GetChild(i).gameObject;

        foreach(GameObject go in karts)
            go.SetActive(false);

        if (karts[kartIndex])
            karts[kartIndex].SetActive(true);
    }

    public void ToggleLeft() {
        karts[kartIndex].SetActive(false);

        kartIndex--;
        if (kartIndex < 0)
            kartIndex = karts.Length - 1;

        karts[kartIndex].SetActive(true);
    }

    public void ToggleRight() {
        karts[kartIndex].SetActive(false);

        kartIndex++;
        if (kartIndex > karts.Length-1)
            kartIndex = 0;

        karts[kartIndex].SetActive(true);
    }

    public void SelectButton() {
        PlayerPrefs.SetInt("KartSelected", kartIndex);
        //karts[kartIndex].SetActive(false);
    }

    public void Back() {
        SceneManager.LoadScene("Menu");
    }
}
