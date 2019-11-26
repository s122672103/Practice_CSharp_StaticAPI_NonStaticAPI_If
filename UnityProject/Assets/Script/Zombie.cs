
using UnityEngine;

public class Zombie : MonoBehaviour
{

    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊力")]
    public float Atk = 0 ;
    [Header("玩家")]
    public Player Player;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    private void Update()
    {

        ZombieAtk();
        


    }


    public void ZombieAtk()
    {

        if (Player.Hp <= 0 || Hp <= 0)
        {
            return;
        }
  

        if (Input.GetKeyDown(KeyCode.B))
        {
            Atk =  Random.Range(10f, 20f);
            Player.Hp = Player.Hp - Atk;
            print("玩家受到傷害:" + Atk);
            print("玩家剩下血量:" + Player.Hp);
            Player.PlayerHurt();
            Aud.PlayOneShot(SoundAtk, 1f);
        }

    }

    public void ZombieHurt()
    {
        if (Hp <= 0)
        {
            ZombieDie();

        }
         
    }

    public void ZombieDie()
    {
        print("殭屍死亡");

    }



}
