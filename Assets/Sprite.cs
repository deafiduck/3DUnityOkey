using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{
    public GameObject placeHoldersParent;
    public List<Sprite> sprites;
    //her oyuncunun taþlarýný tutan listeler
    public List<Sprite> Player1Blocks;
    public List<Sprite> Player2Blocks;
    public List<Sprite> Player3Blocks;
    public List<Sprite> Player4Blocks;
    void Start()
    {
        //her taþtan iki tane olacak
        sprites.AddRange(sprites);
    }

    public void StartGame()
    {
        for(int i = 0; i < sprites.Count; i++)
        {
            Player1Blocks.Add(sprites[Random.Range(0, sprites.Count)]);
            Player2Blocks.Add(sprites[Random.Range(0, sprites.Count)]);
            Player3Blocks.Add(sprites[Random.Range(0, sprites.Count)]);
            Player4Blocks.Add(sprites[Random.Range(0, sprites.Count)]);

        }
        Player1Blocks.Add(sprites[Random.Range(0, sprites.Count)]);//birinci oyuncuya eklenecek fazlalýk taþ
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
