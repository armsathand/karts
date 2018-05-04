using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackSelect : MonoBehaviour {

    private GameObject[] tracks;
    private int trackIndex = 0;

    private void Start() {
        trackIndex = PlayerPrefs.GetInt("TrackSelected");
        tracks = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            tracks[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in tracks)
            go.SetActive(false);

        if (tracks[trackIndex])
            tracks[trackIndex].SetActive(true);
    }

    public void ToggleLeft() {
        tracks[trackIndex].SetActive(false);

        trackIndex--;
        if (trackIndex < 0)
            trackIndex = tracks.Length - 1;

        tracks[trackIndex].SetActive(true);
    }

    public void ToggleRight() {
        tracks[trackIndex].SetActive(false);

        trackIndex++;
        if (trackIndex > tracks.Length - 1)
            trackIndex = 0;

        tracks[trackIndex].SetActive(true);
    }

    public void SelectButton() {
        PlayerPrefs.SetInt("TrackSelected", trackIndex);
        //tracks[trackIndex].SetActive(false);
        if(trackIndex == 0) {
            SceneManager.LoadScene("Track_0");
        } else {
            SceneManager.LoadScene("Track_1");
        }
        
    }

    public void Back() {
        SceneManager.LoadScene("Menu");
    }
}
