using UnityEngine;

namespace Assets.Scripts.Models
{
    public class CardModel : ScriptableObject
    {
        public Texture Texture;
        public int maxHp;
        public int defense;
        public int dmg;
        public int number;
        public new string name;
        public string type;
        public float criticalChance;
    }
}
