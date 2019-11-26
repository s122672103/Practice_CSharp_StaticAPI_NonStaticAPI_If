
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊力")]
    public float Atk = 0;
    [Header("殭屍")]
    public Zombie Zb;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;


    private void Update()
    {

        PlayerAtk();


    }


    public void PlayerAtk()
    {


        if (Zb.Hp <= 0 || Hp <= 0)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Atk =  Random.Range(10f, 20f);
            Zb.Hp = Zb.Hp - Atk;
            
            print("殭屍受到傷害:" + Atk);
            print("殭屍剩下血量:" + Zb.Hp);
            Zb.ZombieHurt();
            Aud.PlayOneShot(SoundAtk, 1f);
        }



    }

    public void PlayerHurt()
    {

        if (Hp <= 0)
        {
            PlayerDie();

        }

    }

    public void PlayerDie()
    {
      
        
       print("玩家死亡");
        

    }


}
