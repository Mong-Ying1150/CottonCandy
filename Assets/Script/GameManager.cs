using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;
    public AudioSource background;


    private static GameManager _instance;
    public static GameManager instance => _instance;

    public GameObject _pausedScreen;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EInteract();

        
    }


    ///////////////////////////////////////////////////////////////////// FUNCTIONs
    public void EInteract () //pressed E to Interact
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressed E to Interact");



        }*/
    }

   
       




}
