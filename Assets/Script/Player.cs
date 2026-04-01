using UnityEngine;

public class Player : MonoBehaviour
{
    public BaseStats stats;


    private void Awake()
    {
        stats = new BaseStats(10, 10, 5, 1, 20);//->A
        print(stats.Power);

//        stats.Power = 1;
        
    }
    void Start()
    {
      //  Destroy(this.gameObject);
    }

    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Debug.Log("oh no me cancelaron");
    }
}
