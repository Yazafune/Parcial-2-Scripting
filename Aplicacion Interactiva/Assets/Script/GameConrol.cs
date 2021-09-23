using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameControler { START, GAMEOVER}
public class GameConrol : MonoBehaviour
{
    public GameObject PlayerPrefab;

    public Transform PlayerStation;

    public Bala balap;

    public GameControler state;
    // Start is called before the first frame update
    void Start()
    {
        state = GameControler.START;
        Setupspawn();
    }

    // Update is called once per frame
    void Setupspawn()
    {
       // Instantiate(PlayerPrefab);
        //PlayerPrefab.transform.position = new Vector3(-0.1652964f, 0.29f, -7.06f);
    }
}
