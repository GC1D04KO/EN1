using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int[] map;

    int GetplayerIndex()
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
        }
        return -1;
    }
    // Start is called before the first frame update
    void Start()
    {
        //デバッグログの出力
        Debug.Log("Hello world");

        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        ////デバッグログの出力
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int playerIndex = GetplayerIndex();

            for (int i = 0; i < map.Length; i++)
            {

                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }


            }
            if (playerIndex < map.Length - 1)
            {

                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;
            }

            string debugText = "";

            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int playerIndex = -1;

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }

            if (playerIndex > 0)
            {
                map[playerIndex - 1] = 1;
                map[playerIndex] = 0;
            }

            string debugText = "";

            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ", ";
            }

            Debug.Log(debugText);
        }

    }

}
}
