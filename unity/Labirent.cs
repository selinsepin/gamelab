using UnityEngine;
using System.Collections;
using System.Linq;


public class Labirent : MonoBehaviour {

    public bool[,] CoinArray;
    private Vector2 _patternSize;
    public Pattern ChoosenPattern = 0;
    public int PatternCount=0;
 public enum Pattern : byte
    {
        Yibin = 0,
        Sunny = 1,
        Eliza = 2,
        Sahar = 3,
       
    }
 public void InitializeCoins()
    {
        GenerateArray(ChoosenPattern);

        for (int i = 0; i < (_patternSize.x-1*_patternSize.y-1); i++)
        {
            var coin = Instantiate(Resources.Load("LED"), new Vector3(), Quaternion.identity) as GameObject;

            if (coin != null)
            {
                coin.gameObject.active = false;
               // coin.gameObject.transform.parent = ItemManager.Current.Level;

                
            }
        }
        
    }

    public Transform GetCoin()
    {
        
        
            var coin = Instantiate(Resources.Load("LED"), new Vector3(), Quaternion.identity) as GameObject;

            if (coin != null)
            {
                // coin.transform.parent = ItemManager.Current.Level;

                return coin.transform;
            }
            else return null;
    }
    public Transform GetWall()
    {


        var wall = Instantiate(Resources.Load("Wall"), new Vector3(), Quaternion.identity) as GameObject;

        if (wall != null)
        {
            // coin.transform.parent = ItemManager.Current.Level;

            return wall.transform;
        }
        else return null;
    }

    private void CreateCoins()
    {
        
            DrawCoins(ChoosenPattern, new Vector3(-200, -200,  0f ), 2);
        
    }

    public void DrawCoins(Pattern pattern, Vector3 startingPoint, float offset)
    {
        //GenerateArray(pattern);

        for (int i = 0; i < _patternSize.x; i++)
        {
            for (int j = 0; j < _patternSize.y; j++)
            {
                if (CoinArray[j, i])
                {
                    Vector3 targetPosition = new Vector3(startingPoint.x + (40 * i + offset), startingPoint.y + (40 * j - offset), startingPoint.z);

                    Transform currentCoin = GetCoin();

                    currentCoin.transform.position = targetPosition;
                    currentCoin.gameObject.active = true;
                    PatternCount++;

                }
                else
                {
                    Vector3 targetPosition = new Vector3(startingPoint.x + (40 * i + offset), startingPoint.y + (40 * j - offset), startingPoint.z);

                    Transform currentWall = GetWall();

                    currentWall.transform.position = targetPosition;
                    currentWall.gameObject.active = true;
                }

            }
        }
    }


 public void GenerateArray(Pattern pattern)
    {
        #region Patterns
        switch (pattern)
        {
          
            case Pattern.Eliza:
                CoinArray = new[,] { { true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	true,	true,	true,	true,	true,},
                                     { false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	false,	false,	false,	false,},
                                     { true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	true,	true,	true,	true,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,},
                                     { true,	true,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,},
                                     { true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	true,	true,	true,	false,	false,	false,	false,	false,	true,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     { false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	true,	true,	true,	false,	false,	false,	false,	false,	true,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,},
                                     { true,	true,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,},
                                     { true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	true,	true,	true,	true,	true,},
                                     { false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	false,	false,	false,	false,},
                                     { true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	true,	true,	true,	true,	true,},
                                     { true,	false,	false,	false,	false,	false,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	true,	false,	true,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	true,},
                                     { true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	true,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     };
                _patternSize.x = 33;
                _patternSize.y = 26;
                break;
            case Pattern.Sunny:
               
                CoinArray = new[,] { {false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false, },
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	true,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false, },
                                     {false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	true,	true,	true,	true,	true,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false, },
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	true,	true,	true,	true,	true,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false, },
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	true,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false, },
                                     {false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	true,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false,	false, },
                                     };
                _patternSize.x = 36;
                _patternSize.y = 26;
                break;
            case Pattern.Yibin: 
                CoinArray = new[,] { { true, true,  true,  true,   true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true , true, true,  true,  true,  true,  true,  true,  true,  true},
                                     { true, false, false, false,  false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true},
                                     { true, false, false, false,  false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true},
                                     { true, true,  true,  true,   true,  true,  true,  true,  true,  false, false, true,  true,  true,  true,  false, false, true, true,  true,  true,  true,  true,  true,  true,  true},
                                     { true, false, false, false,  false, false, false, false, true,  false, false, true,  false, false, true,  false, false, true, false, false, false, false, false, false, false, true},
                                     { true, false, false, false,  false, false, false, false, true,  false, false, true,  false, false, true,  false, false, true, false, false, false, false, false, false, false, true},
                                     { true, false, false, true,   true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true, true,  true,  true,  true,  true,  false, false, true},
                                     { true, false, false, true,   false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, true,  false, false, true},
                                     { true, false, false, true,   false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, true,  false, false, true},
                                     { true, true,  true,  true,   true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true , true, false, false, true,  true,  true,  true,  true,  true},
                                     { false,false, false, false,  false, true,  false, false, true,  false, false, false, false, false, false, false, false, true, false, false, true, false, false, false, false,  false},
                                     { false,false, false, false,  false, true,  false, false, true,  false, false, false, false, false, false, false, false, true, false, false, true, false, false, false, false,  false},
                                     { true, true,  true,  true,   true,  true,  true,  true,  true,  false, false, false, false, false, false, false, false, true, true,  true,  true,  true,  true,  true,  true,  true},
                                     { false,false, false, false,  false, true,  false, false, true,  false, false, false, false, false, false, false, false, true, false, false, true, false, false, false, false,  false},
                                     { false,false, false, false,  false, true,  false, false, true,  false, false, false, false, false, false, false, false, true, false, false, true, false, false, false, false,  false},
                                     { true, true,  true,  true,   true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true , true, false, false, true,  true,  true,  true,  true,  true},
                                     { true, false, true,  false,  false, false, false, false, false, false, false, true,  false, false, true,  false, false, false,false, false, false, false, false, true, false,  true},
                                     { true, false, true,  false,  false, false, false, false, false, false, false, true,  false, false, true,  false, false, false,false, false, false, false, false, true, false,  true},
                                     { true, false, true,  true,   true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true, true,  true,  true,  true,  true,  true, false,  true},
                                     { true, false, true,  false,  false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, false, true, false,  true},
                                     { true, false, true,  false,  false, false, false, false, true,  false, false, false, false, false, false, false, false, true, false, false, false, false, false, true, false,  true},
                                     { true, true,  true,  true,   true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true , true, true,  true,  true,  true,  true,  true, true,   true},
                                     { true, false, false, false, false,  true, false,  false, false, false, false, true,  false, false, true,  false, false, false,false, false, true,  false, false, false,false,  true},
                                     { true, false, false, false, false,  true, false,  false, false, false, false, true,  false, false, true,  false, false, false,false, false, true,  false, false, false,false,  true},
                                     { true, false, false, false, false,  true, false,  false, true,  true,  true,  true,  false, false, true,  true,  true,  true, false, false, true,  false, false, false,false,  true},
                                     { true, false, false, false, false,  true, false,  false, true,  false, false, false, false, false, false, false, false, true, false, false, true,  false, false, false,false,  true},
                                     { true, false, false, false, false,  true, false,  false, true,  false, false, false, false, false, false, false, false, true, false, false, true,  false, false, false,false,  true},
                                     { true, true,  true,  true,   true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true , true, true,  true,  true,  true,  true,  true, true,   true},
                                     };
                
                _patternSize.x = 26;
                _patternSize.y = 28;
                break;

                
                
                
              

            case Pattern.Sahar:
                CoinArray = new[,] { {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	true,	true,	true,	true,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,	true,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                     {false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,	false,	true,	false,	false,	false,},
                                   
                                     };

                _patternSize.x = 30;
                _patternSize.y = 30;
                break;
        }
        #endregion
    }




	// Use this for initialization
	void Start () {
        InitializeCoins();
        CreateCoins();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
