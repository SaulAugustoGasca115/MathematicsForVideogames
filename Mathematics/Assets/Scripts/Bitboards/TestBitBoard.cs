using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestBitBoard : MonoBehaviour
{
    //[Header("Test BitBoard")]
    //public GameObject[] tilePrefabs;
    //public GameObject housePrefab;
    //public Text score;
    //long pastureBitBoard = 0;

    //public GameObject treePrefab;
    //GameObject[] tiles;
    //long treeBitBoard = 0;
    //long playerBitBoard = 0;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    CreateTileProcedure();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    ClickOnTile1();
    //}

    //void CreateTileProcedure()
    //{
    //    tiles = new GameObject[64];

    //    for(int row = 0;row<8;row++)
    //    {
    //        for(int column = 0;column<8;column++)
    //        {
    //            int randomTile = UnityEngine.Random.Range(0,tilePrefabs.Length);
    //            Vector3 position = new Vector3(column,0,row);
    //            GameObject tile = Instantiate(tilePrefabs[randomTile], position, Quaternion.identity);

    //            tile.name = tile.tag + "_" + row + "_" + column;

    //            tiles[row * 8 + column] = tile;

    //            if (tile.tag == "Pasture")
    //            {
    //                pastureBitBoard = SetCellState(pastureBitBoard, row, column);
    //                //PrintBitBoard("Pasture",pastureBitBoard);
    //            }


    //        }
    //    }

    //    Debug.Log("Pasture Cells = " + CellCount(pastureBitBoard));
    //    InvokeRepeating("PlantTree",1,1);
    //}

    //void PlantTree()
    //{
    //    int randomRow = UnityEngine.Random.Range(0, 8);
    //    int randomColumn = UnityEngine.Random.Range(0, 8);

    //    if(GetCellState(pastureBitBoard & ~playerBitBoard,randomRow,randomColumn))
    //    {
    //        GameObject tree = Instantiate(treePrefab);
    //        tree.transform.parent = tiles[randomRow * 8 + randomColumn].transform;
    //        tree.transform.localPosition = Vector3.zero;
    //        treeBitBoard = SetCellState(treeBitBoard,randomRow,randomColumn);
    //    }
    //}

    //long SetCellState(long bitboard,int row,int column)
    //{
    //    long newBit = 1L << (row * 8 + column);

    //    return (bitboard |= newBit);
    //}

    //void PrintBitBoard(string name,long bitboard)
    //{
    //    Debug.Log("<color=green>" + name + " : " + Convert.ToString(bitboard,2).PadLeft(64,'0') + "</color>"); 
    //}

    //int CellCount(long bitboard)
    //{
    //    int count = 0;
    //    long bb = bitboard;

    //    while(bb != 0)
    //    {
    //        bb &= bb - 1;
    //        count++;
    //    }

    //    return count;
    //}

    //bool GetCellState(long bitboard,int row,int column)
    //{
    //    long mask = 1L << (row * 8 +column);

    //    return ((bitboard |= mask) != 0);
    //}

    //void ClickOnTile1()
    //{
    //    //if(Input.GetMouseButtonDown(0))
    //    //{
    //    //    RaycastHit hit;
    //    //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    //    if(Physics.Raycast(ray,out hit))
    //    //    {
    //    //        GameObject house = Instantiate(housePrefab);
    //    //        house.transform.parent = hit.collider.gameObject.transform;
    //    //        house.transform.localPosition = Vector3.zero;
    //    //        playerBitBoard = SetCellState(playerBitBoard,(int)hit.collider.gameObject.transform.position.z,(int)hit.collider.gameObject.transform.position.x);
    //    //    }
    //    //}


    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hit;
    //        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            int row = (int)hit.collider.gameObject.transform.position.z;
    //            int column = (int)hit.collider.gameObject.transform.position.x;

    //            if (GetCellState(pastureBitBoard & ~treeBitBoard, row, column))
    //            {
    //                GameObject house = Instantiate(housePrefab);
    //                house.transform.parent = hit.collider.gameObject.transform;
    //                house.transform.localPosition = Vector3.zero;
    //                playerBitBoard = SetCellState(playerBitBoard, row, column);
    //            }
    //        }
    //    }
    //}

    [Header("Tile Prefabs")]
    public GameObject[] tilePrefabs;
    public GameObject housePrefab;
    public Text score;
    long dirtBitBoard = 0;

    [Header("Tile Prefabs 2")]
    public GameObject treePrefab;
    GameObject[] tiles;
    long treeBitBoard = 0;
    long playerBitBoard = 0;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new GameObject[64];

        for (int r = 0; r < 8; r++)
            for (int c = 0; c < 8; c++)
            {
                int randomTile = UnityEngine.Random.Range(0, tilePrefabs.Length);
                Vector3 position = new Vector3(c, 0, r);
                GameObject tile = Instantiate(tilePrefabs[randomTile], position, Quaternion.identity);

                tile.name = tile.tag + "_" + r + "_" + c;

                tiles[r * 8 + c] = tile;

                if (tile.tag == "Pasture")
                {
                    dirtBitBoard = SetCellSate(dirtBitBoard, r, c);
                    //PrintBB("Dirt",dirtBitBoard);
                }
            }

        Debug.Log("Dirt Cells = " + CellCount(dirtBitBoard));
        InvokeRepeating("PlantTree", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // method 1
        //if(Input.GetMouseButtonDown(0))
        //{
        //    RaycastHit hit;
        //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if(Physics.Raycast(ray, out hit))
        //    {
        //        GameObject house = Instantiate(housePrefab);
        //        house.transform.parent = hit.collider.gameObject.transform; // get the transform of the object that was hit and making the house a child of that
        //        house.transform.localPosition = Vector3.zero;
        //        playerBitBoard = SetCellSate(playerBitBoard,(int)hit.collider.gameObject.transform.position.z,(int)hit.collider.gameObject.transform.position.x);
        //    }
        //}

        //method 2

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                int row = (int)hit.collider.gameObject.transform.position.z;
                int column = (int)hit.collider.gameObject.transform.position.x;

                if (GetCellState(dirtBitBoard & ~treeBitBoard, row, column))
                {
                    GameObject house = Instantiate(housePrefab);
                    house.transform.parent = hit.collider.gameObject.transform;
                    house.transform.localPosition = Vector3.zero;
                    playerBitBoard = SetCellSate(playerBitBoard, row, column);
                }
            }
        }

    }

    void PlantTree()
    {
        int randomRow = UnityEngine.Random.Range(0, 8);
        int randomColumn = UnityEngine.Random.Range(0, 8);

        if (GetCellState(dirtBitBoard & ~playerBitBoard, randomRow, randomColumn))
        {
            GameObject tree = Instantiate(treePrefab);
            tree.transform.parent = tiles[randomRow * 8 + randomColumn].transform;
            tree.transform.localPosition = Vector3.zero;
            treeBitBoard = SetCellSate(treeBitBoard, randomRow, randomColumn);
        }
    }

    long SetCellSate(long bitboard, int row, int col)
    {
        long newBit = 1L << (row * 8 + col);

        return (bitboard |= newBit);
    }

    bool GetCellState(long bitboard, int row, int column)
    {
        long mask = 1L << (row * 8 + column);

        return ((bitboard & mask) != 0);
    }

    void PrintBB(string name, long BB)
    {
        Debug.Log(name + " : " + Convert.ToString(BB, 2).PadLeft(64, '0'));
    }

    int CellCount(long bitboard)
    {
        int count = 0;
        long bb = bitboard;

        while (bb != 0)
        {
            bb &= bb - 1;
            count++;
        }

        return count;
    }
}
