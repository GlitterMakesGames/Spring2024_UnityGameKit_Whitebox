using Gamekit3D.GameCommands;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnTheKeys : MonoBehaviour
{
    public GameObject key;

    private GameObject KeyToDoorA;
    private GameObject KeyToDoorC2;

    private Vector3 KeyLocation1 = new Vector3(-40, 1, 101.5f);
    private Vector3 KeyLocation2 = new Vector3(-66.7f, 1, 126.6f);
    private Vector3 KeyLocation3 = new Vector3(-93, 1, 101.3f);

    // Start is called before the first frame update
    void Start()
    {
        Transform receptor;

        if (key != null)
        {
            KeyToDoorA = Instantiate(key);
            KeyToDoorA.transform.position = new Vector3(16, 0.5f, 0.5f);
            receptor = KeyToDoorA.transform.Find("KeyReceptor");
            receptor.position = new Vector3(-0.5f, 1, 0.3f);
            receptor.GetComponent<SendGameCommand>().interactiveObject = GameObject.Find("Door A").GetComponent<GameCommandReceiver>();
        }

        if (key != null)
        {
            KeyToDoorC2 = Instantiate(key);
            receptor = KeyToDoorC2.transform.Find("KeyReceptor");
            receptor.GetComponent<SendGameCommand>().interactiveObject = GameObject.Find("Door C2").GetComponent<GameCommandReceiver>();
            receptor.transform.parent = null;
            receptor.position = GameObject.Find("Door C2").transform.position;
            switch (UnityEngine.Random.Range(1,4))
            {
                case 1:
                    KeyToDoorC2.transform.position = KeyLocation1;
                    break;
                case 2:
                    KeyToDoorC2.transform.position = KeyLocation2;
                    break;
                case 3:
                    KeyToDoorC2.transform.position = KeyLocation3;
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
